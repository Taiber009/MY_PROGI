namespace _16._5
{
    partial class Form1
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
            this.Grid = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otvet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Go = new System.Windows.Forms.Button();
            this.BoxA = new System.Windows.Forms.TextBox();
            this.BoxX = new System.Windows.Forms.TextBox();
            this.LabX = new System.Windows.Forms.Label();
            this.LabA = new System.Windows.Forms.Label();
            this.BoxN = new System.Windows.Forms.TextBox();
            this.LabN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.x,
            this.Otvet});
            this.Grid.Location = new System.Drawing.Point(0, 0);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(344, 594);
            this.Grid.TabIndex = 0;
            // 
            // a
            // 
            this.a.HeaderText = "A";
            this.a.Name = "a";
            // 
            // x
            // 
            this.x.HeaderText = "X";
            this.x.Name = "x";
            // 
            // Otvet
            // 
            this.Otvet.HeaderText = "Otvet";
            this.Otvet.Name = "Otvet";
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(365, 286);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(75, 23);
            this.Go.TabIndex = 1;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // BoxA
            // 
            this.BoxA.Location = new System.Drawing.Point(350, 197);
            this.BoxA.Name = "BoxA";
            this.BoxA.Size = new System.Drawing.Size(100, 20);
            this.BoxA.TabIndex = 2;
            // 
            // BoxX
            // 
            this.BoxX.Location = new System.Drawing.Point(350, 132);
            this.BoxX.Name = "BoxX";
            this.BoxX.Size = new System.Drawing.Size(100, 20);
            this.BoxX.TabIndex = 3;
            // 
            // LabX
            // 
            this.LabX.AutoSize = true;
            this.LabX.Location = new System.Drawing.Point(350, 116);
            this.LabX.Name = "LabX";
            this.LabX.Size = new System.Drawing.Size(59, 13);
            this.LabX.TabIndex = 4;
            this.LabX.Text = "Введите X";
            // 
            // LabA
            // 
            this.LabA.AutoSize = true;
            this.LabA.Location = new System.Drawing.Point(350, 181);
            this.LabA.Name = "LabA";
            this.LabA.Size = new System.Drawing.Size(59, 13);
            this.LabA.TabIndex = 5;
            this.LabA.Text = "Введите A";
            // 
            // BoxN
            // 
            this.BoxN.Location = new System.Drawing.Point(350, 260);
            this.BoxN.Name = "BoxN";
            this.BoxN.Size = new System.Drawing.Size(100, 20);
            this.BoxN.TabIndex = 6;
            // 
            // LabN
            // 
            this.LabN.AutoSize = true;
            this.LabN.Location = new System.Drawing.Point(350, 244);
            this.LabN.Name = "LabN";
            this.LabN.Size = new System.Drawing.Size(86, 13);
            this.LabN.TabIndex = 7;
            this.LabN.Text = "Сколько раз (n)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 635);
            this.Controls.Add(this.LabN);
            this.Controls.Add(this.BoxN);
            this.Controls.Add(this.LabA);
            this.Controls.Add(this.LabX);
            this.Controls.Add(this.BoxX);
            this.Controls.Add(this.BoxA);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.Grid);
            this.Name = "Form1";
            this.Text = "16.5";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn Otvet;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.TextBox BoxA;
        private System.Windows.Forms.TextBox BoxX;
        private System.Windows.Forms.Label LabX;
        private System.Windows.Forms.Label LabA;
        private System.Windows.Forms.TextBox BoxN;
        private System.Windows.Forms.Label LabN;
    }
}

