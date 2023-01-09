using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_17714;

internal class CRC
{
    private readonly uint _polynom;
    private readonly int _polynomDegree;

    private uint _hash;
    public uint Hash { get => _hash; }

    public CRC(uint polynom, int polynomDegree)
    {
        uint polynomMask = 1;
        polynomMask <<= polynomDegree;

        _hash = 0;
        _polynomDegree = polynomDegree;
        _polynom = polynom | polynomMask;   //Dodavanje jedinice najveće težine
    }

    public void Restart()
    {
        _hash = 0;
    }

    public void HashNext(byte[] data)
    {
        const int dataLength = 8;

        foreach (byte b in data)
        {
            uint d = (uint)(b << _polynomDegree);

            uint poly = (uint)(_polynom << dataLength - 1);

            uint checkBit = (uint)(1 << (_polynomDegree + dataLength - 1));

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



    //public void HashNext(byte[] data)
    //{
    //    const int dataLength = 8;

    //    foreach (byte b in data)
    //    {
    //        ulong d = (uint) (b << _polynomDegree);

    //        ulong poly = (ulong)(_polynom << dataLength - 1);

    //        ulong checkBit = (ulong)(1 << (_polynomDegree + dataLength - 1));

    //        for (int i = 0; i < _polynomDegree; i++)
    //        {
    //            if((checkBit & d) != 0)
    //            {
    //                d ^= poly;
    //            }
    //            checkBit >>= 1;
    //            poly >>= 1;
    //        }

    //        _hash ^= d;
    //    }
    //}
}
