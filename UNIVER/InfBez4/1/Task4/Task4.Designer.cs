namespace RSA
{
    partial class Task4
    {
        /// <summary>Обязательная переменная конструктора</summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>Освободить все используемые ресурсы</summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NLabel = new System.Windows.Forms.Label();
            this.NTB = new System.Windows.Forms.TextBox();
            this.ETB = new System.Windows.Forms.TextBox();
            this.eLabel = new System.Windows.Forms.Label();
            this.CTB = new System.Windows.Forms.TextBox();
            this.CLabel = new System.Windows.Forms.Label();
            this.DLabel = new System.Windows.Forms.Label();
            this.Dechiper = new System.Windows.Forms.Button();
            this.Clean = new System.Windows.Forms.Button();
            this.DTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NLabel
            // 
            this.NLabel.AutoSize = true;
            this.NLabel.Location = new System.Drawing.Point(8, 10);
            this.NLabel.Name = "NLabel";
            this.NLabel.Size = new System.Drawing.Size(18, 13);
            this.NLabel.TabIndex = 0;
            this.NLabel.Text = "N:";
            // 
            // NTB
            // 
            this.NTB.BackColor = System.Drawing.SystemColors.Window;
            this.NTB.Location = new System.Drawing.Point(26, 7);
            this.NTB.Name = "NTB";
            this.NTB.ReadOnly = true;
            this.NTB.Size = new System.Drawing.Size(107, 20);
            this.NTB.TabIndex = 1;
            this.NTB.Text = "1814354438978629";
            // 
            // ETB
            // 
            this.ETB.BackColor = System.Drawing.SystemColors.Window;
            this.ETB.Location = new System.Drawing.Point(167, 7);
            this.ETB.Name = "ETB";
            this.ETB.ReadOnly = true;
            this.ETB.Size = new System.Drawing.Size(39, 20);
            this.ETB.TabIndex = 3;
            this.ETB.Text = "11119";
            // 
            // eLabel
            // 
            this.eLabel.AutoSize = true;
            this.eLabel.Location = new System.Drawing.Point(150, 10);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(16, 13);
            this.eLabel.TabIndex = 2;
            this.eLabel.Text = "e:";
            // 
            // CTB
            // 
            this.CTB.BackColor = System.Drawing.SystemColors.Window;
            this.CTB.Location = new System.Drawing.Point(26, 33);
            this.CTB.Multiline = true;
            this.CTB.Name = "CTB";
            this.CTB.ReadOnly = true;
            this.CTB.Size = new System.Drawing.Size(180, 58);
            this.CTB.TabIndex = 5;
            this.CTB.Text = "607333454985473748183881750546921891989337248193427278679982905285071060323130193" +
    "7207488228";
            // 
            // CLabel
            // 
            this.CLabel.AutoSize = true;
            this.CLabel.Location = new System.Drawing.Point(8, 36);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(17, 13);
            this.CLabel.TabIndex = 4;
            this.CLabel.Text = "C:";
            // 
            // DLabel
            // 
            this.DLabel.AutoSize = true;
            this.DLabel.Location = new System.Drawing.Point(8, 101);
            this.DLabel.Name = "DLabel";
            this.DLabel.Size = new System.Drawing.Size(18, 13);
            this.DLabel.TabIndex = 6;
            this.DLabel.Text = "D:";
            // 
            // Dechiper
            // 
            this.Dechiper.Location = new System.Drawing.Point(80, 165);
            this.Dechiper.Name = "Dechiper";
            this.Dechiper.Size = new System.Drawing.Size(60, 23);
            this.Dechiper.TabIndex = 8;
            this.Dechiper.Text = "Dechiper";
            this.Dechiper.UseVisualStyleBackColor = true;
            this.Dechiper.Click += new System.EventHandler(this.Dechiper_Click);
            // 
            // Clean
            // 
            this.Clean.Enabled = false;
            this.Clean.Location = new System.Drawing.Point(146, 165);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(60, 23);
            this.Clean.TabIndex = 9;
            this.Clean.Text = "Clean";
            this.Clean.UseVisualStyleBackColor = true;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // DTB
            // 
            this.DTB.BackColor = System.Drawing.SystemColors.Window;
            this.DTB.Location = new System.Drawing.Point(26, 101);
            this.DTB.Multiline = true;
            this.DTB.Name = "DTB";
            this.DTB.ReadOnly = true;
            this.DTB.Size = new System.Drawing.Size(180, 58);
            this.DTB.TabIndex = 10;
            // 
            // Task4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 193);
            this.Controls.Add(this.DTB);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.Dechiper);
            this.Controls.Add(this.DLabel);
            this.Controls.Add(this.CTB);
            this.Controls.Add(this.CLabel);
            this.Controls.Add(this.ETB);
            this.Controls.Add(this.eLabel);
            this.Controls.Add(this.NTB);
            this.Controls.Add(this.NLabel);
            this.Name = "Task4";
            this.Text = "RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NLabel;
        private System.Windows.Forms.TextBox NTB;
        private System.Windows.Forms.TextBox ETB;
        private System.Windows.Forms.Label eLabel;
        private System.Windows.Forms.TextBox CTB;
        private System.Windows.Forms.Label CLabel;
        private System.Windows.Forms.Label DLabel;
        private System.Windows.Forms.Button Dechiper;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.TextBox DTB;
    }
}

