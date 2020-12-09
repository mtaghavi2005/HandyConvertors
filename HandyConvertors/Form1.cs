using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandyConvertors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowHelp = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                var stream = File.ReadAllBytes(fileName);
                // convert the byte array to a hex string
                var hexString = BitConverter.ToString(stream).Replace("-", "");
                richTextBox1.Text = String.Format("0x{0}", hexString);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowHelp = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                var stream = File.ReadAllBytes(fileName);
                richTextBox1.Text = Convert.ToBase64String(stream);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //richTextBox1.Text = string.Empty;
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.ShowHelp = true;
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //var fileName = openFileDialog.FileName;
            //string fileContent = File.ReadAllText(fileName);
            richTextBox1.Text = Newtonsoft.Json.JsonConvert.SerializeObject(richTextBox1.Text);
        }
    }
}
