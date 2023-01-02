using System.Text;

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
        //try
        //{
        //    using var sr = new StreamReader("TestFile.txt");
        //    MessageBox.Show(sr.ReadToEnd());
        //}
        //catch (IOException ex)
        //{
        //    MessageBox.Show("The file could not be read:");
        //    MessageBox.Show(ex.Message);
        //}

        RC4 rc4 = new("Key", Encoding.ASCII);

        byte[] bytes = OpenFile("TestFile.txt");

        byte[] output = rc4.Encrypt(bytes);

        SaveFile("TestOutput.txt", output);

        byte[] finalOutput = rc4.Decrypt(output);

        SaveFile("FinalOutput.txt", finalOutput);
    }
}