namespace TPR_Ryckzack
{
    partial class f
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbMaxW = new System.Windows.Forms.TextBox();
            this.lMaxW = new System.Windows.Forms.Label();
            this.tbP = new System.Windows.Forms.TextBox();
            this.bMaxW = new System.Windows.Forms.Button();
            this.tbW = new System.Windows.Forms.TextBox();
            this.lPi = new System.Windows.Forms.Label();
            this.lWi = new System.Windows.Forms.Label();
            this.bNew = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.bDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.price,
            this.weight});
            this.dgv.Location = new System.Drawing.Point(12, 9);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 5;
            this.dgv.Size = new System.Drawing.Size(207, 298);
            this.dgv.TabIndex = 0;
            // 
            // index
            // 
            this.index.HeaderText = "i";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Width = 50;
            // 
            // price
            // 
            this.price.HeaderText = "pi";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 75;
            // 
            // weight
            // 
            this.weight.HeaderText = "wi";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            this.weight.Width = 75;
            // 
            // tbMaxW
            // 
            this.tbMaxW.Location = new System.Drawing.Point(225, 64);
            this.tbMaxW.Name = "tbMaxW";
            this.tbMaxW.Size = new System.Drawing.Size(62, 20);
            this.tbMaxW.TabIndex = 1;
            // 
            // lMaxW
            // 
            this.lMaxW.AutoSize = true;
            this.lMaxW.Location = new System.Drawing.Point(225, 48);
            this.lMaxW.Name = "lMaxW";
            this.lMaxW.Size = new System.Drawing.Size(107, 13);
            this.lMaxW.TabIndex = 2;
            this.lMaxW.Text = "Максимальный вес";
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(228, 25);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(100, 20);
            this.tbP.TabIndex = 3;
            // 
            // bMaxW
            // 
            this.bMaxW.Location = new System.Drawing.Point(293, 61);
            this.bMaxW.Name = "bMaxW";
            this.bMaxW.Size = new System.Drawing.Size(75, 23);
            this.bMaxW.TabIndex = 4;
            this.bMaxW.Text = "Задать";
            this.bMaxW.UseVisualStyleBackColor = true;
            this.bMaxW.Click += new System.EventHandler(this.bMaxW_Click);
            // 
            // tbW
            // 
            this.tbW.Location = new System.Drawing.Point(334, 25);
            this.tbW.Name = "tbW";
            this.tbW.Size = new System.Drawing.Size(100, 20);
            this.tbW.TabIndex = 5;
            // 
            // lPi
            // 
            this.lPi.AutoSize = true;
            this.lPi.Location = new System.Drawing.Point(225, 9);
            this.lPi.Name = "lPi";
            this.lPi.Size = new System.Drawing.Size(62, 13);
            this.lPi.TabIndex = 7;
            this.lPi.Text = "Стоимость";
            // 
            // lWi
            // 
            this.lWi.AutoSize = true;
            this.lWi.Location = new System.Drawing.Point(331, 9);
            this.lWi.Name = "lWi";
            this.lWi.Size = new System.Drawing.Size(26, 13);
            this.lWi.TabIndex = 8;
            this.lWi.Text = "Вес";
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(440, 25);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(110, 23);
            this.bNew.TabIndex = 10;
            this.bNew.Text = "Новый предмет";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(391, 61);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(78, 23);
            this.bStart.TabIndex = 12;
            this.bStart.Text = "Рассчитать";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // tbInfo
            // 
            this.tbInfo.Enabled = false;
            this.tbInfo.Location = new System.Drawing.Point(225, 90);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.Size = new System.Drawing.Size(325, 217);
            this.tbInfo.TabIndex = 13;
            // 
            // bDel
            // 
            this.bDel.Location = new System.Drawing.Point(475, 61);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(75, 23);
            this.bDel.TabIndex = 14;
            this.bDel.Text = "Очистить";
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // f
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 321);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.lWi);
            this.Controls.Add(this.lPi);
            this.Controls.Add(this.tbW);
            this.Controls.Add(this.bMaxW);
            this.Controls.Add(this.tbP);
            this.Controls.Add(this.lMaxW);
            this.Controls.Add(this.tbMaxW);
            this.Controls.Add(this.dgv);
            this.Name = "f";
            this.Text = "`";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tbMaxW;
        private System.Windows.Forms.Label lMaxW;
        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.Button bMaxW;
        private System.Windows.Forms.TextBox tbW;
        private System.Windows.Forms.Label lPi;
        private System.Windows.Forms.Label lWi;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.Button bDel;
    }
}

