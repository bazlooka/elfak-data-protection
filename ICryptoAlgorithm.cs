using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_17714;

public interface ICryptoAlgorithm<T>
{
    T Encrypt(T input);
    T Decrypt(T input);
}
