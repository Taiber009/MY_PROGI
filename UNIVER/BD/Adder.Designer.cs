namespace BD
{
    partial class Adder
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
            this.Ladd = new System.Windows.Forms.Label();
            this.Badd = new System.Windows.Forms.Button();
            this.Gadd = new System.Windows.Forms.DataGridView();
            this.Linfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Gadd)).BeginInit();
            this.SuspendLayout();
            // 
            // Ladd
            // 
            this.Ladd.AutoSize = true;
            this.Ladd.Location = new System.Drawing.Point(12, 9);
            this.Ladd.Name = "Ladd";
            this.Ladd.Size = new System.Drawing.Size(322, 13);
            this.Ladd.TabIndex = 0;
            this.Ladd.Text = "Введите значения новой строки и добавьте её в базу данных:";
            // 
            // Badd
            // 
            this.Badd.Location = new System.Drawing.Point(15, 133);
            this.Badd.Name = "Badd";
            this.Badd.Size = new System.Drawing.Size(421, 23);
            this.Badd.TabIndex = 1;
            this.Badd.Text = "Добавить";
            this.Badd.UseVisualStyleBackColor = true;
            this.Badd.Click += new System.EventHandler(this.Badd_Click);
            // 
            // Gadd
            // 
            this.Gadd.AllowUserToAddRows = false;
            this.Gadd.AllowUserToDeleteRows = false;
            this.Gadd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Gadd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Gadd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gadd.Location = new System.Drawing.Point(12, 33);
            this.Gadd.Name = "Gadd";
            this.Gadd.Size = new System.Drawing.Size(424, 40);
            this.Gadd.TabIndex = 2;
            // 
            // Linfo
            // 
            this.Linfo.AutoSize = true;
            this.Linfo.Location = new System.Drawing.Point(12, 94);
            this.Linfo.Name = "Linfo";
            this.Linfo.Size = new System.Drawing.Size(0, 13);
            this.Linfo.TabIndex = 3;
            // 
            // Adder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 161);
            this.Controls.Add(this.Linfo);
            this.Controls.Add(this.Gadd);
            this.Controls.Add(this.Badd);
            this.Controls.Add(this.Ladd);
            this.Name = "Adder";
            this.Text = "Adder";
            ((System.ComponentModel.ISupportInitialize)(this.Gadd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ladd;
        private System.Windows.Forms.Button Badd;
        private System.Windows.Forms.DataGridView Gadd;
        private System.Windows.Forms.Label Linfo;
    }
}