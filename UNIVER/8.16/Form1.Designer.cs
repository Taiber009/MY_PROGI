namespace _8._16
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
            this.Okno1 = new System.Windows.Forms.TextBox();
            this.Info1 = new System.Windows.Forms.Label();
            this.Check1 = new System.Windows.Forms.RadioButton();
            this.Check2 = new System.Windows.Forms.RadioButton();
            this.Check3 = new System.Windows.Forms.RadioButton();
            this.Check4 = new System.Windows.Forms.RadioButton();
            this.Info2 = new System.Windows.Forms.Label();
            this.Tab1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Tab1)).BeginInit();
            this.SuspendLayout();
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(12, 338);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(75, 23);
            this.Vvod.TabIndex = 0;
            this.Vvod.Text = "Ввод";
            this.Vvod.UseVisualStyleBackColor = true;
            this.Vvod.Click += new System.EventHandler(this.Vvod_Click_1);
            // 
            // Okno1
            // 
            this.Okno1.Location = new System.Drawing.Point(12, 41);
            this.Okno1.Name = "Okno1";
            this.Okno1.Size = new System.Drawing.Size(100, 20);
            this.Okno1.TabIndex = 1;
            // 
            // Info1
            // 
            this.Info1.AutoSize = true;
            this.Info1.Location = new System.Drawing.Point(12, 25);
            this.Info1.Name = "Info1";
            this.Info1.Size = new System.Drawing.Size(64, 13);
            this.Info1.TabIndex = 2;
            this.Info1.Text = "Введите М:";
            // 
            // Check1
            // 
            this.Check1.AutoSize = true;
            this.Check1.Location = new System.Drawing.Point(12, 67);
            this.Check1.Name = "Check1";
            this.Check1.Size = new System.Drawing.Size(97, 17);
            this.Check1.TabIndex = 3;
            this.Check1.TabStop = true;
            this.Check1.Text = "Ниже главной";
            this.Check1.UseVisualStyleBackColor = true;
            // 
            // Check2
            // 
            this.Check2.AutoSize = true;
            this.Check2.Location = new System.Drawing.Point(12, 90);
            this.Check2.Name = "Check2";
            this.Check2.Size = new System.Drawing.Size(98, 17);
            this.Check2.TabIndex = 4;
            this.Check2.TabStop = true;
            this.Check2.Text = "Выше главной";
            this.Check2.UseVisualStyleBackColor = true;
            // 
            // Check3
            // 
            this.Check3.AutoSize = true;
            this.Check3.Location = new System.Drawing.Point(12, 113);
            this.Check3.Name = "Check3";
            this.Check3.Size = new System.Drawing.Size(109, 17);
            this.Check3.TabIndex = 5;
            this.Check3.TabStop = true;
            this.Check3.Text = "Ниже побоичной";
            this.Check3.UseVisualStyleBackColor = true;
            // 
            // Check4
            // 
            this.Check4.AutoSize = true;
            this.Check4.Location = new System.Drawing.Point(12, 136);
            this.Check4.Name = "Check4";
            this.Check4.Size = new System.Drawing.Size(110, 17);
            this.Check4.TabIndex = 6;
            this.Check4.TabStop = true;
            this.Check4.Text = "Выше побоичной";
            this.Check4.UseVisualStyleBackColor = true;
            // 
            // Info2
            // 
            this.Info2.AutoSize = true;
            this.Info2.Location = new System.Drawing.Point(127, 25);
            this.Info2.Name = "Info2";
            this.Info2.Size = new System.Drawing.Size(49, 13);
            this.Info2.TabIndex = 8;
            this.Info2.Text = "Массив:";
            // 
            // Tab1
            // 
            this.Tab1.AllowUserToAddRows = false;
            this.Tab1.AllowUserToDeleteRows = false;
            this.Tab1.AllowUserToResizeColumns = false;
            this.Tab1.AllowUserToResizeRows = false;
            this.Tab1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tab1.Location = new System.Drawing.Point(130, 41);
            this.Tab1.Name = "Tab1";
            this.Tab1.Size = new System.Drawing.Size(331, 306);
            this.Tab1.TabIndex = 9;
            // 
            // Proga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 374);
            this.Controls.Add(this.Tab1);
            this.Controls.Add(this.Info2);
            this.Controls.Add(this.Check4);
            this.Controls.Add(this.Check3);
            this.Controls.Add(this.Check2);
            this.Controls.Add(this.Check1);
            this.Controls.Add(this.Info1);
            this.Controls.Add(this.Okno1);
            this.Controls.Add(this.Vvod);
            this.Name = "Proga";
            this.Text = "8.16";
            ((System.ComponentModel.ISupportInitialize)(this.Tab1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Vvod;
        private System.Windows.Forms.TextBox Okno1;
        private System.Windows.Forms.Label Info1;
        private System.Windows.Forms.RadioButton Check1;
        private System.Windows.Forms.RadioButton Check2;
        private System.Windows.Forms.RadioButton Check3;
        private System.Windows.Forms.RadioButton Check4;
        private System.Windows.Forms.Label Info2;
        private System.Windows.Forms.DataGridView Tab1;
    }
}

