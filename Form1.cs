using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Basic_Encryptor
{
    public partial class Form1 : Form
    {
        public object openFileDialog1 { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Browser Button
        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = null;
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "text files (*.txt)|*.txt";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = false;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog1.FileName;
                    textBox1.Text = openFileDialog1.FileName;
                    
                }

            }
            
        }
                
        //Save Button
        private void button2_Click_1(object sender, EventArgs e)
        {

            SaveFileDialog encryptedFile = new SaveFileDialog();

            encryptedFile.FileName = "*.text";
            encryptedFile.RestoreDirectory = true;

            if(encryptedFile.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = encryptedFile.OpenFile();
                StreamWriter sw = new StreamWriter(fileStream);
            }
           
        }


        //Encryption Button
        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
