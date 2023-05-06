using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTypographer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            var text = richTextBox1.Text;

            // Нельзя писать подряд более одного пробела.

            text = Regex.Replace(text, @"\s{2,}", " ");


            // «"». В русском языке этик кавычек нет.
            // Вместо них нужно использовать кавычки «ёлочки».
            //Создаются они так: «Ёлочки»
            
            if (richTextBox1.Text.Contains('"'))
            {
                text = text.Replace('"', '«');
                text = text.Replace('"', '»');
               
            }
            else
            {
                return;
            }
            richTextBox2.Text = text;
            // Символ «плюс - минус» задаётся так: ± ненужно использовать 
            //конструкции типа «(+,−)».

            if (richTextBox1.Text.Contains("+-"))
            {
                text = text.Replace("+-", "± ");
            }
            else
            {
                return;
            }
            
            richTextBox2.Text = text;
           
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
