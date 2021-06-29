namespace _10._6
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
            this.Okno = new System.Windows.Forms.TextBox();
            this.Info = new System.Windows.Forms.Label();
            this.Vvod = new System.Windows.Forms.Button();
            this.Info2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Okno
            // 
            this.Okno.Location = new System.Drawing.Point(12, 21);
            this.Okno.Name = "Okno";
            this.Okno.Size = new System.Drawing.Size(100, 20);
            this.Okno.TabIndex = 0;
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(12, 44);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(0, 13);
            this.Info.TabIndex = 1;
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(37, 209);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(75, 23);
            this.Vvod.TabIndex = 2;
            this.Vvod.Text = "Ввод";
            this.Vvod.UseVisualStyleBackColor = true;
            this.Vvod.Click += new System.EventHandler(this.Vvod_Click);
            // 
            // Info2
            // 
            this.Info2.AutoSize = true;
            this.Info2.Location = new System.Drawing.Point(9, 5);
            this.Info2.Name = "Info2";
            this.Info2.Size = new System.Drawing.Size(109, 13);
            this.Info2.TabIndex = 3;
            this.Info2.Text = "Введите одну букву:";
            // 
            // Proga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Info2);
            this.Controls.Add(this.Vvod);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Okno);
            this.Name = "Proga";
            this.Text = "10.8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Okno;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Button Vvod;
        private System.Windows.Forms.Label Info2;
    }
}

