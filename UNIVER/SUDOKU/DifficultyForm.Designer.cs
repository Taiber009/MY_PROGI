namespace SUDOKU
{
    partial class DifficultyForm
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
            this.BHard = new System.Windows.Forms.Button();
            this.BMiddle = new System.Windows.Forms.Button();
            this.BEasy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BHard
            // 
            this.BHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BHard.Location = new System.Drawing.Point(12, 127);
            this.BHard.Name = "BHard";
            this.BHard.Size = new System.Drawing.Size(236, 30);
            this.BHard.TabIndex = 5;
            this.BHard.Text = "Сложная";
            this.BHard.UseVisualStyleBackColor = true;
            this.BHard.Click += new System.EventHandler(this.BHard_Click);
            // 
            // BMiddle
            // 
            this.BMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BMiddle.Location = new System.Drawing.Point(12, 70);
            this.BMiddle.Name = "BMiddle";
            this.BMiddle.Size = new System.Drawing.Size(236, 30);
            this.BMiddle.TabIndex = 4;
            this.BMiddle.Text = "Средняя";
            this.BMiddle.UseVisualStyleBackColor = true;
            this.BMiddle.Click += new System.EventHandler(this.BMiddle_Click);
            // 
            // BEasy
            // 
            this.BEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BEasy.Location = new System.Drawing.Point(12, 12);
            this.BEasy.Name = "BEasy";
            this.BEasy.Size = new System.Drawing.Size(236, 30);
            this.BEasy.TabIndex = 3;
            this.BEasy.Text = "Простая";
            this.BEasy.UseVisualStyleBackColor = true;
            this.BEasy.Click += new System.EventHandler(this.BEasy_Click);
            // 
            // DifficultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 175);
            this.Controls.Add(this.BHard);
            this.Controls.Add(this.BMiddle);
            this.Controls.Add(this.BEasy);
            this.Name = "DifficultyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выберите сложность";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BHard;
        private System.Windows.Forms.Button BMiddle;
        private System.Windows.Forms.Button BEasy;
    }
}