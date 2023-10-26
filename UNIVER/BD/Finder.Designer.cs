namespace BD
{
    partial class Finder
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
            this.TBinfo = new System.Windows.Forms.TextBox();
            this.TBrequest = new System.Windows.Forms.TextBox();
            this.Bfind = new System.Windows.Forms.Button();
            this.Linfo = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // TBinfo
            // 
            this.TBinfo.Enabled = false;
            this.TBinfo.Location = new System.Drawing.Point(12, 363);
            this.TBinfo.Multiline = true;
            this.TBinfo.Name = "TBinfo";
            this.TBinfo.Size = new System.Drawing.Size(573, 83);
            this.TBinfo.TabIndex = 9;
            // 
            // TBrequest
            // 
            this.TBrequest.Location = new System.Drawing.Point(93, 31);
            this.TBrequest.Name = "TBrequest";
            this.TBrequest.Size = new System.Drawing.Size(492, 20);
            this.TBrequest.TabIndex = 8;
            // 
            // Bfind
            // 
            this.Bfind.Location = new System.Drawing.Point(12, 31);
            this.Bfind.Name = "Bfind";
            this.Bfind.Size = new System.Drawing.Size(75, 23);
            this.Bfind.TabIndex = 7;
            this.Bfind.Text = "Поиск";
            this.Bfind.UseVisualStyleBackColor = true;
            this.Bfind.Click += new System.EventHandler(this.Bfind_Click);
            // 
            // Linfo
            // 
            this.Linfo.AutoSize = true;
            this.Linfo.Location = new System.Drawing.Point(90, 15);
            this.Linfo.Name = "Linfo";
            this.Linfo.Size = new System.Drawing.Size(10, 13);
            this.Linfo.TabIndex = 6;
            this.Linfo.Text = ".";
            this.Linfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToResizeColumns = false;
            this.Grid.AllowUserToResizeRows = false;
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Enabled = false;
            this.Grid.Location = new System.Drawing.Point(12, 57);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(573, 300);
            this.Grid.TabIndex = 5;
            // 
            // Finder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 451);
            this.Controls.Add(this.TBinfo);
            this.Controls.Add(this.TBrequest);
            this.Controls.Add(this.Bfind);
            this.Controls.Add(this.Linfo);
            this.Controls.Add(this.Grid);
            this.Name = "Finder";
            this.Text = "Finder";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBinfo;
        private System.Windows.Forms.TextBox TBrequest;
        private System.Windows.Forms.Button Bfind;
        private System.Windows.Forms.Label Linfo;
        private System.Windows.Forms.DataGridView Grid;

    }
}