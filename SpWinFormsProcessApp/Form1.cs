using System.Diagnostics;

namespace SpWinFormsProcessApp
{
    public partial class Form1 : Form
    {
        public Process process;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            process = Process.Start("notepad.exe", "X:\\RPO\\maxim efimov\\index.html");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            process.Kill();
        }
    }
}