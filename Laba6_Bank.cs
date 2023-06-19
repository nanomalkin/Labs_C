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
Малков Даниил 21ВИ1
Массив array 
Найти минимальный из локальных максимумов
*/

namespace Laba6_Bank
{
    public partial class Form1 : Form
    {
        private Random random;
        public int[] arrX;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSize.Text, out int N))
            {
                int[] arrX = new int[N];

                for (int i = 0; i < N; i++)
                {
                    arrX[i] = random.Next(-50, 50); 
                }

                int min = ArraySearchMinLocalMax(arrX);

                lblResult.Text = "Минимальный локальный максимум: " + min;
                DisplayArrayInDataGridView(arrX);

            }
            else
            {
                MessageBox.Show("Ошибка ввода размера массива!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ArraySearchMinLocalMax(int[] arr)
        {
            int min = int.MaxValue;

            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    if (arr[i] < min)
                        min = arr[i];
                }
            }
            return min;
        }
        private void DisplayArrayInDataGridView(int[] arr)
        {
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Column", "Значение");

            dataGridView1.RowCount = arr.Length;
            int min = ArraySearchMinLocalMax(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = arr[i];
                if (arr[i] == min)
                {
                    dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Yellow; // Измените цвет выделения по своему усмотрению
                }
            }
        }

    }
}
