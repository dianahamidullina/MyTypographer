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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            // 1.Нельзя писать подряд более одного пробела.

            text = Regex.Replace(text, @"\s{2,}", " ");
            richTextBox2.Text = text;

            


            //2.Для указания степени квадрата и куба нужно использовать:
            //² и ³ соответственно. Например: «x²» выведет в браузер «x²».
            if (richTextBox2.Text.Contains("x^2") || richTextBox1.Text.Contains("x^3"))
            {
                text = text.Replace("x^2", "x²");
                text = text.Replace("X^3", "x³");
                richTextBox2.Text = text;
            }
            
        

            // 3.Символ «плюс - минус» задаётся так: ± ненужно использовать 
            //конструкции типа «(+,−)».

            if (richTextBox1.Text.Contains("+-"))
            {
                text = text.Replace("+-", "± ");
                richTextBox2.Text = text;
            }

            //4.Везде где в тексте используется амперсанд «&», нужно вместо него писать &

            if (richTextBox1.Text.Contains("&"))
            {
                text = text.Replace("&", "&");
                richTextBox2.Text = text;
            }
            //Два своих правила :
            // 5.слова Здравствуйте будут заменяться на Приветули)
            if (richTextBox1.Text.Contains("здравствуйте") || richTextBox1.Text.Contains("Здравствуйте"))
            {
                text = text.Replace("здравствуйте", "приветули");
                text = text.Replace("Здравствуйте", "Приветули");
                richTextBox2.Text = text;
            }

            //6.Слово люблю заменяется на символ сердечко
            if(richTextBox1.Text.Contains("Люблю") || richTextBox1.Text.Contains("люблю"))
            {
                text = text.Replace("Люблю", "❤");
                text = text.Replace("люблю", "❤");
                richTextBox2.Text = text;
            }
           

            
        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
        }

       
    }
}
