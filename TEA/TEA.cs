using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_17714.TEAAlg;

internal class TEA : ICryptoAlgorithm
{
    private readonly uint _k0, _k1, _k2, _k3;
    private readonly uint _delta = 0x9E3779B9;

    public TEA(uint[] key)
    {
        if (key.Length != 4)
        {
            throw new ArgumentException("Key length must be 128 bits!");
        }
        _k0 = key[0];
        _k1 = key[1];
        _k2 = key[2];
        _k3 = key[3];
    }

    public void EncryptBlock(uint[] buffer)
    {
        for (int k = 0; k < buffer.Length; k += 2)
        {
            EncryptNext(buffer, k);
        }
    }

    protected virtual void EncryptNext(uint[] buffer, int startPos) 
    {
        uint v0 = buffer[startPos], v1 = buffer[startPos + 1];
        uint sum = 0;

        for (int i = 0; i < 32; i++)
        {
            sum += _delta;
            v0 += (v1 << 4) + _k0 ^ v1 + sum ^ (v1 >> 5) + _k1;
            v1 += (v0 << 4) + _k2 ^ v0 + sum ^ (v0 >> 5) + _k3;
        }

        buffer[startPos] = v0;
        buffer[startPos + 1] = v1;
    }

    public void DecryptBlock(uint[] buffer)
    {
        for (int k = 0; k < buffer.Length; k += 2)
        {
            DecryptNext(buffer, k);
        }
    }

    protected virtual void DecryptNext(uint[] buffer, int startPos)
    {
        uint v0 = buffer[startPos], v1 = buffer[startPos + 1];
        uint sum = 0xC6EF3720;

        for (int i = 0; i < 32; i++)
        {
            v1 -= (v0 << 4) + _k2 ^ v0 + sum ^ (v0 >> 5) + _k3;
            v0 -= (v1 << 4) + _k0 ^ v1 + sum ^ (v1 >> 5) + _k1;
            sum -= _delta;
        }

        buffer[startPos] = v0;
        buffer[startPos + 1] = v1;
    }

    public virtual void EncryptFile(Stream fileInputStream, Stream fileOutputStream)
    {
        using FileReader reader = new(fileInputStream, 8, PadBytes.PadCount);
        using BinaryWriter writer = new(fileOutputStream);

        const int blockSize = 512;

        while (reader.HasMoraData())
        {
            byte[] buffer = reader.ReadNextBlock(blockSize);

            uint[] uintBuffer = new uint[buffer.Length / 4];

            for (int i = 0; i < uintBuffer.Length; i++)
            {
                uintBuffer[i] = BitConverter.ToUInt32(buffer, i * 4);
            }

            EncryptBlock(uintBuffer);

            foreach (uint i in uintBuffer)
            {
                writer.Write(i);
            }
        }
    }

    public virtual void DecryptFile(Stream fileInputStream, Stream fileOutputStream)
    {
        using FileReader reader = new(fileInputStream, 8, PadBytes.PadCount);
        using BinaryWriter writer = new(fileOutputStream);

        const int blockSize = 512;

        while (reader.HasMoraData())
        {
            byte[] buffer = reader.ReadNextBlock(blockSize);

            uint[] uintBuffer = new uint[buffer.Length / 4];

            for (int i = 0; i < uintBuffer.Length; i++)
            {
                uintBuffer[i] = BitConverter.ToUInt32(buffer, i * 4);
            }

            DecryptBlock(uintBuffer);

            for (int i = 0; i < uintBuffer.Length; i++)
            {
                Array.Copy(BitConverter.GetBytes(uintBuffer[i]), 0, buffer, i * 4, 4);
            }

            if (reader.HasMoraData())
            {
                writer.Write(buffer);
            }
            else
            {
                int padCount = FileReader.GetPadCount(buffer, 7, PadBytes.PadCount);
                writer.Write(buffer, 0, buffer.Length - padCount);
            }
        }
    }
}
