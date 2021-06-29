namespace _9._17
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
            this.Vvod = new System.Windows.Forms.Button();
            this.Okno1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Okno2 = new System.Windows.Forms.TextBox();
            this.Info3 = new System.Windows.Forms.Label();
            this.Check1 = new System.Windows.Forms.RadioButton();
            this.Check2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(12, 217);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(75, 23);
            this.Vvod.TabIndex = 0;
            this.Vvod.Text = "Ввод";
            this.Vvod.UseVisualStyleBackColor = true;
            this.Vvod.Click += new System.EventHandler(this.Vvod_Click);
            // 
            // Okno1
            // 
            this.Okno1.Location = new System.Drawing.Point(12, 28);
            this.Okno1.Name = "Okno1";
            this.Okno1.Size = new System.Drawing.Size(75, 20);
            this.Okno1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите n:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Массив nxn:";
            // 
            // Okno2
            // 
            this.Okno2.Location = new System.Drawing.Point(140, 28);
            this.Okno2.Multiline = true;
            this.Okno2.Name = "Okno2";
            this.Okno2.Size = new System.Drawing.Size(258, 212);
            this.Okno2.TabIndex = 4;
            // 
            // Info3
            // 
            this.Info3.AutoSize = true;
            this.Info3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info3.Location = new System.Drawing.Point(9, 173);
            this.Info3.Name = "Info3";
            this.Info3.Size = new System.Drawing.Size(56, 17);
            this.Info3.TabIndex = 5;
            this.Info3.Text = "Ответ: ";
            // 
            // Check1
            // 
            this.Check1.AutoSize = true;
            this.Check1.Location = new System.Drawing.Point(12, 54);
            this.Check1.Name = "Check1";
            this.Check1.Size = new System.Drawing.Size(46, 17);
            this.Check1.TabIndex = 6;
            this.Check1.TabStop = true;
            this.Check1.Text = "9.17";
            this.Check1.UseVisualStyleBackColor = true;
            // 
            // Check2
            // 
            this.Check2.AutoSize = true;
            this.Check2.Location = new System.Drawing.Point(12, 77);
            this.Check2.Name = "Check2";
            this.Check2.Size = new System.Drawing.Size(46, 17);
            this.Check2.TabIndex = 7;
            this.Check2.TabStop = true;
            this.Check2.Text = "9.32";
            this.Check2.UseVisualStyleBackColor = true;
            // 
            // Proga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 254);
            this.Controls.Add(this.Check2);
            this.Controls.Add(this.Check1);
            this.Controls.Add(this.Info3);
            this.Controls.Add(this.Okno2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Okno1);
            this.Controls.Add(this.Vvod);
            this.Name = "Proga";
            this.Text = "9.17+9.32";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Vvod;
        private System.Windows.Forms.TextBox Okno1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Okno2;
        private System.Windows.Forms.Label Info3;
        private System.Windows.Forms.RadioButton Check1;
        private System.Windows.Forms.RadioButton Check2;
    }
}

