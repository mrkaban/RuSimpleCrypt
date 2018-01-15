using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCrypt_X
{
    public partial class password : Form
    {



        public password()
        {
            InitializeComponent();
        }

        private void password_Load(object sender, EventArgs e)
        {

        }

        private string GenerateString(int length)
        {
            StringBuilder sb = new System.Text.StringBuilder();

            string[] chars =
            {
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", 
               "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "X", 
               "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "!", "@", "#", "$", "%", "*", "&", "-", "^", "~", "?", "/", "\\", "]", "[", "\"\" "
            };

            Random random = new Random();

            for (int x = 0; x < length; x++)
            {
                
                sb.Append(chars[random.Next(0, chars.Length - 1)]);
            }

            return sb.ToString();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TextBox2.Text = GenerateString(trackBar1.Value);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar1.Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }



 

        private void CalculateMeter(object sender, KeyEventArgs e)
        {
            string password = MaskedTextBox1.Text.ToString();
            int score = 0;
            string[] StrengthWords = { "Очень, очень слабый", "Очень слабый", "Слабый", "Лучше", "Средний", "Сильный", "Сильнейший" };
            // this is the calculated metro :D

            if (password.Length > 6) score += 1;
            if (System.Text.RegularExpressions.Regex.IsMatch(password, "[a-z]") && System.Text.RegularExpressions.Regex.IsMatch(password, "[A-Z]")) score += 1; // upper and lower case
            if (System.Text.RegularExpressions.Regex.IsMatch(password, "^[0-9]+")) score += 1; // contains a number
            if (System.Text.RegularExpressions.Regex.IsMatch(password, "[!,@,#,$,%,^,&,*,?,_,~,-,/, ]")) score += 1; // special character
            if (password.Length >= 10) score += 1; // length more than 9 
            if (password.Length > 15) score += 1; // length more than 15 
            //progressBar1.Value = score / 6 * 100; // finding percentage to increase 
            TextBox1.Text = StrengthWords[score]; // Getting strength word from string array declarred aboves
        }

        public void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(MaskedTextBox1.Text != "" && textBox3.Text != "")
            {
                if(MaskedTextBox1.Text == textBox3.Text)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают");
                }
            }
            else
            {
                MessageBox.Show("Убедитесь, что заполнили оба поля с паролем");
            }
        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
