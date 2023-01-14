using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_17714;

internal interface IBitmapCryptoAlgorithm
{
    public void EncryptBitmap(Stream fileInputStream, Stream fileOutputStream);
    public void DecryptBitmap(Stream fileInputStream, Stream fileOutputStream);
}
