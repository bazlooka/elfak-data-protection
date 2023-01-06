using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_17714;

internal class TEA
{
    private readonly uint _k0, _k1, _k2, _k3;
    private readonly uint _delta = 0x9E3779B9;

    public TEA(uint[] key)
    {
        if(key.Length != 4)
        {
            throw new ArgumentException("Key length must be 128 bits!");
        }
        _k0 = key[0];
        _k1 = key[1];
        _k2 = key[2];
        _k3 = key[3];
    }

    public void Encrypt(uint[] input)
    {
        for(int k = 0; k < input.Length; k += 2)
        {
            uint v0 = input[k], v1 = input[k+1];
            uint sum = 0;

            for (int i = 0; i < 32; i++)
            {
                sum += _delta;
                v0 += ((v1 << 4) + _k0) ^ (v1 + sum) ^ ((v1 >> 5) + _k1);
                v1 += ((v0 << 4) + _k2) ^ (v0 + sum) ^ ((v0 >> 5) + _k3);
            }
            input[k] = v0;
            input[k + 1] = v1;
        }
    }

    public void Decrypt(uint[] input)
    {
        for (int k = 0; k < input.Length; k += 2)
        {
            uint v0 = input[k], v1 = input[k + 1];
            uint sum = 0xC6EF3720;

            for (int i = 0; i < 32; i++)
            {
                v1 -= ((v0 << 4) + _k2) ^ (v0 + sum) ^ ((v0 >> 5) + _k3);
                v0 -= ((v1 << 4) + _k0) ^ (v1 + sum) ^ ((v1 >> 5) + _k1);
                sum -= _delta;
            }
            input[k] = v0;
            input[k + 1] = v1;
        }
    }
}
