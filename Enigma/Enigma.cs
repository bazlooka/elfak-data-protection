using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ZI_17714.EnigmaAlg;

internal class Enigma : ICryptoAlgorithm
{
    private readonly Plugboard _plugboard;
    private readonly Rotor[] _rotors;
    private readonly Reflector _reflector;

    public Enigma(string keySettings, string rotors, int reflector,
        string plugboard, string ringSettings)
    {
        _plugboard = new Plugboard(plugboard);

        if (rotors.Length != 3 || keySettings.Length != 3 || ringSettings.Length != 3)
        {
            throw new ArgumentException("Podržana su samo 3 rotora!");
        }    

        _rotors = new Rotor[3];

        _rotors[0] = new Rotor(rotors[0] - '0' - 1, keySettings[0], ringSettings[0] - 'A');
        _rotors[1] = new Rotor(rotors[1] - '0' - 1, keySettings[1], ringSettings[1] - 'A');
        _rotors[2] = new Rotor(rotors[2] - '0' - 1, keySettings[2], ringSettings[2] - 'A');

        _reflector = new Reflector(reflector);
    }

    public string Encrypt(string input)
    {
        char[] output = new char[input.Length];

        string uppercaseInput = input.ToUpper();

        for (int i = 0; i < uppercaseInput.Length; i++ )
        {
            char ch = uppercaseInput[i];

            if (ch == ' ')
            {
                output[i] = ch;
                continue;
            }

            RotateRotors();

            int signal = Helper.LetterToSignal(ch);

            signal = _plugboard.Forward(signal);
            signal = _rotors[2].Forward(signal);
            signal = _rotors[1].Forward(signal);
            signal = _rotors[0].Forward(signal);

            signal = _reflector.Reflect(signal);

            signal = _rotors[0].Backward(signal);
            signal = _rotors[1].Backward(signal);
            signal = _rotors[2].Backward(signal);

            signal = _plugboard.Backward(signal);

            output[i] = Helper.SignalToLetter(signal);
        }

        return new string(output);
    }

    private void RotateRotors()
    {        
        if ((_rotors[1].Left[0] == _rotors[1].Notch && _rotors[2].Left[0] == _rotors[2].Notch)
               || _rotors[1].Left[0] == _rotors[1].Notch)
        {
            _rotors[0].RotateForward();
            _rotors[1].RotateForward();
            _rotors[2].RotateForward();
        }
        else if (_rotors[2].Left[0] == _rotors[2].Notch)
        {
            _rotors[1].RotateForward();
            _rotors[2].RotateForward();
        }
        else
        {
            _rotors[2].RotateForward();
        }
    }

    public void EncryptFile(Stream fileInputStream, Stream fileOutputStream)
    {
        using StreamReader reader = new(fileInputStream);
        using StreamWriter writer = new(fileOutputStream);

        string? line = null;

        while ((line = reader.ReadLine()) != null) 
        {
            string encryptedLine = Encrypt(line);
            writer.WriteLine(encryptedLine);
        }
    }

    public void DecryptFile(Stream fileInputStream, Stream fileOutputStream)
    {
        EncryptFile(fileInputStream, fileOutputStream);
    }
}