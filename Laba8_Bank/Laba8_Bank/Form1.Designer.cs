namespace Laba8_Bank
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
            this.Input_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Output_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TransformButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input_Box
            // 
            this.Input_Box.Location = new System.Drawing.Point(12, 108);
            this.Input_Box.Name = "Input_Box";
            this.Input_Box.Size = new System.Drawing.Size(252, 22);
            this.Input_Box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 96);
            this.label1.TabIndex = 1;
            this.label1.Text = "Малков Даниил Дмитриевич 21ВИ1\r\nСтроки и числа\r\nString18. Дана строка. Преобразов" +
    "ать в ней все строчные буквы\r\n(как латинские, так и русские) в прописные, а проп" +
    "исные — в строчные.\r\n\r\nВведите строку:";
            // 
            // Output_Box
            // 
            this.Output_Box.Location = new System.Drawing.Point(12, 182);
            this.Output_Box.Name = "Output_Box";
            this.Output_Box.Size = new System.Drawing.Size(252, 22);
            this.Output_Box.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Результат:";
            // 
            // TransformButton
            // 
            this.TransformButton.Location = new System.Drawing.Point(12, 224);
            this.TransformButton.Name = "TransformButton";
            this.TransformButton.Size = new System.Drawing.Size(252, 23);
            this.TransformButton.TabIndex = 4;
            this.TransformButton.Text = "Преобразовать";
            this.TransformButton.UseVisualStyleBackColor = true;
            this.TransformButton.Click += new System.EventHandler(this.TransformButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 324);
            this.Controls.Add(this.TransformButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Output_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input_Box);
            this.Name = "Form1";
            this.Text = "Лабораторная 8";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Output_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TransformButton;
    }
}

