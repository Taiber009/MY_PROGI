namespace _7._16
{
    partial class Proga
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
            this.Vvod = new System.Windows.Forms.Button();
            this.Okno1 = new System.Windows.Forms.TextBox();
            this.Info1 = new System.Windows.Forms.Label();
            this.Info2 = new System.Windows.Forms.Label();
            this.Okno2 = new System.Windows.Forms.TextBox();
            this.Info3 = new System.Windows.Forms.Label();
            this.Info4 = new System.Windows.Forms.Label();
            this.Okno4 = new System.Windows.Forms.TextBox();
            this.Okno3 = new System.Windows.Forms.TextBox();
            this.Secret1 = new System.Windows.Forms.Label();
            this.Secret2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(155, 360);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(75, 23);
            this.Vvod.TabIndex = 0;
            this.Vvod.Text = "Ввод";
            this.Vvod.UseVisualStyleBackColor = true;
            this.Vvod.Click += new System.EventHandler(this.Vvod_Click);
            // 
            // Okno1
            // 
            this.Okno1.Location = new System.Drawing.Point(80, 42);
            this.Okno1.Name = "Okno1";
            this.Okno1.Size = new System.Drawing.Size(100, 20);
            this.Okno1.TabIndex = 1;
            // 
            // Info1
            // 
            this.Info1.AutoSize = true;
            this.Info1.Location = new System.Drawing.Point(14, 45);
            this.Info1.Name = "Info1";
            this.Info1.Size = new System.Drawing.Size(61, 13);
            this.Info1.TabIndex = 2;
            this.Info1.Text = "Введите k:";
            // 
            // Info2
            // 
            this.Info2.AutoSize = true;
            this.Info2.Location = new System.Drawing.Point(14, 74);
            this.Info2.Name = "Info2";
            this.Info2.Size = new System.Drawing.Size(61, 13);
            this.Info2.TabIndex = 3;
            this.Info2.Text = "Введите n:";
            // 
            // Okno2
            // 
            this.Okno2.Location = new System.Drawing.Point(80, 71);
            this.Okno2.Name = "Okno2";
            this.Okno2.Size = new System.Drawing.Size(100, 20);
            this.Okno2.TabIndex = 4;
            // 
            // Info3
            // 
            this.Info3.AutoSize = true;
            this.Info3.Location = new System.Drawing.Point(14, 125);
            this.Info3.Name = "Info3";
            this.Info3.Size = new System.Drawing.Size(0, 13);
            this.Info3.TabIndex = 6;
            this.Info3.Visible = false;
            // 
            // Info4
            // 
            this.Info4.AutoSize = true;
            this.Info4.Location = new System.Drawing.Point(14, 243);
            this.Info4.Name = "Info4";
            this.Info4.Size = new System.Drawing.Size(40, 13);
            this.Info4.TabIndex = 7;
            this.Info4.Text = "Ответ:";
            this.Info4.Visible = false;
            // 
            // Okno4
            // 
            this.Okno4.Location = new System.Drawing.Point(17, 259);
            this.Okno4.Multiline = true;
            this.Okno4.Name = "Okno4";
            this.Okno4.Size = new System.Drawing.Size(261, 75);
            this.Okno4.TabIndex = 8;
            this.Okno4.Visible = false;
            // 
            // Okno3
            // 
            this.Okno3.Location = new System.Drawing.Point(17, 141);
            this.Okno3.Multiline = true;
            this.Okno3.Name = "Okno3";
            this.Okno3.Size = new System.Drawing.Size(261, 99);
            this.Okno3.TabIndex = 9;
            this.Okno3.Visible = false;
            // 
            // Secret1
            // 
            this.Secret1.AutoSize = true;
            this.Secret1.Location = new System.Drawing.Point(315, 49);
            this.Secret1.Name = "Secret1";
            this.Secret1.Size = new System.Drawing.Size(0, 13);
            this.Secret1.TabIndex = 10;
            this.Secret1.Visible = false;
            // 
            // Secret2
            // 
            this.Secret2.AutoSize = true;
            this.Secret2.Location = new System.Drawing.Point(315, 62);
            this.Secret2.Name = "Secret2";
            this.Secret2.Size = new System.Drawing.Size(0, 13);
            this.Secret2.TabIndex = 11;
            this.Secret2.Visible = false;
            // 
            // Proga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 395);
            this.Controls.Add(this.Secret2);
            this.Controls.Add(this.Secret1);
            this.Controls.Add(this.Okno3);
            this.Controls.Add(this.Okno4);
            this.Controls.Add(this.Info4);
            this.Controls.Add(this.Info3);
            this.Controls.Add(this.Okno2);
            this.Controls.Add(this.Info2);
            this.Controls.Add(this.Info1);
            this.Controls.Add(this.Okno1);
            this.Controls.Add(this.Vvod);
            this.Name = "Proga";
            this.Text = "7.16";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Vvod;
        private System.Windows.Forms.TextBox Okno1;
        private System.Windows.Forms.Label Info1;
        private System.Windows.Forms.Label Info2;
        private System.Windows.Forms.TextBox Okno2;
        private System.Windows.Forms.Label Info3;
        private System.Windows.Forms.Label Info4;
        private System.Windows.Forms.TextBox Okno4;
        private System.Windows.Forms.TextBox Okno3;
        private System.Windows.Forms.Label Secret1;
        private System.Windows.Forms.Label Secret2;
    }
}

