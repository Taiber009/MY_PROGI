namespace _17_6
{
    partial class Proga
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
            this.Vvod = new System.Windows.Forms.Button();
            this.Okno = new System.Windows.Forms.TextBox();
            this.Derevo = new System.Windows.Forms.Panel();
            this.Info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(12, 38);
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(92, 23);
            this.Vvod.TabIndex = 0;
            this.Vvod.Text = "Ввод";
            this.Vvod.UseVisualStyleBackColor = true;
            this.Vvod.Click += new System.EventHandler(this.Vvod_Click);
            // 
            // Okno
            // 
            this.Okno.Location = new System.Drawing.Point(12, 12);
            this.Okno.Name = "Okno";
            this.Okno.Size = new System.Drawing.Size(189, 20);
            this.Okno.TabIndex = 1;
            this.Okno.Text = "((T&F)|(F&T)|(T|T))&T|(F&T)";
            // 
            // Derevo
            // 
            this.Derevo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Derevo.Location = new System.Drawing.Point(12, 97);
            this.Derevo.Name = "Derevo";
            this.Derevo.Size = new System.Drawing.Size(520, 374);
            this.Derevo.TabIndex = 2;
            this.Derevo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Derevo_MouseDown);
            this.Derevo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Derevo_MouseMove);
            this.Derevo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Derevo_MouseUp);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info.Location = new System.Drawing.Point(110, 43);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(0, 22);
            this.Info.TabIndex = 4;
            // 
            // Proga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 485);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Derevo);
            this.Controls.Add(this.Okno);
            this.Controls.Add(this.Vvod);
            this.Name = "Proga";
            this.Text = "17.6";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Vvod;
        private System.Windows.Forms.TextBox Okno;
        private System.Windows.Forms.Panel Derevo;
        private System.Windows.Forms.Label Info;
    }
}

