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

    public async Task Encrypt(int startingPos, uint[] file)
    {
        await Task.Run(() =>
        {
            for (int j = startingPos; startingPos < file.Length; j += 2 * _threadCount) 
            {
                EncryptNext(file, startingPos);
            }
        });
    }

    public async Task Decrypt(int startingPos, uint[] file)
    {
        await Task.Run(() =>
        {
            for (int j = startingPos; startingPos < file.Length; j += 2 * _threadCount)
            {
                DecryptNext(file, startingPos);
            }
        });
    }

    public override async void EncryptFile(Stream fileInputStream, Stream fileOutputStream)
    {
        using FileReader reader = new(fileInputStream, 8, PadBytes.PadCount);
        using BinaryWriter writer = new(fileOutputStream);


        byte[] file = reader.ReadFile();
        uint[] uintFile = new uint[file.Length / 4];

        for (int i = 0; i < uintFile.Length; i++)
        {
            uintFile[i] = BitConverter.ToUInt32(file, i * 4);
        }

        Task[] tasks = new Task[_threadCount];

        for (int i = 0; i < _threadCount; i++)
        {
            tasks[i] = Encrypt(i, uintFile);
        }

        await Task.WhenAll(tasks);

        foreach (uint i in uintFile)
        {
            writer.Write(i);
        }
    }

    public override async void DecryptFile(Stream fileInputStream, Stream fileOutputStream)
    {
        using FileReader reader = new(fileInputStream, 8, PadBytes.PadCount);
        using BinaryWriter writer = new(fileOutputStream);


        byte[] file = reader.ReadFile();
        uint[] uintFile = new uint[file.Length / 4];

        for (int i = 0; i < uintFile.Length; i++)
        {
            uintFile[i] = BitConverter.ToUInt32(file, i * 4);
        }

        Task[] tasks = new Task[_threadCount];

        for (int i = 0; i < _threadCount; i++)
        {
            tasks[i] = Decrypt(i, uintFile);
        }

        await Task.WhenAll(tasks);

        foreach (uint i in uintFile)
        {
            writer.Write(i);
        }
    }
}
