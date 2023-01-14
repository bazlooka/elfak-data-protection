using System;
using System.IO;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

using ZI_17714.EnigmaAlg;
using ZI_17714.TEAAlg;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZI_17714;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void BtnFile1_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            string filePath = openFileDialog1.FileName;
            string fileExtension = Path.GetExtension(filePath);

            label1.Text = filePath;

            saveFileDialog.Filter = $"Isti kao ulazni ({fileExtension})|*{fileExtension}|All files (*.*)|*.*";
            saveFileDialog.DefaultExt = fileExtension;
        }
    }

    private void BtnFile2_Click(object sender, EventArgs e)
    {
        if (tcAlgorithm.SelectedTab.Name == "CRC")
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog2.FileName;
                label2.Text = filePath;
            }
        }
        else
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = saveFileDialog.FileName;
                label2.Text = filePath;
            }
        }
    }

    #region RC4

    private void BtnRc4Encrypt_Click(object sender, EventArgs e)
    {
        try
        {
            string key = tbRC4Key.Text;
            RC4 rc4 = new(key);

            var fileInputStream = openFileDialog1.OpenFile();
            var fileOutputStream = saveFileDialog.OpenFile();

            rc4.EncryptFile(fileInputStream, fileOutputStream);

            MessageBox.Show("Enkripcija je uspešna!");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Došlo je do greške prilikom enkripcije: " + ex.Message);
        }
    }

    private void BtnRc4Decrypt_Click(object sender, EventArgs e)
    {
        try
        {
            string key = tbRC4Key.Text;
            RC4 rc4 = new(key);

            var fileInputStream = openFileDialog1.OpenFile();
            var fileOutputStream = saveFileDialog.OpenFile();

            rc4.DecryptFile(fileInputStream, fileOutputStream);

            MessageBox.Show("Dekripcija je uspešna!");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Došlo je do greške prilikom dekripcije: " + ex.Message);
        }
    }

    private void BtnRc4EncryptBmp_Click(object sender, EventArgs e)
    {
        try
        {
            string key = tbRC4Key.Text;
            RC4 rc4 = new(key);

            var fileInputStream = openFileDialog1.OpenFile();
            var fileOutputStream = saveFileDialog.OpenFile();

            rc4.EncryptBitmap(fileInputStream, fileOutputStream);

            MessageBox.Show("Enkripcija bitmape je uspešna!");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Došlo je do greške prilikom enkripcije bitmape: " + ex.Message);
        }
    }

    private void BtnRc4DecryptBmp_Click(object sender, EventArgs e)
    {
        try
        {
            string key = tbRC4Key.Text;
            RC4 rc4 = new(key);

            var fileInputStream = openFileDialog1.OpenFile();
            var fileOutputStream = saveFileDialog.OpenFile();

            rc4.DecryptBitmap(fileInputStream, fileOutputStream);

            MessageBox.Show("Dekripcija bitmape je uspešna!");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Došlo je do greške prilikom dekripcije bitmape: " + ex.Message);
        }
    }

    #endregion RC4

    #region Enigma

    private void BtnEnigmaEncrypt_click(object sender, EventArgs e)
    {
        try
        {
            string keySettings = tbEnigmaKeySettings.Text;
            string rotors = tbEnigmaRotors.Text;
            int reflector = cbEnigmaReflector.SelectedIndex;
            string plugboard = tbEnigmaPlugboard.Text;
            string ringSettings = tbEnigmaRingSettings.Text;

            Enigma eningma = new(keySettings, rotors, reflector, plugboard, ringSettings);

            var fileInputStream = openFileDialog1.OpenFile();
            var fileOutputStream = saveFileDialog.OpenFile();

            eningma.EncryptFile(fileInputStream, fileOutputStream);

            MessageBox.Show("Enkripcija je uspešna!");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Došlo je do greške prilikom enkripcije: " + ex.Message);
        }
    }

    private void BtnEnigmaDecrypt_click(object sender, EventArgs e)
    {
        try
        {
            string keySettings = tbEnigmaKeySettings.Text;
            string rotors = tbEnigmaRotors.Text;
            int reflector = cbEnigmaReflector.SelectedIndex;
            string plugboard = tbEnigmaPlugboard.Text;
            string ringSettings = tbEnigmaRingSettings.Text;

            Enigma eningma = new(keySettings, rotors, reflector, plugboard, ringSettings);

            var fileInputStream = openFileDialog1.OpenFile();
            var fileOutputStream = saveFileDialog.OpenFile();

            eningma.DecryptFile(fileInputStream, fileOutputStream);

            MessageBox.Show("Dekripcija je uspešna!");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Došlo je do greške prilikom dekripcije: " + ex.Message);
        }
    }

    #endregion Enigma
    #region TEA

    private void TbTEAKey_KeyPress(object sender, KeyPressEventArgs e)
    {
        char c = e.KeyChar;
        int textLength = tbTEAKey.Text.Length;

        if (textLength >= 8 && c != '\b')
        {
            e.Handled = true;
        }
    }

    private void BtnTEAEncrypt_Click(object sender, EventArgs e)
    {
        try
        {
            byte[] keyBytes = Encoding.Unicode.GetBytes(tbTEAKey.Text);

            uint[] keyInts = new uint[4];

            for (int i = 0; i < 4; i++)
            {
                keyInts[i] = BitConverter.ToUInt32(keyBytes, i * 4);
            }

            TEA tea;

            if (rbTEAStandard.Checked) 
            {
                tea = new TEA(keyInts);
            }
            else if (rbTEAwithCBC.Checked)
            {
                string hexIV = tbIV.Text[2..];

                uint iv1 = uint.Parse(hexIV[0..4], System.Globalization.NumberStyles.HexNumber);
                uint iv2 = uint.Parse(hexIV[4..8], System.Globalization.NumberStyles.HexNumber);

                uint[] iv = new uint[] { iv1, iv2 };
                tea = new CBC(keyInts, iv);
            }
            else
            {
                int threadCount = (int) nudTEAThreadCount.Value;

                tea = new MultithreadedTEA(keyInts, threadCount);
            }

            var fileInputStream = openFileDialog1.OpenFile();
            var fileOutputStream = saveFileDialog.OpenFile();

            tea.EncryptFile(fileInputStream, fileOutputStream);

            MessageBox.Show("Enkripcija je uspešna!");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Došlo je do greške prilikom enkripcije: " + ex.Message);
        }
    }

    private void BtnTEADecrypt_Click(object sender, EventArgs e)
    {
        try
        {
            byte[] keyBytes = Encoding.Unicode.GetBytes(tbTEAKey.Text);

            uint[] keyInts = new uint[4];

            for (int i = 0; i < 4; i++)
            {
                keyInts[i] = BitConverter.ToUInt32(keyBytes, i * 4);
            }

            uint[] iv = new uint[] { 5, 5 };

            CBC tea = new(keyInts, iv);

            var fileInputStream = openFileDialog1.OpenFile();
            var fileOutputStream = saveFileDialog.OpenFile();

            tea.DecryptFile(fileInputStream, fileOutputStream);

            MessageBox.Show("Dekripcija je uspešna!");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Došlo je do greške prilikom dekripcije: " + ex.Message);
        }
    }

    #endregion TEA
    #region CBC

    #endregion CBC
    #region CRC

    private void BtnCRC_Click(object sender, EventArgs e)
    {
        string polynom = textBox6.Text[2..];
        ulong intPolynom = ulong.Parse(polynom, System.Globalization.NumberStyles.HexNumber);

        int polynomDegree;

        if (radioButton1.Checked)
        {
            polynomDegree = 8;
        }
        else if(radioButton3.Checked)
        {
            polynomDegree = 16;
        }
        else
        {
            polynomDegree = 32;
        }

        try
        {
            CRC crc = new(intPolynom, polynomDegree);

            var fileStream1 = openFileDialog1.OpenFile();
            ulong hash1 = crc.CalculateFileHash(fileStream1);
           
            var fileStream2 = openFileDialog2.OpenFile();
            ulong hash2 = crc.CalculateFileHash(fileStream2);

            label12.Text = string.Format("0x{0:X}", hash1);
            label14.Text = string.Format("0x{0:X}", hash2);

            if (hash1 == hash2)
            {
                label15.Text = "Datoteke su iste";
            }
            else
            {
                label15.Text = "Datoteke nisu iste";
            }

            MessageBox.Show("Uspešno računanje heša!");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Došlo je do greške prilikom računanja heša: " + ex.Message);
        }
    }

    #endregion CRC

    private void TcAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (tcAlgorithm.SelectedTab.Name == "CRC")
        {
            groupBox1.Text = "Datoteka 1";
            groupBox2.Text = "Datoteka 2";
        }
        else
        {
            groupBox1.Text = "Ulazna datoteka";
            groupBox2.Text = "Izlazna datoteka";
        }
    }

    private void RbTEAMultithreaded_CheckedChanged(object sender, EventArgs e)
    {
        gbMultithread.Enabled = rbTEAMultithreaded.Checked;
    }

    private void RbTEAwithCBC_CheckedChanged(object sender, EventArgs e)
    {
        gbCBC.Enabled = rbTEAwithCBC.Checked;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        cbEnigmaReflector.SelectedIndex = 0;
    }
}