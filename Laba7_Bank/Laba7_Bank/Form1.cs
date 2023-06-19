using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
    Малков Даниил 21ВИ1
Дана целочисленная матрица размера M × N. 
Найти номер последнего из её строк, содержащих толькочетные числа.
Если таких строк нет, то вывести 0.
*/
namespace Laba7_Bank
{
    public partial class Form1 : Form
    {
        private List<List<int>> matrix;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void GenerateMatrixButton_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDown1.Value; // Количество строк матрицы
            int m = (int)numericUpDown2.Value; // Количество столбцов матрицы

            matrix = new List<List<int>>();

            Random random = new Random();

            for (int i = 0; i < n; i++){
                List<int> row = new List<int>();

                for (int j = 0; j < m; j++)
                {
                    row.Add(random.Next(-50, 50)); // Генерация случайных чисел для заполнения матрицы
                }

                matrix.Add(row);
            }

            DisplayMatrixInDataGridView(matrix);
        }

        private void DisplayMatrixInDataGridView(List<List<int>> matrix)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Добавляем столбцы в dataGridView1
            for (int j = 0; j < matrix[0].Count; j++)
            {
                dataGridView1.Columns.Add($"Column{j + 1}", $"Столбец {j + 1}");
            }

            // Добавляем строки и заполняем ячейки dataGridView1
            for (int i = 0; i < matrix.Count; i++)
            {
                dataGridView1.Rows.Add();

                for (int j = 0; j < matrix[i].Count; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i][j];
                }
            }

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Width = 40;
            }
        }

        private void FindLastRowWithEvenNumbersButton_Click(object sender, EventArgs e)
        {
            if (matrix == null)
            {
                MessageBox.Show("Сначала сгенерируйте матрицу.");
                return;
            }

            int lastRow = 0;
            int n = matrix.Count;

            for (int i = 0; i < n; i++)
            {
                if (matrix[i].All(x => x % 2 == 0))
                {
                    lastRow = i + 1;
                }
            }
            if (lastRow > 0 && lastRow <= dataGridView1.Rows.Count)
            {
                dataGridView1.Rows[lastRow - 1].DefaultCellStyle.BackColor = Color.Red;
            }


            label3.Text = "Найдена строка: " +lastRow;
        }
    }
}
