namespace _11._6
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
            this.Info1 = new System.Windows.Forms.Label();
            this.Info2 = new System.Windows.Forms.Label();
            this.Okno1 = new System.Windows.Forms.TextBox();
            this.Okno2 = new System.Windows.Forms.TextBox();
            this.Okno3 = new System.Windows.Forms.TextBox();
            this.Info3 = new System.Windows.Forms.Label();
            this.Info4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(12, 115);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(75, 23);
            this.Vvod.TabIndex = 0;
            this.Vvod.Text = "Ввод";
            this.Vvod.UseVisualStyleBackColor = true;
            this.Vvod.Click += new System.EventHandler(this.Vvod_Click);
            // 
            // Info1
            // 
            this.Info1.AutoSize = true;
            this.Info1.Location = new System.Drawing.Point(12, 9);
            this.Info1.Name = "Info1";
            this.Info1.Size = new System.Drawing.Size(34, 13);
            this.Info1.TabIndex = 1;
            this.Info1.Text = "День";
            // 
            // Info2
            // 
            this.Info2.AutoSize = true;
            this.Info2.Location = new System.Drawing.Point(12, 34);
            this.Info2.Name = "Info2";
            this.Info2.Size = new System.Drawing.Size(40, 13);
            this.Info2.TabIndex = 2;
            this.Info2.Text = "Месяц";
            // 
            // Okno1
            // 
            this.Okno1.Location = new System.Drawing.Point(53, 6);
            this.Okno1.Name = "Okno1";
            this.Okno1.Size = new System.Drawing.Size(42, 20);
            this.Okno1.TabIndex = 3;
            // 
            // Okno2
            // 
            this.Okno2.Location = new System.Drawing.Point(53, 31);
            this.Okno2.Name = "Okno2";
            this.Okno2.Size = new System.Drawing.Size(42, 20);
            this.Okno2.TabIndex = 4;
            // 
            // Okno3
            // 
            this.Okno3.Location = new System.Drawing.Point(53, 57);
            this.Okno3.Name = "Okno3";
            this.Okno3.Size = new System.Drawing.Size(42, 20);
            this.Okno3.TabIndex = 5;
            // 
            // Info3
            // 
            this.Info3.AutoSize = true;
            this.Info3.Location = new System.Drawing.Point(12, 60);
            this.Info3.Name = "Info3";
            this.Info3.Size = new System.Drawing.Size(25, 13);
            this.Info3.TabIndex = 6;
            this.Info3.Text = "Год";
            // 
            // Info4
            // 
            this.Info4.AutoSize = true;
            this.Info4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info4.Location = new System.Drawing.Point(12, 88);
            this.Info4.Name = "Info4";
            this.Info4.Size = new System.Drawing.Size(56, 17);
            this.Info4.TabIndex = 7;
            this.Info4.Text = "Ответ: ";
            // 
            // Proga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 164);
            this.Controls.Add(this.Info4);
            this.Controls.Add(this.Info3);
            this.Controls.Add(this.Okno3);
            this.Controls.Add(this.Okno2);
            this.Controls.Add(this.Okno1);
            this.Controls.Add(this.Info2);
            this.Controls.Add(this.Info1);
            this.Controls.Add(this.Vvod);
            this.Name = "Proga";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Vvod;
        private System.Windows.Forms.Label Info1;
        private System.Windows.Forms.Label Info2;
        private System.Windows.Forms.TextBox Okno1;
        private System.Windows.Forms.TextBox Okno2;
        private System.Windows.Forms.TextBox Okno3;
        private System.Windows.Forms.Label Info3;
        private System.Windows.Forms.Label Info4;
    }
}

