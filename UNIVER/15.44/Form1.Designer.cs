namespace _15._44
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
            this.Info2 = new System.Windows.Forms.Label();
            this.Vvod = new System.Windows.Forms.Button();
            this.Okno2 = new System.Windows.Forms.TextBox();
            this.Okno1 = new System.Windows.Forms.TextBox();
            this.Info1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Info2
            // 
            this.Info2.AutoSize = true;
            this.Info2.Location = new System.Drawing.Point(9, 161);
            this.Info2.Name = "Info2";
            this.Info2.Size = new System.Drawing.Size(40, 13);
            this.Info2.TabIndex = 0;
            this.Info2.Text = "Ответ:";
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(52, 203);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(105, 23);
            this.Vvod.TabIndex = 1;
            this.Vvod.Text = "Выберите файл";
            this.Vvod.UseVisualStyleBackColor = true;
            this.Vvod.Click += new System.EventHandler(this.Vvod_Click);
            // 
            // Okno2
            // 
            this.Okno2.Location = new System.Drawing.Point(12, 177);
            this.Okno2.Name = "Okno2";
            this.Okno2.ReadOnly = true;
            this.Okno2.Size = new System.Drawing.Size(204, 20);
            this.Okno2.TabIndex = 2;
            // 
            // Okno1
            // 
            this.Okno1.Location = new System.Drawing.Point(12, 21);
            this.Okno1.Multiline = true;
            this.Okno1.Name = "Okno1";
            this.Okno1.ReadOnly = true;
            this.Okno1.Size = new System.Drawing.Size(204, 137);
            this.Okno1.TabIndex = 3;
            // 
            // Info1
            // 
            this.Info1.AutoSize = true;
            this.Info1.Location = new System.Drawing.Point(9, 5);
            this.Info1.Name = "Info1";
            this.Info1.Size = new System.Drawing.Size(90, 13);
            this.Info1.TabIndex = 4;
            this.Info1.Text = "Исходный файл:";
            // 
            // Proga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 238);
            this.Controls.Add(this.Info1);
            this.Controls.Add(this.Okno1);
            this.Controls.Add(this.Okno2);
            this.Controls.Add(this.Vvod);
            this.Controls.Add(this.Info2);
            this.Name = "Proga";
            this.Text = "15.44";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Info2;
        private System.Windows.Forms.Button Vvod;
        private System.Windows.Forms.TextBox Okno2;
        private System.Windows.Forms.TextBox Okno1;
        private System.Windows.Forms.Label Info1;
    }
}

