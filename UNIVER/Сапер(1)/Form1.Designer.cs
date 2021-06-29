namespace Сапер_1_
{
    partial class Form1
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
            this.Cheat = new System.Windows.Forms.CheckBox();
            this.Restart = new System.Windows.Forms.Button();
            this.Box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToResizeColumns = false;
            this.Grid.AllowUserToResizeRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.ColumnHeadersVisible = false;
            this.Grid.Location = new System.Drawing.Point(69, 12);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersVisible = false;
            this.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid.Size = new System.Drawing.Size(513, 476);
            this.Grid.TabIndex = 2;
            this.Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            // 
            // Cheat
            // 
            this.Cheat.AutoSize = true;
            this.Cheat.Location = new System.Drawing.Point(12, 38);
            this.Cheat.Name = "Cheat";
            this.Cheat.Size = new System.Drawing.Size(54, 17);
            this.Cheat.TabIndex = 3;
            this.Cheat.Text = "Cheat";
            this.Cheat.UseVisualStyleBackColor = true;
            this.Cheat.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(15, 61);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(51, 23);
            this.Restart.TabIndex = 1;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Go_Click);
            // 
            // Box
            // 
            this.Box.Location = new System.Drawing.Point(12, 12);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(51, 20);
            this.Box.TabIndex = 4;
            this.Box.Text = "9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 493);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.Cheat);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.Restart);
            this.Name = "Form1";
            this.Text = "Сапёр";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.CheckBox Cheat;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.TextBox Box;
    }
}

