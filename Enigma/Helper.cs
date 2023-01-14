using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_17714.EnigmaAlg;

internal static class Helper
{
    public static int Find(this char[] chars, char ch)
    {
        for (int i = 0; i <= chars.Length; i++)
        {
            if (chars[i] == ch)
            {
                return i;
            }
        }
        return -1;
    }

    public static int LetterToSignal(char ch)
    {
        return ch - 'A';
    }

    public static char SignalToLetter(int signal)
    {
        return (char)('A' + signal);
    }

    public static char[] GetAlphabet()
    {
        char[] alphabet = new char[26];

        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char)(i + 'A');
        }

        return alphabet;
    }
}
