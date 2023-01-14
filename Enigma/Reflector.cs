using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_17714.EnigmaAlg;

internal class Reflector
{
    private static readonly string[] REFLECTORS = { "EJMZALYXVBWFCRQUONTSPIKHGD", 
        "YRUHQSLDPXNGOKMIEBFZCWVJAT", "FVPJIAOYEDRZXWGCTKUQSBNMHL" };

    private readonly string _left;
    private readonly string _right;

    public Reflector(int reflector)
    {
        _left = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        _right = REFLECTORS[reflector];
    }

    public int Reflect(int signal)
    {
        char letter = _right[signal];
        return _left.IndexOf(letter);
    }
}
