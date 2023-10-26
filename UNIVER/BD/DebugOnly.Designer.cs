namespace BD
{
    partial class DebugOnly
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
            this.Grid = new System.Windows.Forms.DataGridView();
            this.TBinfo = new System.Windows.Forms.TextBox();
            this.Brequest = new System.Windows.Forms.Button();
            this.TBrequest = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(12, 12);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(302, 284);
            this.Grid.TabIndex = 1;
            // 
            // TBinfo
            // 
            this.TBinfo.Enabled = false;
            this.TBinfo.Location = new System.Drawing.Point(12, 302);
            this.TBinfo.Multiline = true;
            this.TBinfo.Name = "TBinfo";
            this.TBinfo.Size = new System.Drawing.Size(538, 190);
            this.TBinfo.TabIndex = 2;
            // 
            // Brequest
            // 
            this.Brequest.Location = new System.Drawing.Point(320, 273);
            this.Brequest.Name = "Brequest";
            this.Brequest.Size = new System.Drawing.Size(230, 23);
            this.Brequest.TabIndex = 3;
            this.Brequest.Text = "Request";
            this.Brequest.UseVisualStyleBackColor = true;
            this.Brequest.Click += new System.EventHandler(this.Brequest_Click);
            // 
            // TBrequest
            // 
            this.TBrequest.Location = new System.Drawing.Point(320, 12);
            this.TBrequest.Multiline = true;
            this.TBrequest.Name = "TBrequest";
            this.TBrequest.Size = new System.Drawing.Size(230, 255);
            this.TBrequest.TabIndex = 4;
            // 
            // DebugOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 504);
            this.Controls.Add(this.TBrequest);
            this.Controls.Add(this.Brequest);
            this.Controls.Add(this.TBinfo);
            this.Controls.Add(this.Grid);
            this.Name = "DebugOnly";
            this.Text = "DebugOnly";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox TBinfo;
        private System.Windows.Forms.Button Brequest;
        private System.Windows.Forms.TextBox TBrequest;
    }
}