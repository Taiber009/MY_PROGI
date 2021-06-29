namespace OOP1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.H1 = new System.Windows.Forms.TextBox();
            this.H2 = new System.Windows.Forms.TextBox();
            this.M1 = new System.Windows.Forms.TextBox();
            this.M2 = new System.Windows.Forms.TextBox();
            this.Oper = new System.Windows.Forms.TextBox();
            this.Win = new System.Windows.Forms.TextBox();
            this.W1 = new System.Windows.Forms.TextBox();
            this.W2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Mat1 = new System.Windows.Forms.Button();
            this.Mat2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // H1
            // 
            this.H1.Location = new System.Drawing.Point(33, 39);
            this.H1.Multiline = true;
            this.H1.Name = "H1";
            this.H1.Size = new System.Drawing.Size(32, 20);
            this.H1.TabIndex = 0;
            // 
            // H2
            // 
            this.H2.Location = new System.Drawing.Point(225, 39);
            this.H2.Multiline = true;
            this.H2.Name = "H2";
            this.H2.Size = new System.Drawing.Size(32, 20);
            this.H2.TabIndex = 1;
            // 
            // M1
            // 
            this.M1.Location = new System.Drawing.Point(33, 96);
            this.M1.Multiline = true;
            this.M1.Name = "M1";
            this.M1.Size = new System.Drawing.Size(100, 91);
            this.M1.TabIndex = 2;
            // 
            // M2
            // 
            this.M2.Location = new System.Drawing.Point(225, 96);
            this.M2.Multiline = true;
            this.M2.Name = "M2";
            this.M2.Size = new System.Drawing.Size(100, 91);
            this.M2.TabIndex = 3;
            // 
            // Oper
            // 
            this.Oper.Location = new System.Drawing.Point(154, 128);
            this.Oper.Multiline = true;
            this.Oper.Name = "Oper";
            this.Oper.Size = new System.Drawing.Size(47, 20);
            this.Oper.TabIndex = 4;
            // 
            // Win
            // 
            this.Win.Location = new System.Drawing.Point(128, 244);
            this.Win.Multiline = true;
            this.Win.Name = "Win";
            this.Win.Size = new System.Drawing.Size(100, 105);
            this.Win.TabIndex = 5;
            // 
            // W1
            // 
            this.W1.Location = new System.Drawing.Point(101, 39);
            this.W1.Multiline = true;
            this.W1.Name = "W1";
            this.W1.Size = new System.Drawing.Size(32, 20);
            this.W1.TabIndex = 6;
            // 
            // W2
            // 
            this.W2.Location = new System.Drawing.Point(294, 39);
            this.W2.Multiline = true;
            this.W2.Name = "W2";
            this.W2.Size = new System.Drawing.Size(31, 20);
            this.W2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Матрица 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Матрица 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Оператор";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ответ";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(144, 202);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 14;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Mat1
            // 
            this.Mat1.Location = new System.Drawing.Point(42, 67);
            this.Mat1.Name = "Mat1";
            this.Mat1.Size = new System.Drawing.Size(75, 23);
            this.Mat1.TabIndex = 15;
            this.Mat1.Text = "Mat1";
            this.Mat1.UseVisualStyleBackColor = true;
            this.Mat1.Click += new System.EventHandler(this.Mat1_Click);
            // 
            // Mat2
            // 
            this.Mat2.Location = new System.Drawing.Point(244, 67);
            this.Mat2.Name = "Mat2";
            this.Mat2.Size = new System.Drawing.Size(75, 23);
            this.Mat2.TabIndex = 16;
            this.Mat2.Text = "Mat2";
            this.Mat2.UseVisualStyleBackColor = true;
            this.Mat2.Click += new System.EventHandler(this.Mat2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 185);
            this.button1.TabIndex = 18;
            this.button1.Text = "<ТЫКНИ НА МЕНЯ!>\r\nDOUBLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 185);
            this.button2.TabIndex = 19;
            this.button2.Text = "<ТЫКНИ НА МЕНЯ!>\r\nCOMPLEX";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 425);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Mat2);
            this.Controls.Add(this.Mat1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.W2);
            this.Controls.Add(this.W1);
            this.Controls.Add(this.Win);
            this.Controls.Add(this.Oper);
            this.Controls.Add(this.M2);
            this.Controls.Add(this.M1);
            this.Controls.Add(this.H2);
            this.Controls.Add(this.H1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox H1;
        private System.Windows.Forms.TextBox H2;
        private System.Windows.Forms.TextBox M1;
        private System.Windows.Forms.TextBox M2;
        private System.Windows.Forms.TextBox Oper;
        private System.Windows.Forms.TextBox Win;
        private System.Windows.Forms.TextBox W1;
        private System.Windows.Forms.TextBox W2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Mat1;
        private System.Windows.Forms.Button Mat2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

