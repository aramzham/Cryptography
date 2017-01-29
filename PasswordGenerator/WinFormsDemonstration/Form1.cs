using System;
using System.Windows.Forms;
using PasswordGenerator;

namespace UIPass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PasswordOptions passwordOption;

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            if (textBox2.Text == "" && (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked && !radioButton5.Checked)) textBox1.Text = new Password().ToString();
            else if (textBox2.Text == "") textBox1.Text = new Password(passwordOption).ToString();
            else if (!int.TryParse(textBox2.Text, out number)) MessageBox.Show(@"Please enter a valid number");
            else textBox1.Text = new Password(passwordOption, int.Parse(textBox2.Text)).ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Enabled) passwordOption = PasswordOptions.HasUpperCase;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Enabled) passwordOption = PasswordOptions.OnlyUpperCase;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Enabled) passwordOption = PasswordOptions.OnlyLowerCase;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Enabled) passwordOption = PasswordOptions.OnlyAlphabet;
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Enabled) passwordOption = PasswordOptions.AtLeastOneDigitOneSpecialCharacter;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty) return;
            Clipboard.SetText(textBox1.Text);
            MessageBox.Show(@"Password is copied successfully");
        }
    }
}
