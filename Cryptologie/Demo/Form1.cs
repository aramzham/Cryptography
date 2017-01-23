using System;
using System.Text;
using System.Windows.Forms;
using Cryptography;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private byte[] key;
        private byte[] iv;
        private byte[] encrypted;
        private DesEncryption des;

        private void button1_Click(object sender, EventArgs e)
        {
            des = new DesEncryption();
            key = DesEncryption.GenerateRandomNumber(8);
            iv = DesEncryption.GenerateRandomNumber(8);
            if (textBox1.Text == string.Empty) MessageBox.Show(@"Enter some text");
            else
            {
                var original = textBox1.Text;
                encrypted = des.Encrypt(Encoding.UTF8.GetBytes(original), key, iv);
                textBox2.Text = Convert.ToBase64String(encrypted);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (des == null) MessageBox.Show(@"Nothing to decrypt");
            else
            {
                var decrypted = des?.Decrypt(encrypted, key, iv);
                var decryptedMessage = Encoding.UTF8.GetString(decrypted);
                textBox3.Text = decryptedMessage;
            }
        }
    }
}
