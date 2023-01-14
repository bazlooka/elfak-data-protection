using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_17714.TEAAlg;

internal class CBC : TEA
{
    private readonly uint[] _iv;
    private readonly uint[] _lastOutput;

    public CBC(uint[] key, uint[] iv) : base(key)
    {
        _iv = new uint[2];
        _iv[0] = iv[0];
        _iv[1] = iv[1];
        _lastOutput = new uint[2];
    }

    protected override void EncryptNext(uint[] buffer, int startPos)
    {
        buffer[startPos] ^= _lastOutput[0];
        buffer[startPos + 1] ^= _lastOutput[1];

        base.EncryptNext(buffer, startPos);

        _lastOutput[0] = buffer[startPos];
        _lastOutput[1] = buffer[startPos + 1];
    }

    protected override void DecryptNext(uint[] buffer, int startPos)
    {
        uint lastOutput0, lastOutput1;

        lastOutput0 = buffer[startPos];
        lastOutput1 = buffer[startPos + 1];

        base.DecryptNext(buffer, startPos);

        buffer[startPos] ^= _lastOutput[0];
        buffer[startPos + 1] ^= _lastOutput[1];

        _lastOutput[0] = lastOutput0;
        _lastOutput[1] = lastOutput1;
    }

    public override void EncryptFile(Stream fileInputStream, Stream fileOutputStream)
    {
        _lastOutput[0] = _iv[0];
        _lastOutput[1] = _iv[1];
        base.EncryptFile(fileInputStream, fileOutputStream);
    }

    public override void DecryptFile(Stream fileInputStream, Stream fileOutputStream)
    {
        _lastOutput[0] = _iv[0];
        _lastOutput[1] = _iv[1];
        base.DecryptFile(fileInputStream, fileOutputStream);
    }
}
