using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_17714.EnigmaAlg;

internal class Plugboard : IEnigmaLayer
{
    private readonly char[] _left;
    private readonly char[] _right;

    public Plugboard(string? pairs)
    {
        _left = new char[26];
        _right = new char[26];

        _left = Helper.GetAlphabet();
        _right = Helper.GetAlphabet();

        if(!string.IsNullOrEmpty(pairs))
        {
            foreach (string pair in pairs.Split(' '))
            {
                char A = pair[0];
                char B = pair[1];
                int posA = _left.Find(A);
                int posB = _right.Find(B);
                _left[posA] = B;
                _left[posB] = A;
            }
        }
    }

    public int Forward(int signal)
    {
        char letter = _right[signal];
        return _left.Find(letter);
    }

    public int Backward(int signal)
    {
        char letter = _left[signal];
        return _right.Find(letter);
    }
}
