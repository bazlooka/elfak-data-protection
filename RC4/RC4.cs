using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZI_17714.RC4Alg;

internal class RC4 : ICryptoAlgorithm, IBitmapCryptoAlgorithm
{
    private readonly byte[] _key;
    private readonly byte[] _S;

    private uint i = 0, j = 0;

    public RC4(string key)
    {
        byte[] keyBytes = Encoding.Unicode.GetBytes(key);

        if (keyBytes.Length < 1 || keyBytes.Length > 256)
        {
            throw new ArgumentException("RC4 encryption key length is not valid!");
        }

        _key = keyBytes;
        _S = new byte[256];
    }

    private void ScheduleKey()
    {
        for (i = 0; i <= 255; i++)
        {
            _S[i] = (byte)i;
        }

        byte temp;
        j = 0;

        for (i = 0; i <= 255; i++)
        {
            j = j + _key[i % _key.Length] + _S[i] & 255;

            temp = _S[i];
            _S[i] = _S[j];
            _S[j] = temp;
        }
        i = j = 0;
    }

    private void Encrypt(byte[] input)
    {
        byte temp;

        for (int k = 0; k < input.Length; k++)
        {
            i = i + 1 & 255;
            j = j + _S[i] & 255;

            temp = _S[i];
            _S[i] = _S[j];
            _S[j] = temp;

            input[k] = (byte)(_S[_S[i] + _S[j] & 255] ^ input[k]);
        }
    }
    public void EncryptFile(Stream fileInputStream, Stream fileOutputStream)
    {
        ScheduleKey();

        using FileReader fileReader = new(fileInputStream, 1, PadBytes.Zeroes);
        using BinaryWriter fileWriter = new(fileOutputStream);

        byte[] buffer;

        while (fileReader.HasMoraData())
        {
            buffer = fileReader.ReadNextBlock(512);
            Encrypt(buffer);
            fileWriter.Write(buffer);
        }
    }

    public void DecryptFile(Stream fileInputStream, Stream fileOutputStream)
    {
        EncryptFile(fileInputStream, fileOutputStream);
    }

    public void EncryptBitmap(Stream fileInputStream, Stream fileOutputStream)
    {
        ScheduleKey();

        using Bitmap bitmap = new(fileInputStream);

        byte[] buffer;

        for (int j = 0; j < bitmap.Height; j++)
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                int pixel = bitmap.GetPixel(i, j).ToArgb();
                buffer = BitConverter.GetBytes(pixel);
                Encrypt(buffer);
                pixel = BitConverter.ToInt32(buffer);
                bitmap.SetPixel(i, j, Color.FromArgb(pixel));
            }
        }

        bitmap.Save(fileOutputStream, System.Drawing.Imaging.ImageFormat.Bmp);
        fileInputStream.Close();
        fileOutputStream.Close();
    }

    public void DecryptBitmap(Stream fileInputStream, Stream fileOutputStream)
    {
        EncryptBitmap(fileInputStream, fileOutputStream);
    }
}
