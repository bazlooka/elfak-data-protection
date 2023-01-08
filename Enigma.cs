using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ZI_17714;

internal interface IEnigmaLayer
{
    int Forward(int signal);
    int Backward(int signal);
}

internal class Plugboard : IEnigmaLayer
{
    private char[] _left;
    private char[] _right;

    public Plugboard(string pairs) 
    {
        _left = new char[26];
        _right = new char[26];

        _left = ExtensionMethods.GetAlphabet();
        _right = ExtensionMethods.GetAlphabet();

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

internal class Rotor : IEnigmaLayer
{
    private string _left;
    private string _right;
    private char _notch;

    public string Left { get => _left; }
    public char Notch { get => _notch; }

    public Rotor(string wiring, char notch, char startingLetter, int ringSetting)
    {
        _left = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        _right = wiring;

        for (int i = 0; i < ringSetting; i++)
        {
            RotateBackwards();
        }

        int notchIndex = ExtensionMethods.LetterToSignal(notch);
        _notch = ExtensionMethods.SignalToLetter((notchIndex - ringSetting) % 26);
        
        RotateToLetter(startingLetter);
    }

    public int Forward(int signal)
    {
        char letter = _right[signal];
        return _left.IndexOf(letter);
    }

    public int Backward(int signal)
    {
        char letter = _left[signal];
        return _right.IndexOf(letter);
    }

    public void Rotate()
    {
        _left = _left[1..] + _left[0];
        _right = _right[1..] + _right[0];
    }

    public void RotateBackwards()
    {
        _left = _left[25] + _left[..25];
        _right = _right[25] + _right[..25];
    }

    private void RotateToLetter(char letter)
    {
        int index = _left.IndexOf(letter);
        for(int i = 0; i < index; i++)
        {
            Rotate();
        }
    }
}

internal class Reflector
{
    private string _left;
    private string _right;

    public Reflector(string wiring)
    {
        _left = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        _right = wiring;
    }

    public int Reflect(int signal)
    {
        char letter = _right[signal];
        return _left.IndexOf(letter);
    }
}

internal class Enigma
{
    private Plugboard _plugboard;
    private Rotor[] _rotors;
    private Reflector _reflector;

    public Enigma()
    {
        _plugboard = new Plugboard("AB CD EF");

        _rotors = new Rotor[3];
        _rotors[0] = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", 'Q', 'C', 0);
        _rotors[1] = new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", 'E', 'A', 0);
        _rotors[2] = new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", 'V', 'T', 0);
        _reflector = new Reflector("YRUHQSLDPXNGOKMIEBFZCWVJAT");
    }

    public string Encrypt(string input)
    {
        char[] output = new char[input.Length];
        int outputI = 0;

        foreach (char ch in input.ToUpper())
        {
            if (ch == ' ')
            {
                continue;
            }

            if ((_rotors[1].Left[0] == _rotors[1].Notch && _rotors[2].Left[0] == _rotors[2].Notch)
                || _rotors[1].Left[0] == _rotors[1].Notch)
            {
                _rotors[0].Rotate();
                _rotors[1].Rotate();
                _rotors[2].Rotate();
            }
            else if (_rotors[2].Left[0] == _rotors[2].Notch)
            {
                _rotors[1].Rotate();
                _rotors[2].Rotate();
            }    
            else
            {
                _rotors[2].Rotate();
            }

            int signal = ExtensionMethods.LetterToSignal(ch);

            signal = _plugboard.Forward(signal);
            signal = _rotors[2].Forward(signal);
            signal = _rotors[1].Forward(signal);
            signal = _rotors[0].Forward(signal);
            signal = _reflector.Reflect(signal);
            signal = _rotors[0].Backward(signal);
            signal = _rotors[1].Backward(signal);
            signal = _rotors[2].Backward(signal);
            signal = _plugboard.Backward(signal);

            output[outputI++] = ExtensionMethods.SignalToLetter(signal);
        }

        return new string(output, 0, outputI);
    }

    public string Decrypt(string input)
    {
        return Encrypt(input);
    }
}
public static class ExtensionMethods
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
        return (char) ('A' + signal);
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