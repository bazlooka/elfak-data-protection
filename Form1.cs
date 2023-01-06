using System;
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

    private byte[] OpenFile(string path)
    {
        return File.ReadAllBytes(path);
    }

    private void SaveFile(string path, byte[] bytes)
    {
        File.WriteAllBytes(path, bytes);
    }

    private void Button1_Click(object sender, EventArgs e)
    {
        string key = tbRC4Key.Text;
        RC4 rc4 = new(key);

        try
        {
            var fileInputStream = openFileDialog.OpenFile();
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
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filePath = openFileDialog.FileName;
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
        if(saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            var filePath = saveFileDialog.FileName;
            label2.Text = filePath;
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
            var fileInputStream = openFileDialog.OpenFile();
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
            var fileInputStream = openFileDialog.OpenFile();
            var fileOutputStream = saveFileDialog.OpenFile();

            using BinaryReader reader = new(fileInputStream);
            using BinaryWriter writer = new(fileOutputStream);

            uint[] buffer = new uint[2];

            while (reader.BaseStream.Position != reader.BaseStream.Length)
            {
                buffer[0] = reader.ReadUInt32();
                buffer[1] = reader.ReadUInt32();
                tea.Encrypt(buffer);
                writer.Write(buffer[0]);
                writer.Write(buffer[1]);
            }

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
            var fileInputStream = openFileDialog.OpenFile();
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
}