namespace _15._30
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
            this.Vvod = new System.Windows.Forms.Button();
            this.Info1 = new System.Windows.Forms.Label();
            this.Okno1 = new System.Windows.Forms.TextBox();
            this.Okno2 = new System.Windows.Forms.TextBox();
            this.Info2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(89, 306);
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
            this.Info1.Size = new System.Drawing.Size(37, 13);
            this.Info1.TabIndex = 2;
            this.Info1.Text = "Было:";
            this.Info1.Visible = false;
            // 
            // Okno1
            // 
            this.Okno1.Location = new System.Drawing.Point(12, 25);
            this.Okno1.Multiline = true;
            this.Okno1.Name = "Okno1";
            this.Okno1.Size = new System.Drawing.Size(111, 275);
            this.Okno1.TabIndex = 4;
            // 
            // Okno2
            // 
            this.Okno2.Location = new System.Drawing.Point(127, 25);
            this.Okno2.Multiline = true;
            this.Okno2.Name = "Okno2";
            this.Okno2.Size = new System.Drawing.Size(111, 275);
            this.Okno2.TabIndex = 5;
            // 
            // Info2
            // 
            this.Info2.AutoSize = true;
            this.Info2.Location = new System.Drawing.Point(124, 9);
            this.Info2.Name = "Info2";
            this.Info2.Size = new System.Drawing.Size(40, 13);
            this.Info2.TabIndex = 6;
            this.Info2.Text = "Стало:";
            this.Info2.Visible = false;
            // 
            // Proga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 353);
            this.Controls.Add(this.Info2);
            this.Controls.Add(this.Okno2);
            this.Controls.Add(this.Okno1);
            this.Controls.Add(this.Info1);
            this.Controls.Add(this.Vvod);
            this.Name = "Proga";
            this.Text = "15.30";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Vvod;
        private System.Windows.Forms.Label Info1;
        private System.Windows.Forms.TextBox Okno1;
        private System.Windows.Forms.TextBox Okno2;
        private System.Windows.Forms.Label Info2;
    }
}

