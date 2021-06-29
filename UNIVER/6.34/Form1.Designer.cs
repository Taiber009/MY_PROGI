namespace _6._34
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
            this.Okno1 = new System.Windows.Forms.TextBox();
            this.Okno2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.Vvod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Okno1
            // 
            this.Okno1.Location = new System.Drawing.Point(50, 65);
            this.Okno1.Name = "Okno1";
            this.Okno1.Size = new System.Drawing.Size(100, 20);
            this.Okno1.TabIndex = 0;
            this.Okno1.TextChanged += new System.EventHandler(this.Okno1_TextChanged);
            // 
            // Okno2
            // 
            this.Okno2.Location = new System.Drawing.Point(50, 91);
            this.Okno2.Name = "Okno2";
            this.Okno2.Size = new System.Drawing.Size(100, 20);
            this.Okno2.TabIndex = 1;
            this.Okno2.TextChanged += new System.EventHandler(this.Okno2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(156, 68);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(35, 13);
            this.Info.TabIndex = 3;
            this.Info.Text = "label2";
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(50, 117);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(75, 23);
            this.Vvod.TabIndex = 4;
            this.Vvod.Text = "Ввод";
            this.Vvod.UseVisualStyleBackColor = true;
            this.Vvod.Click += new System.EventHandler(this.Vvod_Click_1);
            // 
            // Proga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Vvod);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Okno2);
            this.Controls.Add(this.Okno1);
            this.Name = "Proga";
            this.Text = "6.34";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Okno1;
        private System.Windows.Forms.TextBox Okno2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Button Vvod;
    }
}

