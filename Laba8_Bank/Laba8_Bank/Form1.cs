using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Малков Даниил Дмитриевич 21ВИ1
Строки и числа
String18. Дана строка. Преобразовать в ней все строчные буквы
(как латинские, так и русские) в прописные, а прописные — в строчные.
*/

namespace Laba8_Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void TransformButton_Click(object sender, EventArgs e)
        {
            string input = Input_Box.Text;
            string transformed = TransformString(input);
            Output_Box.Text = transformed;
        }

        private string TransformString(string input)
        {
            StringBuilder result = new StringBuilder(input.Length);

            foreach (char c in input)
                if (char.IsUpper(c))
                    result.Append(char.ToLower(c));
                else if (char.IsLower(c))
                    result.Append(char.ToUpper(c));
                else result.Append(c);

            return result.ToString();
        }
    }
}
