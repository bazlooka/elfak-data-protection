using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_17714;

internal class CRC
{
    private readonly int _polynom;
    private readonly int _polynomDegree;

    public CRC(int polynom)
    {
        _polynom = polynom;

        int polynomDegre = 0;
        while ((_polynom >> polynomDegre) > 0)
        {
            polynomDegre++;
        }    
        _polynomDegree = polynomDegre - 1;
    }

    public uint Hash(byte[] data)
    {
        const int dataLength = sizeof(byte) * 8;

        uint hash = 0;

        foreach (byte b in data)
        {
            uint d = (uint) (b << _polynomDegree);

            uint poly = (uint)(_polynom << dataLength - 1);

            uint checkBit = (uint)(1 << (_polynomDegree + dataLength - 1));

            for (int i = 0; i < _polynomDegree; i++)
            {
                if((checkBit & d) != 0)
                {
                    d ^= poly;
                }
                checkBit >>= 1;
                poly >>= 1;
            }

            hash ^= d;
        }

        return hash;
    }
}
