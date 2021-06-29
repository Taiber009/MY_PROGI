namespace _8._32
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
            this.Okno1 = new System.Windows.Forms.TextBox();
            this.Okno2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Check1 = new System.Windows.Forms.RadioButton();
            this.Check2 = new System.Windows.Forms.RadioButton();
            this.Vvod = new System.Windows.Forms.Button();
            this.Tab1 = new System.Windows.Forms.DataGridView();
            this.Tab2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Tab1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab2)).BeginInit();
            this.SuspendLayout();
            // 
            // Okno1
            // 
            this.Okno1.Location = new System.Drawing.Point(12, 23);
            this.Okno1.Name = "Okno1";
            this.Okno1.Size = new System.Drawing.Size(100, 20);
            this.Okno1.TabIndex = 0;
            // 
            // Okno2
            // 
            this.Okno2.Location = new System.Drawing.Point(12, 82);
            this.Okno2.Name = "Okno2";
            this.Okno2.Size = new System.Drawing.Size(100, 20);
            this.Okno2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите N:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите М:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Исходный массив:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Изменённый массив:";
            // 
            // Check1
            // 
            this.Check1.AutoSize = true;
            this.Check1.Location = new System.Drawing.Point(12, 132);
            this.Check1.Name = "Check1";
            this.Check1.Size = new System.Drawing.Size(81, 17);
            this.Check1.TabIndex = 8;
            this.Check1.TabStop = true;
            this.Check1.Text = "Минимумы";
            this.Check1.UseVisualStyleBackColor = true;
            // 
            // Check2
            // 
            this.Check2.AutoSize = true;
            this.Check2.Location = new System.Drawing.Point(12, 155);
            this.Check2.Name = "Check2";
            this.Check2.Size = new System.Drawing.Size(87, 17);
            this.Check2.TabIndex = 9;
            this.Check2.TabStop = true;
            this.Check2.Text = "Максимумы";
            this.Check2.UseVisualStyleBackColor = true;
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(22, 387);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(75, 23);
            this.Vvod.TabIndex = 10;
            this.Vvod.Text = "Ввод";
            this.Vvod.UseVisualStyleBackColor = true;
            this.Vvod.Click += new System.EventHandler(this.Vvod_Click);
            // 
            // Tab1
            // 
            this.Tab1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tab1.Location = new System.Drawing.Point(118, 23);
            this.Tab1.Name = "Tab1";
            this.Tab1.Size = new System.Drawing.Size(236, 184);
            this.Tab1.TabIndex = 11;
            // 
            // Tab2
            // 
            this.Tab2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tab2.Location = new System.Drawing.Point(118, 226);
            this.Tab2.Name = "Tab2";
            this.Tab2.Size = new System.Drawing.Size(240, 184);
            this.Tab2.TabIndex = 12;
            // 
            // Proga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 444);
            this.Controls.Add(this.Tab2);
            this.Controls.Add(this.Tab1);
            this.Controls.Add(this.Vvod);
            this.Controls.Add(this.Check2);
            this.Controls.Add(this.Check1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Okno2);
            this.Controls.Add(this.Okno1);
            this.Name = "Proga";
            this.Text = "8.32";
            ((System.ComponentModel.ISupportInitialize)(this.Tab1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Okno1;
        private System.Windows.Forms.TextBox Okno2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton Check1;
        private System.Windows.Forms.RadioButton Check2;
        private System.Windows.Forms.Button Vvod;
        private System.Windows.Forms.DataGridView Tab1;
        private System.Windows.Forms.DataGridView Tab2;
    }
}

