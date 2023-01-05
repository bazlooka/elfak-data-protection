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
        RC4 rc4 = new("Key");

        try
        {
            var fileInputStream = openFileDialog.OpenFile();
            var fileOutputStream = saveFileDialog.OpenFile();

            using BinaryReader reader = new(fileInputStream);
            using BinaryWriter writer = new(fileOutputStream);

            byte[] buffer, encryptedBuffer;

            while (reader.BaseStream.Position != reader.BaseStream.Length)
            {
                buffer = reader.ReadBytes(512);
                encryptedBuffer = rc4.Encrypt(buffer);
                writer.Write(encryptedBuffer);
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
}