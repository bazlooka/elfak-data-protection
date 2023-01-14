using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_17714.EnigmaAlg;

internal interface IEnigmaLayer
{
    int Forward(int signal);
    int Backward(int signal);
}