namespace Лифт_2_
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
            this.components = new System.ComponentModel.Container();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Go = new System.Windows.Forms.Button();
            this.Ti = new System.Windows.Forms.Timer(this.components);
            this.Time = new System.Windows.Forms.Label();
            this.Box = new System.Windows.Forms.TextBox();
            this.Box2 = new System.Windows.Forms.TextBox();
            this.info1 = new System.Windows.Forms.Label();
            this.info2 = new System.Windows.Forms.Label();
            this.Track = new System.Windows.Forms.TrackBar();
            this.info3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToResizeColumns = false;
            this.Grid.AllowUserToResizeRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(82, 59);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersVisible = false;
            this.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid.Size = new System.Drawing.Size(633, 429);
            this.Grid.TabIndex = 2;
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(12, 12);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(64, 23);
            this.Go.TabIndex = 1;
            this.Go.Text = "Start";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // Ti
            // 
            this.Ti.Tick += new System.EventHandler(this.Ti_Tick_1);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(13, 86);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(13, 13);
            this.Time.TabIndex = 3;
            this.Time.Text = "0";
            this.Time.Visible = false;
            // 
            // Box
            // 
            this.Box.Location = new System.Drawing.Point(54, 38);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(19, 20);
            this.Box.TabIndex = 4;
            this.Box.Text = "16";
            // 
            // Box2
            // 
            this.Box2.Location = new System.Drawing.Point(54, 59);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(19, 20);
            this.Box2.TabIndex = 5;
            this.Box2.Text = "20";
            // 
            // info1
            // 
            this.info1.AutoSize = true;
            this.info1.Location = new System.Drawing.Point(13, 41);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(39, 13);
            this.info1.TabIndex = 6;
            this.info1.Text = "Этажи";
            // 
            // info2
            // 
            this.info2.AutoSize = true;
            this.info2.Location = new System.Drawing.Point(13, 62);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(35, 13);
            this.info2.TabIndex = 7;
            this.info2.Text = "Люди";
            // 
            // Track
            // 
            this.Track.Location = new System.Drawing.Point(82, 494);
            this.Track.Maximum = 20;
            this.Track.Name = "Track";
            this.Track.Size = new System.Drawing.Size(179, 42);
            this.Track.TabIndex = 8;
            this.Track.Visible = false;
            this.Track.ValueChanged += new System.EventHandler(this.Track_ValueChanged);
            // 
            // info3
            // 
            this.info3.AutoSize = true;
            this.info3.Location = new System.Drawing.Point(267, 494);
            this.info3.Name = "info3";
            this.info3.Size = new System.Drawing.Size(0, 13);
            this.info3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(240, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 50);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lift Simulator 2017";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 575);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.info3);
            this.Controls.Add(this.Track);
            this.Controls.Add(this.info2);
            this.Controls.Add(this.info1);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.Go);
            this.Name = "Form1";
            this.Text = "Лифт";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.TextBox Box;
        public System.Windows.Forms.Timer Ti;
        private System.Windows.Forms.TextBox Box2;
        private System.Windows.Forms.Label info1;
        private System.Windows.Forms.Label info2;
        private System.Windows.Forms.TrackBar Track;
        private System.Windows.Forms.Label info3;
        private System.Windows.Forms.Label label1;
    }
}

