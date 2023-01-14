using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_17714
{
    internal enum PadBytes
    {
        Zeroes,
        PadCount
    }

    internal class FileReader : IDisposable
    {
        private readonly BinaryReader _reader;

        private readonly int _dataSize;
        private readonly PadBytes _padBytes;

        public FileReader(Stream fileStream, int dataSize, PadBytes padBytes)
        {
            _dataSize = dataSize;
            _padBytes = padBytes;
            _reader = new BinaryReader(fileStream);
        }

        public byte[] ReadNextBlock(int blockSize)
        {
            byte[] bytes = _reader.ReadBytes(blockSize);

            if (bytes.Length % _dataSize == 0)
            {
                return bytes;
            }

            int padCount = _dataSize - (bytes.Length % _dataSize);

            byte[] result = AddPadBytes(bytes, padCount, _padBytes);

            return result;
        }

        public byte[] ReadFile()
        {
            const int blockSize = 512;

            byte[] file = new byte[_reader.BaseStream.Length];

            int pos = 0;

            while(HasMoraData())
            {
                byte[] buffer = _reader.ReadBytes(blockSize);
                buffer.CopyTo(file, pos);
                pos += buffer.Length;
            }

            if (file.Length % _dataSize == 0)
            {
                return file;
            }

            int padCount = _dataSize - (file.Length % _dataSize);

            byte[] paddedFile = AddPadBytes(file, padCount, _padBytes);

            return paddedFile;
        }

        public bool HasMoraData()
        {
            return _reader.BaseStream.Position != _reader.BaseStream.Length;
        }

        public static byte[] AddPadBytes(byte[] input, int padCount, PadBytes padBytes) 
        {
            byte[] result = new byte[input.Length + padCount];

            Array.Copy(input, result, input.Length);

            for (int j = 0; j < padCount; j++)
            {
                result[result.Length - j - 1] = (padBytes == PadBytes.Zeroes) ? (byte)0 : (byte)padCount;
            }

            return result;
        }

        public static int GetPadCount(byte[] input, int maxPad, PadBytes padBytes)
        {
            int result;

            if(padBytes == PadBytes.Zeroes)
            {
                int zeroCount = 0;
                int i = input.Length - 1;

                while (input[i] == 0)
                {
                    zeroCount++;
                }

                result = zeroCount;
            }
            else
            {
                int endByteCount = 0;
                int i = input.Length - 1;
                byte endByte = input[i];

                while (input[i] == endByte)
                {
                    endByteCount++;
                    i--;
                }

                if(endByte < maxPad && endByteCount == endByte)
                {
                    result = endByteCount;
                }
                else
                {
                    result = 0;
                }
            }
            return result;
        }

        public void Dispose()
        {
            _reader.Dispose();
        }
    }
}
