using System;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ZI_17714;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Button1_Click(object sender, EventArgs e)
    {
        string key = tbRC4Key.Text;
        RC4 rc4 = new(key);

        try
        {
            var fileInputStream = openFileDialog1.OpenFile();
            var fileOutputStream = saveFileDialog.OpenFile();

            using BinaryReader reader = new(fileInputStream);
            using BinaryWriter writer = new(fileOutputStream);

            byte[] buffer;

            while (reader.BaseStream.Position != reader.BaseStream.Length)
            {
                buffer = reader.ReadBytes(512);
                rc4.Encrypt(buffer);
                writer.Write(buffer);
            }

            MessageBox.Show("Enkripcija je uspešna!");
        }
        catch
        {
            MessageBox.Show("Došlo je do greške prilikom čitanja fajla.");
        }
    }

    private void button2_Click(object sender, EventArgs e)
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

    private void RC4_Click(object sender, EventArgs e)
    {
        
    }

    private void button3_Click(object sender, EventArgs e)
    {
        if (tabControl1.SelectedTab.Name == "CRC")
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

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button4_Click(object sender, EventArgs e)
    {

    }

    //BITMAP
    private void button5_Click(object sender, EventArgs e)
    {
        string key = tbRC4Key.Text;
        RC4 rc4 = new(key);

        try
        {
            var fileInputStream = openFileDialog1.OpenFile();
            var fileOutputStream = saveFileDialog.OpenFile();

            using Bitmap bitmap = new(fileInputStream);

            for(int j = 0; j < bitmap.Height; j++)
            {
                for (int i = 0; i < bitmap.Width; i++)
                {
                    int pixel = bitmap.GetPixel(i, j).ToArgb();
                    byte[] buffer = BitConverter.GetBytes(pixel);
                    rc4.Encrypt(buffer);
                    pixel = BitConverter.ToInt32(buffer);
                    bitmap.SetPixel(i, j, Color.FromArgb(pixel));
                }
            }

            bitmap.Save(fileOutputStream, System.Drawing.Imaging.ImageFormat.Bmp);
            fileInputStream.Close();
            fileOutputStream.Close();

            MessageBox.Show("Enkripcija je uspešna!");
        }
        catch
        {
            MessageBox.Show("Došlo je do greške prilikom čitanja fajla.");
        }
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
        char c = e.KeyChar;
        int textLength = textBox1.Text.Length;

        if(textLength >= 8 && c != '\b')
        {
            e.Handled = true;
        }
    }

    private void button7_Click(object sender, EventArgs e)
    {
        byte[] bytes = Encoding.Unicode.GetBytes(textBox1.Text);

        uint[] ints = new uint[4];

        for(int i = 0; i < 4; i++)
        {
            ints[i] = BitConverter.ToUInt32(bytes, i * 4);
        }

        TEA tea = new(ints);

        try
        {
            var fileInputStream = openFileDialog1.OpenFile();
            var fileOutputStream = saveFileDialog.OpenFile();

            using BinaryReader reader = new(fileInputStream);
            using BinaryWriter writer = new(fileOutputStream);




            //uint[] buffer = new uint[2];

            //MessageBox.Show("LEN: " + reader.BaseStream.Length);

            //byte[] buffer = reader.ReadBytes(8);
            //uint[] uintBuffer = new uint[2];

            //while (buffer.Length == 8 && reader.BaseStream.Position != reader.BaseStream.Length)
            //{
            //    uintBuffer[0] = BitConverter.ToUInt32(buffer, 0);
            //    uintBuffer[1] = BitConverter.ToUInt32(buffer, 4);

            //    tea.Encrypt(uintBuffer);

            //    writer.Write(uintBuffer[0]);
            //    writer.Write(uintBuffer[1]);

            //    buffer = reader.ReadBytes(4);
            //}

            //MessageBox.Show("LEN2 " + buffer.Length);

            //if(buffer.Length != 8)
            //{
            //    byte[] rest = new byte[8] { 0, 0, 0, 0, 0, 0, 0, 0 };

            //    for(int i = 0; i < buffer.Length; i++)
            //    {
            //        rest[i] = buffer[i];
            //    }

            //    uintBuffer[0] = BitConverter.ToUInt32(rest, 0);
            //    uintBuffer[1] = BitConverter.ToUInt32(rest, 4);

            //    tea.Encrypt(uintBuffer);

            //    writer.Write(uintBuffer[0]);
            //    writer.Write(uintBuffer[1]);
            //}

            MessageBox.Show("Enkripcija je uspešna!");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Došlo je do greške prilikom čitanja fajla.");
            MessageBox.Show(ex.Message);
        }
    }

    private void button8_Click(object sender, EventArgs e)
    {
        byte[] bytes = Encoding.Unicode.GetBytes(textBox1.Text);

        uint[] ints = new uint[4];

        for (int i = 0; i < 4; i++)
        {
            ints[i] = BitConverter.ToUInt32(bytes, i * 4);
        }

        TEA tea = new(ints);

        try
        {
            var fileInputStream = openFileDialog1.OpenFile();
            var fileOutputStream = saveFileDialog.OpenFile();

            using BinaryReader reader = new(fileInputStream);
            using BinaryWriter writer = new(fileOutputStream);

            uint[] buffer = new uint[2];

            while (reader.BaseStream.Position != reader.BaseStream.Length)
            {
                buffer[0] = reader.ReadUInt32();
                buffer[1] = reader.ReadUInt32();
                tea.Decrypt(buffer);
                writer.Write(buffer[0]);
                writer.Write(buffer[1]);
            }

            MessageBox.Show("Dekripcija je uspešna!");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Došlo je do greške prilikom čitanja fajla.");
            MessageBox.Show(ex.Message);
        }
    }

    private void button9_Click(object sender, EventArgs e)
    {
        Enigma en = new();
        string res = en.Encrypt("TESTINGTESTINGTESTINGTESTING");
        MessageBox.Show(res);
    }

    private void button11_Click(object sender, EventArgs e)
    {
        string polynom = textBox6.Text;
        uint intPolynom = uint.Parse(polynom, System.Globalization.NumberStyles.HexNumber);

        int polynomDegree;
        if (radioButton1.Checked)
        {
            polynomDegree = 8;
        }
        else
        {
            polynomDegree = 32;
        }

        CRC crc = new(intPolynom, polynomDegree);

        try
        {
            var file1Stream = openFileDialog1.OpenFile();
            var file2Stream = openFileDialog2.OpenFile();

            using BinaryReader reader1 = new(file1Stream);
            using BinaryReader reader2 = new(file2Stream);

            uint hash1, hash2;

            byte[] buffer;

            while (reader1.BaseStream.Position != reader1.BaseStream.Length)
            {
                buffer = reader1.ReadBytes(512);
                crc.HashNext(buffer);
            }
            
            hash1 = crc.Hash;
            crc.Restart();

            while (reader2.BaseStream.Position != reader2.BaseStream.Length)
            {
                buffer = reader2.ReadBytes(512);
                crc.HashNext(buffer);
            }

            hash2 = crc.Hash;

            label12.Text = hash1.ToString();
            label14.Text = hash2.ToString();

            if(hash1 == hash2)
            {
                label15.Text = "Datoteke su iste";
            }
            else
            {
                label15.Text = "Datoteke nisu iste";
            }

            MessageBox.Show("Uspešno računanje heša!");
        }
        catch
        {
            MessageBox.Show("Došlo je do greške prilikom čitanja fajla.");
        }
    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (tabControl1.SelectedTab.Name == "CRC")
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
}