using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZI_17714.CRCAlg;

internal class CRC
{
    private readonly ulong _polynom;
    private readonly int _polynomDegree;

    private ulong _hash;

    public CRC(ulong polynom, int polynomDegree)
    {
        ulong polynomMask = 1;
        polynomMask <<= polynomDegree;

        _hash = 0;
        _polynomDegree = polynomDegree;
        _polynom = polynom | polynomMask;   //Dodavanje jedinice najveće težine
    }

    public void Restart()
    {
        _hash = 0;
    }

    public ulong CalculateFileHash(Stream fileStream)
    {
        Restart();

        using FileReader reader = new(fileStream, _polynomDegree / 8, PadBytes.Zeroes);

        while (reader.HasMoraData())
        {
            byte[] data = reader.ReadNextBlock(512);
            ulong[] convertedData;

            if (_polynomDegree == 8)
            {
                convertedData = data.Select(item => (ulong)item).ToArray();
            }
            else if (_polynomDegree == 16)
            {
                ushort[] ushortData = new ushort[data.Length / 2];

                for (int i = 0; i < ushortData.Length; i++)
                {
                    ushortData[i] = BitConverter.ToUInt16(data, i * 2);
                }
                convertedData = ushortData.Select(item => (ulong)item).ToArray();
            }
            else
            {
                uint[] uintData = new uint[data.Length / 4];

                for (int i = 0; i < uintData.Length; i++)
                {
                    uintData[i] = BitConverter.ToUInt32(data, i * 4);
                }

                convertedData = uintData.Select(item => (ulong)item).ToArray();
            }

            HashNext(convertedData);
        }
        return _hash;
    }

    private void HashNext(ulong[] data)
    {
        int dataLength = _polynomDegree;

        ulong d, poly, checkBit;

        foreach (ulong b in data)
        {
            d = b << _polynomDegree;

            poly = _polynom << dataLength - 1;

            checkBit = (ulong)1 << _polynomDegree + dataLength - 1;

            for (int i = 0; i < _polynomDegree; i++)
            {
                if ((checkBit & d) != 0)
                {
                    d ^= poly;
                }
                checkBit >>= 1;
                poly >>= 1;
            }

            _hash ^= d;
        }
    }
}
