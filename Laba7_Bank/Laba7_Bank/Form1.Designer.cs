﻿namespace Laba7_Bank
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.GenerateMatrixButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FindLastRowWithEvenNumbersButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(172, 95);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(172, 127);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 1;
            // 
            // GenerateMatrixButton
            // 
            this.GenerateMatrixButton.Location = new System.Drawing.Point(16, 155);
            this.GenerateMatrixButton.Name = "GenerateMatrixButton";
            this.GenerateMatrixButton.Size = new System.Drawing.Size(276, 23);
            this.GenerateMatrixButton.TabIndex = 2;
            this.GenerateMatrixButton.Text = "Создать матрицу";
            this.GenerateMatrixButton.UseVisualStyleBackColor = true;
            this.GenerateMatrixButton.Click += new System.EventHandler(this.GenerateMatrixButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(534, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(389, 305);
            this.dataGridView1.TabIndex = 3;
            // 
            // FindLastRowWithEvenNumbersButton
            // 
            this.FindLastRowWithEvenNumbersButton.Location = new System.Drawing.Point(16, 184);
            this.FindLastRowWithEvenNumbersButton.Name = "FindLastRowWithEvenNumbersButton";
            this.FindLastRowWithEvenNumbersButton.Size = new System.Drawing.Size(95, 28);
            this.FindLastRowWithEvenNumbersButton.TabIndex = 4;
            this.FindLastRowWithEvenNumbersButton.Text = "Найти";
            this.FindLastRowWithEvenNumbersButton.UseVisualStyleBackColor = true;
            this.FindLastRowWithEvenNumbersButton.Click += new System.EventHandler(this.FindLastRowWithEvenNumbersButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 64);
            this.label1.TabIndex = 5;
            this.label1.Text = "Малков Даниил 21ВИ1\r\nДана целочисленная матрица размера M × N. \r\nНайти номер посл" +
    "еднего из её строк, содержащих только четные числа.\r\nЕсли таких строк нет, то вы" +
    "вести 0.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "Количество строк:\r\n\r\nКоличество столбцов:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Найдена строка: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 305);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FindLastRowWithEvenNumbersButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GenerateMatrixButton);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Лабораторная 7. Jagget";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button GenerateMatrixButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button FindLastRowWithEvenNumbersButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

