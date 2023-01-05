using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZI_17714;

internal class RC4 : ICryptoAlgorithm
{
    private readonly byte[] _key;
    private readonly byte[] _S;

    private uint i = 0, j = 0;

    public RC4(string key)
    {
        byte[] keyBytes = Encoding.UTF8.GetBytes(key);

        if (keyBytes.Length < 1 || keyBytes.Length > 256)
        {
            throw new ArgumentException("RC4 encryption key length is not valid!");
        }

        _key = keyBytes;
        _S = new byte[256];
        ScheduleKey();
    }

    public void ScheduleKey()
    {
        for (i = 0; i <= 255; i++)
        {
            _S[i] = (byte) i;
        }

        byte temp;
        j = 0;

        for (i = 0; i <= 255; i++)
        {
            j = (j + _key[i % _key.Length] + _S[i]) & 255;

            temp = _S[i];
            _S[i] = _S[j];
            _S[j] = temp;
        }
        i = j = 0;
    }

    public byte[] Encrypt(byte[] input)
    {
        byte[] output = new byte[input.Length];
        byte temp;

        for (int k = 0; k < input.Length; k++)
        {
            i = (i + 1) & 255;
            j = (j + _S[i]) & 255;

            temp = _S[i];
            _S[i] = _S[j];
            _S[j] = temp;

            output[k] = (byte)(_S[(_S[i] + _S[j]) & 255] ^ input[k]);
        }
        return output;
    }

    public byte[] Decrypt(byte[] input)
    {
        return Encrypt(input);
    }
}
