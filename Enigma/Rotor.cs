using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_17714.EnigmaAlg;

internal class Rotor : IEnigmaLayer
{
    private static readonly string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    private static readonly string[] ROTORS = { "EKMFLGDQVZNTOWYHXUSPAIBRCJ",
        "AJDKSIRUXBLHWTMCQGZNPYFVOE", "BDFHJLCPRTXVZNYEIWGAKMUSQO",
        "ESOVPZJAYQUIRHXLNFTGKDCMWB",  "VZBRGITYUPSDNHLXAWMJQOFECK" };

    private static readonly char[] NOTCHES = { 'Q', 'E', 'V', 'J', 'Z' };

    private string _left;
    private string _right;
    private char _notch;

    public string Left { get => _left; }
    public char Notch { get => _notch; }

    public Rotor(int rotor, char startingLetter, int ringSetting)
    {
        _left = alphabet;
        _right = ROTORS[rotor];

        if(!_left.Contains(startingLetter) || ringSetting < 0 || ringSetting > 'Z' - 'A')
        {
            throw new ArgumentException("Plugboard podešavanja nisu validna!");
        }

        int notchIndex = _left.IndexOf(NOTCHES[rotor]);

        for (int i = 1; i <= ringSetting; i++)
        {
            RotateBackwards();
        }

        _notch = alphabet[Mod(notchIndex - ringSetting, 26)];

        RotateToLetter(startingLetter);
    }

    private int Mod(int x, int mod)
    {
        int remainder = x % mod;
        return remainder < 0 ? remainder + mod : remainder;
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

    public void RotateForward()
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
        int index = alphabet.IndexOf(letter);
        for (int i = 0; i < index; i++)
        {
            RotateForward();
        }
    }
}
