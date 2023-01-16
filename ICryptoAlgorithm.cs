using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_17714;

public interface ICryptoAlgorithm
{
    void EncryptFile(Stream fileInputStream, Stream fileOutputStream);
    void DecryptFile(Stream fileInputStream, Stream fileOutputStream);
}
