namespace ООП2
{
    partial class OOP2
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
            this.Go = new System.Windows.Forms.Button();
            this.Poisk = new System.Windows.Forms.TextBox();
            this.Otvet = new System.Windows.Forms.TextBox();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.Konst = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(100, 227);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(75, 23);
            this.Go.TabIndex = 0;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.button1_Click);
            // 
            // Poisk
            // 
            this.Poisk.Location = new System.Drawing.Point(12, 12);
            this.Poisk.Multiline = true;
            this.Poisk.Name = "Poisk";
            this.Poisk.Size = new System.Drawing.Size(100, 39);
            this.Poisk.TabIndex = 1;
            // 
            // Otvet
            // 
            this.Otvet.Location = new System.Drawing.Point(12, 57);
            this.Otvet.Multiline = true;
            this.Otvet.Name = "Otvet";
            this.Otvet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Otvet.Size = new System.Drawing.Size(206, 136);
            this.Otvet.TabIndex = 2;
            // 
            // FBD
            // 
            this.FBD.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // Konst
            // 
            this.Konst.Location = new System.Drawing.Point(168, 12);
            this.Konst.Name = "Konst";
            this.Konst.Size = new System.Drawing.Size(50, 20);
            this.Konst.TabIndex = 3;
            this.Konst.Text = "10";
            // 
            // OOP2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Konst);
            this.Controls.Add(this.Otvet);
            this.Controls.Add(this.Poisk);
            this.Controls.Add(this.Go);
            this.Name = "OOP2";
            this.Text = "OOP2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.TextBox Poisk;
        private System.Windows.Forms.TextBox Otvet;
        private System.Windows.Forms.FolderBrowserDialog FBD;
        private System.Windows.Forms.TextBox Konst;
    }
}

