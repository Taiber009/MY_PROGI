namespace _6._18
{
    partial class PROGA
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
            this.VVOD = new System.Windows.Forms.Button();
            this.OKNO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // VVOD
            // 
            this.VVOD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.VVOD.Location = new System.Drawing.Point(81, 76);
            this.VVOD.Name = "VVOD";
            this.VVOD.Size = new System.Drawing.Size(113, 80);
            this.VVOD.TabIndex = 0;
            this.VVOD.Text = "Ввод";
            this.VVOD.UseVisualStyleBackColor = false;
            this.VVOD.Click += new System.EventHandler(this.button1_Click);
            // 
            // OKNO
            // 
            this.OKNO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OKNO.Location = new System.Drawing.Point(12, 37);
            this.OKNO.Name = "OKNO";
            this.OKNO.Size = new System.Drawing.Size(260, 20);
            this.OKNO.TabIndex = 1;
            this.OKNO.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PROGA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.OKNO);
            this.Controls.Add(this.VVOD);
            this.Name = "PROGA";
            this.Text = "6.18";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VVOD;
        private System.Windows.Forms.TextBox OKNO;
    }
}

