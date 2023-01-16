using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_17714.TEAAlg;

internal class MultithreadedTEA : TEA
{
    private readonly int _threadCount;

    public MultithreadedTEA(uint[] key, int threadCount) : base(key)
    {
        _threadCount = threadCount;
    }
    public override void EncryptFile(Stream fileInputStream, Stream fileOutputStream)
    {
        using FileReader reader = new(fileInputStream, 8, PadBytes.PadCount);
        using BinaryWriter writer = new(fileOutputStream);

        byte[] file = reader.ReadFile();
        uint[] uintFile = new uint[file.Length / 4];

        for (int i = 0; i < uintFile.Length; i++)
        {
            uintFile[i] = BitConverter.ToUInt32(file, i * 4);
        }

        var tasks = new List<Task>();

        for (int i = 0; i < _threadCount; i++)
        {
            tasks.Add(Encrypt(i * 2, uintFile));
        }

        Task.WhenAll(tasks).Wait();

        foreach (uint i in uintFile)
        {
            writer.Write(i);
        }

        reader.Dispose();
        writer.Dispose();
    }

    public override void DecryptFile(Stream fileInputStream, Stream fileOutputStream)
    {
        using FileReader reader = new(fileInputStream, 8, PadBytes.PadCount);
        using BinaryWriter writer = new(fileOutputStream);

        byte[] file = reader.ReadFile();
        uint[] uintFile = new uint[file.Length / 4];

        for (int i = 0; i < uintFile.Length; i++)
        {
            uintFile[i] = BitConverter.ToUInt32(file, i * 4);
        }

        var tasks = new List<Task>();

        for (int i = 0; i < _threadCount; i++)
        {
            tasks.Add(Decrypt(i * 2, uintFile));
        }

        Task.WhenAll(tasks).Wait();

        foreach (uint i in uintFile)
        {
            writer.Write(i);
        }

        reader.Dispose();
        writer.Dispose();
    }

    private Task Encrypt(int startingPos, uint[] file)
    {
        return Task.Run(() =>
        {
            for (int j = startingPos; j < file.Length - 1; j += _threadCount * 2) 
            {
                EncryptNext(file, j);
            }
        });
    }

    private Task Decrypt(int startingPos, uint[] file)
    {
        return Task.Run(() =>
        {
            for (int j = startingPos; j < file.Length - 1; j += _threadCount * 2)
            {
                DecryptNext(file, j);
            }
        });
    }
}
