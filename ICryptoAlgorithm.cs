using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_17714;

public interface ICryptoAlgorithm
{
    byte[] Encrypt(byte[] input);
    byte[] Decrypt(byte[] input);
}
