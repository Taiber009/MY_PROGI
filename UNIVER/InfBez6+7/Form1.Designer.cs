namespace InfBez6
{
    partial class F
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
            this.Bopen = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.PB2 = new System.Windows.Forms.PictureBox();
            this.PB3 = new System.Windows.Forms.PictureBox();
            this.TB = new System.Windows.Forms.TextBox();
            this.RBr = new System.Windows.Forms.RadioButton();
            this.RBg = new System.Windows.Forms.RadioButton();
            this.RBb = new System.Windows.Forms.RadioButton();
            this.LB1 = new System.Windows.Forms.ListBox();
            this.LB2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Bwrite = new System.Windows.Forms.Button();
            this.Bsave = new System.Windows.Forms.Button();
            this.Bstart = new System.Windows.Forms.Button();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.Bclear = new System.Windows.Forms.Button();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.Bread = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB3)).BeginInit();
            this.SuspendLayout();
            // 
            // Bopen
            // 
            this.Bopen.Location = new System.Drawing.Point(12, 0);
            this.Bopen.Name = "Bopen";
            this.Bopen.Size = new System.Drawing.Size(122, 23);
            this.Bopen.TabIndex = 2;
            this.Bopen.Text = "Open";
            this.Bopen.UseVisualStyleBackColor = true;
            this.Bopen.Click += new System.EventHandler(this.Bopen_Click);
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // PB1
            // 
            this.PB1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PB1.Location = new System.Drawing.Point(12, 29);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(211, 103);
            this.PB1.TabIndex = 3;
            this.PB1.TabStop = false;
            // 
            // PB2
            // 
            this.PB2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PB2.Location = new System.Drawing.Point(229, 28);
            this.PB2.Name = "PB2";
            this.PB2.Size = new System.Drawing.Size(232, 104);
            this.PB2.TabIndex = 4;
            this.PB2.TabStop = false;
            this.PB2.Visible = false;
            // 
            // PB3
            // 
            this.PB3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PB3.Location = new System.Drawing.Point(12, 138);
            this.PB3.Name = "PB3";
            this.PB3.Size = new System.Drawing.Size(211, 103);
            this.PB3.TabIndex = 5;
            this.PB3.TabStop = false;
            this.PB3.Visible = false;
            // 
            // TB
            // 
            this.TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB.Location = new System.Drawing.Point(396, 5);
            this.TB.Name = "TB";
            this.TB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TB.Size = new System.Drawing.Size(122, 20);
            this.TB.TabIndex = 1;
            // 
            // RBr
            // 
            this.RBr.AutoSize = true;
            this.RBr.Location = new System.Drawing.Point(268, 5);
            this.RBr.Name = "RBr";
            this.RBr.Size = new System.Drawing.Size(33, 17);
            this.RBr.TabIndex = 6;
            this.RBr.Text = "R";
            this.RBr.UseVisualStyleBackColor = true;
            // 
            // RBg
            // 
            this.RBg.AutoSize = true;
            this.RBg.Location = new System.Drawing.Point(307, 5);
            this.RBg.Name = "RBg";
            this.RBg.Size = new System.Drawing.Size(33, 17);
            this.RBg.TabIndex = 7;
            this.RBg.Text = "G";
            this.RBg.UseVisualStyleBackColor = true;
            // 
            // RBb
            // 
            this.RBb.AutoSize = true;
            this.RBb.Checked = true;
            this.RBb.Location = new System.Drawing.Point(346, 5);
            this.RBb.Name = "RBb";
            this.RBb.Size = new System.Drawing.Size(32, 17);
            this.RBb.TabIndex = 8;
            this.RBb.TabStop = true;
            this.RBb.Text = "B";
            this.RBb.UseVisualStyleBackColor = true;
            // 
            // LB1
            // 
            this.LB1.FormattingEnabled = true;
            this.LB1.Location = new System.Drawing.Point(545, 7);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(59, 17);
            this.LB1.TabIndex = 9;
            // 
            // LB2
            // 
            this.LB2.FormattingEnabled = true;
            this.LB2.Location = new System.Drawing.Point(629, 7);
            this.LB2.Name = "LB2";
            this.LB2.Size = new System.Drawing.Size(59, 17);
            this.LB2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "| :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(604, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "---:";
            // 
            // Bwrite
            // 
            this.Bwrite.Location = new System.Drawing.Point(694, -1);
            this.Bwrite.Name = "Bwrite";
            this.Bwrite.Size = new System.Drawing.Size(122, 23);
            this.Bwrite.TabIndex = 13;
            this.Bwrite.Text = "Write";
            this.Bwrite.UseVisualStyleBackColor = true;
            this.Bwrite.Click += new System.EventHandler(this.Bwrite_Click);
            // 
            // Bsave
            // 
            this.Bsave.Location = new System.Drawing.Point(822, -1);
            this.Bsave.Name = "Bsave";
            this.Bsave.Size = new System.Drawing.Size(122, 23);
            this.Bsave.TabIndex = 14;
            this.Bsave.Text = "SaveChanged";
            this.Bsave.UseVisualStyleBackColor = true;
            this.Bsave.Click += new System.EventHandler(this.Bsave_Click);
            // 
            // Bstart
            // 
            this.Bstart.Location = new System.Drawing.Point(140, -1);
            this.Bstart.Name = "Bstart";
            this.Bstart.Size = new System.Drawing.Size(122, 23);
            this.Bstart.TabIndex = 15;
            this.Bstart.Text = "Start";
            this.Bstart.UseVisualStyleBackColor = true;
            this.Bstart.Click += new System.EventHandler(this.Bstart_Click);
            // 
            // Bclear
            // 
            this.Bclear.Location = new System.Drawing.Point(950, -1);
            this.Bclear.Name = "Bclear";
            this.Bclear.Size = new System.Drawing.Size(122, 23);
            this.Bclear.TabIndex = 16;
            this.Bclear.Text = "ClearChanged";
            this.Bclear.UseVisualStyleBackColor = true;
            this.Bclear.Click += new System.EventHandler(this.Bclear_Click);
            // 
            // TB2
            // 
            this.TB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB2.Location = new System.Drawing.Point(229, 138);
            this.TB2.Multiline = true;
            this.TB2.Name = "TB2";
            this.TB2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TB2.Size = new System.Drawing.Size(232, 103);
            this.TB2.TabIndex = 17;
            this.TB2.Visible = false;
            // 
            // Bread
            // 
            this.Bread.Location = new System.Drawing.Point(1078, -1);
            this.Bread.Name = "Bread";
            this.Bread.Size = new System.Drawing.Size(122, 23);
            this.Bread.TabIndex = 18;
            this.Bread.Text = "Read";
            this.Bread.UseVisualStyleBackColor = true;
            this.Bread.Click += new System.EventHandler(this.Bread_Click);
            // 
            // F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1138, 282);
            this.Controls.Add(this.Bread);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.Bclear);
            this.Controls.Add(this.Bstart);
            this.Controls.Add(this.Bsave);
            this.Controls.Add(this.Bwrite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB2);
            this.Controls.Add(this.LB1);
            this.Controls.Add(this.RBb);
            this.Controls.Add(this.RBg);
            this.Controls.Add(this.RBr);
            this.Controls.Add(this.PB3);
            this.Controls.Add(this.PB2);
            this.Controls.Add(this.PB1);
            this.Controls.Add(this.Bopen);
            this.Controls.Add(this.TB);
            this.Name = "F";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.F_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bopen;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.PictureBox PB2;
        private System.Windows.Forms.PictureBox PB3;
        private System.Windows.Forms.TextBox TB;
        private System.Windows.Forms.RadioButton RBr;
        private System.Windows.Forms.RadioButton RBg;
        private System.Windows.Forms.RadioButton RBb;
        private System.Windows.Forms.ListBox LB1;
        private System.Windows.Forms.ListBox LB2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Bwrite;
        private System.Windows.Forms.Button Bsave;
        private System.Windows.Forms.Button Bstart;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.Button Bclear;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.Button Bread;
    }
}

