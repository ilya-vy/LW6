using System;
using System.Windows.Forms;

namespace ООП_ЛР6_З1_Form
{
    public partial class Form1 : Form
    {
        public string FileName;
        public string Dir;
        AbstractHandler instance;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileName = textBox3.Text;
            Dir = textBox2.Text;

            if (FileName.EndsWith(".txt"))
                instance = new TXT(FileName, Dir);
            else if (FileName.EndsWith(".doc"))
                instance = new DOC(FileName, Dir);

            MessageBox.Show(instance.CreateFile());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileName = textBox3.Text;
            Dir = textBox2.Text;

            if (FileName.EndsWith(".txt"))
                instance = new TXT(FileName, Dir);
            else if (FileName.EndsWith(".doc"))
                instance = new DOC(FileName, Dir);

            textBox1.Text = instance.OpenFile();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileName = textBox3.Text;
            Dir = textBox2.Text;

            if (FileName.EndsWith(".txt"))
                instance = new TXT(FileName, Dir);
            else if (FileName.EndsWith(".doc"))
                instance = new DOC(FileName, Dir);

            MessageBox.Show(instance.EditFile(textBox1.Text));
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message m = Message.Create(Handle, 161, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
    }
}
