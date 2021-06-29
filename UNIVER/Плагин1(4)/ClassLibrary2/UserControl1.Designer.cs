namespace ClassLibrary2
{
    partial class UserControl1
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ya = new System.Windows.Forms.TextBox();
            this.Ko = new System.Windows.Forms.TextBox();
            this.FU = new System.Windows.Forms.Button();
            this.FD = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ya
            // 
            this.Ya.Location = new System.Drawing.Point(49, 43);
            this.Ya.Name = "Ya";
            this.Ya.ReadOnly = true;
            this.Ya.Size = new System.Drawing.Size(29, 20);
            this.Ya.TabIndex = 5;
            this.Ya.Text = "0";
            // 
            // Ko
            // 
            this.Ko.Location = new System.Drawing.Point(49, 89);
            this.Ko.Name = "Ko";
            this.Ko.ReadOnly = true;
            this.Ko.Size = new System.Drawing.Size(29, 20);
            this.Ko.TabIndex = 6;
            this.Ko.Text = "0";
            // 
            // FU
            // 
            this.FU.Location = new System.Drawing.Point(84, 32);
            this.FU.Name = "FU";
            this.FU.Size = new System.Drawing.Size(23, 18);
            this.FU.TabIndex = 7;
            this.FU.Text = "+";
            this.FU.UseVisualStyleBackColor = true;
            this.FU.Click += new System.EventHandler(this.FU_Click);
            // 
            // FD
            // 
            this.FD.Location = new System.Drawing.Point(84, 56);
            this.FD.Name = "FD";
            this.FD.Size = new System.Drawing.Size(23, 18);
            this.FD.TabIndex = 8;
            this.FD.Text = "-";
            this.FD.UseVisualStyleBackColor = true;
            this.FD.Click += new System.EventHandler(this.FD_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 18);
            this.button1.TabIndex = 10;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 18);
            this.button2.TabIndex = 9;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FD);
            this.Controls.Add(this.FU);
            this.Controls.Add(this.Ko);
            this.Controls.Add(this.Ya);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(163, 167);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ya;
        private System.Windows.Forms.TextBox Ko;
        private System.Windows.Forms.Button FU;
        private System.Windows.Forms.Button FD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
