namespace Задача_5_
{
    partial class Proga
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Otvet = new System.Windows.Forms.Label();
            this.Okno1 = new System.Windows.Forms.TextBox();
            this.Vvod = new System.Windows.Forms.Button();
            this.Vibor = new System.Windows.Forms.OpenFileDialog();
            this.Info1 = new System.Windows.Forms.Label();
            this.Okno2 = new System.Windows.Forms.TextBox();
            this.Info2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Otvet
            // 
            this.Otvet.AutoSize = true;
            this.Otvet.Location = new System.Drawing.Point(11, 56);
            this.Otvet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Otvet.Name = "Otvet";
            this.Otvet.Size = new System.Drawing.Size(40, 13);
            this.Otvet.TabIndex = 0;
            this.Otvet.Text = "Ответ:";
            // 
            // Okno1
            // 
            this.Okno1.Location = new System.Drawing.Point(2, 24);
            this.Okno1.Margin = new System.Windows.Forms.Padding(2);
            this.Okno1.Name = "Okno1";
            this.Okno1.Size = new System.Drawing.Size(76, 20);
            this.Okno1.TabIndex = 1;
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(101, 84);
            this.Vvod.Margin = new System.Windows.Forms.Padding(2);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(56, 19);
            this.Vvod.TabIndex = 2;
            this.Vvod.Text = "Ввод";
            this.Vvod.UseVisualStyleBackColor = true;
            this.Vvod.Click += new System.EventHandler(this.Vvod_Click);
            // 
            // Vibor
            // 
            this.Vibor.FileName = "openFileDialog1";
            // 
            // Info1
            // 
            this.Info1.AutoSize = true;
            this.Info1.Location = new System.Drawing.Point(-1, 9);
            this.Info1.Name = "Info1";
            this.Info1.Size = new System.Drawing.Size(81, 13);
            this.Info1.TabIndex = 3;
            this.Info1.Text = "Введите язык:";
            // 
            // Okno2
            // 
            this.Okno2.Location = new System.Drawing.Point(89, 24);
            this.Okno2.Margin = new System.Windows.Forms.Padding(2);
            this.Okno2.Name = "Okno2";
            this.Okno2.Size = new System.Drawing.Size(213, 20);
            this.Okno2.TabIndex = 4;
            // 
            // Info2
            // 
            this.Info2.AutoSize = true;
            this.Info2.Location = new System.Drawing.Point(86, 9);
            this.Info2.Name = "Info2";
            this.Info2.Size = new System.Drawing.Size(85, 13);
            this.Info2.TabIndex = 5;
            this.Info2.Text = "Введите адрес:";
            // 
            // Proga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 124);
            this.Controls.Add(this.Info2);
            this.Controls.Add(this.Okno2);
            this.Controls.Add(this.Info1);
            this.Controls.Add(this.Vvod);
            this.Controls.Add(this.Okno1);
            this.Controls.Add(this.Otvet);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Proga";
            this.Text = "Задача 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Otvet;
        private System.Windows.Forms.TextBox Okno1;
        private System.Windows.Forms.Button Vvod;
        private System.Windows.Forms.OpenFileDialog Vibor;
        private System.Windows.Forms.Label Info1;
        private System.Windows.Forms.TextBox Okno2;
        private System.Windows.Forms.Label Info2;
    }
}