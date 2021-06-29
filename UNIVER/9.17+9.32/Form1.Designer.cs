namespace _9._17_9._32
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
            this.Info1 = new System.Windows.Forms.Label();
            this.Okno1 = new System.Windows.Forms.TextBox();
            this.Info2 = new System.Windows.Forms.Label();
            this.Check1 = new System.Windows.Forms.RadioButton();
            this.Check2 = new System.Windows.Forms.RadioButton();
            this.Info3 = new System.Windows.Forms.Label();
            this.Vvod = new System.Windows.Forms.Button();
            this.Tab1 = new System.Windows.Forms.DataGridView();
            this.Check3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Tab1)).BeginInit();
            this.SuspendLayout();
            // 
            // Info1
            // 
            this.Info1.AutoSize = true;
            this.Info1.Location = new System.Drawing.Point(12, 9);
            this.Info1.Name = "Info1";
            this.Info1.Size = new System.Drawing.Size(63, 13);
            this.Info1.TabIndex = 0;
            this.Info1.Text = "Введите N:";
            // 
            // Okno1
            // 
            this.Okno1.Location = new System.Drawing.Point(12, 25);
            this.Okno1.Name = "Okno1";
            this.Okno1.Size = new System.Drawing.Size(58, 20);
            this.Okno1.TabIndex = 1;
            // 
            // Info2
            // 
            this.Info2.AutoSize = true;
            this.Info2.Location = new System.Drawing.Point(132, 9);
            this.Info2.Name = "Info2";
            this.Info2.Size = new System.Drawing.Size(49, 13);
            this.Info2.TabIndex = 2;
            this.Info2.Text = "Массив:";
            // 
            // Check1
            // 
            this.Check1.AutoSize = true;
            this.Check1.Location = new System.Drawing.Point(5, 69);
            this.Check1.Name = "Check1";
            this.Check1.Size = new System.Drawing.Size(46, 17);
            this.Check1.TabIndex = 4;
            this.Check1.TabStop = true;
            this.Check1.Text = "9.17";
            this.Check1.UseVisualStyleBackColor = true;
            // 
            // Check2
            // 
            this.Check2.AutoSize = true;
            this.Check2.Location = new System.Drawing.Point(5, 92);
            this.Check2.Name = "Check2";
            this.Check2.Size = new System.Drawing.Size(46, 17);
            this.Check2.TabIndex = 5;
            this.Check2.TabStop = true;
            this.Check2.Text = "9.32";
            this.Check2.UseVisualStyleBackColor = true;
            // 
            // Info3
            // 
            this.Info3.AutoSize = true;
            this.Info3.Location = new System.Drawing.Point(101, 338);
            this.Info3.Name = "Info3";
            this.Info3.Size = new System.Drawing.Size(43, 13);
            this.Info3.TabIndex = 6;
            this.Info3.Text = "Ответ: ";
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(12, 333);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(75, 23);
            this.Vvod.TabIndex = 7;
            this.Vvod.Text = "Ввод";
            this.Vvod.UseVisualStyleBackColor = true;
            this.Vvod.Click += new System.EventHandler(this.Vvod_Click);
            // 
            // Tab1
            // 
            this.Tab1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tab1.Location = new System.Drawing.Point(135, 25);
            this.Tab1.Name = "Tab1";
            this.Tab1.RowTemplate.ReadOnly = true;
            this.Tab1.Size = new System.Drawing.Size(316, 297);
            this.Tab1.TabIndex = 8;
            // 
            // Check3
            // 
            this.Check3.AutoSize = true;
            this.Check3.Location = new System.Drawing.Point(2, 115);
            this.Check3.Name = "Check3";
            this.Check3.Size = new System.Drawing.Size(120, 17);
            this.Check3.TabIndex = 9;
            this.Check3.TabStop = true;
            this.Check3.Text = "Заполнить массив";
            this.Check3.UseVisualStyleBackColor = true;
            // 
            // Proga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 380);
            this.Controls.Add(this.Check3);
            this.Controls.Add(this.Tab1);
            this.Controls.Add(this.Vvod);
            this.Controls.Add(this.Info3);
            this.Controls.Add(this.Check2);
            this.Controls.Add(this.Check1);
            this.Controls.Add(this.Info2);
            this.Controls.Add(this.Okno1);
            this.Controls.Add(this.Info1);
            this.Name = "Proga";
            this.Text = "9.17+9.32";
            ((System.ComponentModel.ISupportInitialize)(this.Tab1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Info1;
        private System.Windows.Forms.TextBox Okno1;
        private System.Windows.Forms.Label Info2;
        private System.Windows.Forms.RadioButton Check1;
        private System.Windows.Forms.RadioButton Check2;
        private System.Windows.Forms.Label Info3;
        private System.Windows.Forms.Button Vvod;
        private System.Windows.Forms.DataGridView Tab1;
        private System.Windows.Forms.RadioButton Check3;
    }
}

