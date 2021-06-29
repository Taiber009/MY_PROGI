namespace MultiTextTools
{
    partial class f
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f));
            this.bGo = new System.Windows.Forms.Button();
            this.lbModules = new System.Windows.Forms.ListBox();
            this.tb1 = new System.Windows.Forms.RichTextBox();
            this.tb2 = new System.Windows.Forms.RichTextBox();
            this.l0 = new System.Windows.Forms.Label();
            this.tbTip = new System.Windows.Forms.RichTextBox();
            this.bInsert = new System.Windows.Forms.Button();
            this.bReload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bGo
            // 
            this.bGo.Location = new System.Drawing.Point(218, 191);
            this.bGo.Name = "bGo";
            this.bGo.Size = new System.Drawing.Size(75, 23);
            this.bGo.TabIndex = 0;
            this.bGo.Text = "Применить";
            this.bGo.UseVisualStyleBackColor = true;
            this.bGo.Click += new System.EventHandler(this.bGo_Click);
            // 
            // lbModules
            // 
            this.lbModules.FormattingEnabled = true;
            this.lbModules.Location = new System.Drawing.Point(505, 12);
            this.lbModules.Name = "lbModules";
            this.lbModules.Size = new System.Drawing.Size(200, 303);
            this.lbModules.TabIndex = 3;
            this.lbModules.SelectedIndexChanged += new System.EventHandler(this.lbModules_SelectedIndexChanged);
            // 
            // tb1
            // 
            this.tb1.DetectUrls = false;
            this.tb1.Location = new System.Drawing.Point(12, 12);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(200, 329);
            this.tb1.TabIndex = 4;
            this.tb1.Text = "";
            // 
            // tb2
            // 
            this.tb2.DetectUrls = false;
            this.tb2.Location = new System.Drawing.Point(299, 12);
            this.tb2.Name = "tb2";
            this.tb2.ReadOnly = true;
            this.tb2.Size = new System.Drawing.Size(200, 329);
            this.tb2.TabIndex = 5;
            this.tb2.Text = "";
            // 
            // l0
            // 
            this.l0.AutoSize = true;
            this.l0.Location = new System.Drawing.Point(711, 12);
            this.l0.Name = "l0";
            this.l0.Size = new System.Drawing.Size(60, 13);
            this.l0.TabIndex = 6;
            this.l0.Text = "Описание:";
            // 
            // tbTip
            // 
            this.tbTip.Location = new System.Drawing.Point(711, 28);
            this.tbTip.Name = "tbTip";
            this.tbTip.ReadOnly = true;
            this.tbTip.Size = new System.Drawing.Size(200, 313);
            this.tbTip.TabIndex = 7;
            this.tbTip.Text = "";
            // 
            // bInsert
            // 
            this.bInsert.Location = new System.Drawing.Point(218, 162);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(75, 23);
            this.bInsert.TabIndex = 8;
            this.bInsert.Text = "<<<";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // bReload
            // 
            this.bReload.Location = new System.Drawing.Point(505, 318);
            this.bReload.Name = "bReload";
            this.bReload.Size = new System.Drawing.Size(200, 23);
            this.bReload.TabIndex = 9;
            this.bReload.Text = "Обновить";
            this.bReload.UseVisualStyleBackColor = true;
            this.bReload.Click += new System.EventHandler(this.bReload_Click);
            // 
            // f
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(958, 382);
            this.Controls.Add(this.bReload);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.tbTip);
            this.Controls.Add(this.l0);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lbModules);
            this.Controls.Add(this.bGo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f";
            this.Text = "MultiTextTools (by Khoziev)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bGo;
        private System.Windows.Forms.ListBox lbModules;
        private System.Windows.Forms.RichTextBox tb2;
        private System.Windows.Forms.Label l0;
        private System.Windows.Forms.RichTextBox tbTip;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.RichTextBox tb1;
        private System.Windows.Forms.Button bReload;
    }
}

