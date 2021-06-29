namespace _1task
{
    partial class Proga
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
            this.Click = new System.Windows.Forms.Button();
            this.StringsAlpha = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StringsBeta = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StringsAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StringsBeta)).BeginInit();
            this.SuspendLayout();
            // 
            // Click
            // 
            this.Click.Location = new System.Drawing.Point(293, 25);
            this.Click.Name = "Click";
            this.Click.Size = new System.Drawing.Size(100, 23);
            this.Click.TabIndex = 1;
            this.Click.Text = "Отсортировать";
            this.Click.UseVisualStyleBackColor = true;
            this.Click.Click += new System.EventHandler(this.Click_Click);
            // 
            // StringsAlpha
            // 
            this.StringsAlpha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StringsAlpha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1});
            this.StringsAlpha.Location = new System.Drawing.Point(3, 54);
            this.StringsAlpha.Name = "StringsAlpha";
            this.StringsAlpha.Size = new System.Drawing.Size(343, 227);
            this.StringsAlpha.TabIndex = 3;
            // 
            // Col1
            // 
            this.Col1.HeaderText = "Введите строки:";
            this.Col1.Name = "Col1";
            this.Col1.Width = 300;
            // 
            // StringsBeta
            // 
            this.StringsBeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StringsBeta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.StringsBeta.Location = new System.Drawing.Point(343, 54);
            this.StringsBeta.Name = "StringsBeta";
            this.StringsBeta.Size = new System.Drawing.Size(343, 227);
            this.StringsBeta.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Ответ:";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // Proga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StringsBeta);
            this.Controls.Add(this.StringsAlpha);
            this.Controls.Add(this.Click);
            this.Name = "Proga";
            this.Text = "Sort string";
            ((System.ComponentModel.ISupportInitialize)(this.StringsAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StringsBeta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Click;
        private System.Windows.Forms.DataGridView StringsAlpha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridView StringsBeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
    }
}

