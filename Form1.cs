namespace ZI_17714;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            using var sr = new StreamReader("TestFile.txt");
            MessageBox.Show(sr.ReadToEnd());
        }
        catch (IOException ex)
        {
            MessageBox.Show("The file could not be read:");
            MessageBox.Show(ex.Message);
        }
    }
}