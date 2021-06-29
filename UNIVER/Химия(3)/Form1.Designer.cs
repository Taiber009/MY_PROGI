namespace Химия_3_
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
            this.Mol1Text = new System.Windows.Forms.Label();
            this.PlusText = new System.Windows.Forms.Label();
            this.Mol2Text = new System.Windows.Forms.Label();
            this.EquallyText = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.Mol1Check = new System.Windows.Forms.RadioButton();
            this.Mol2Check = new System.Windows.Forms.RadioButton();
            this.Start = new System.Windows.Forms.Button();
            this.AtomsBox = new System.Windows.Forms.ListBox();
            this.AddAtoms = new System.Windows.Forms.Button();
            this.Box1 = new System.Windows.Forms.TextBox();
            this.ProBox = new System.Windows.Forms.TextBox();
            this.AddMol = new System.Windows.Forms.Button();
            this.IonName = new System.Windows.Forms.Label();
            this.ProInfo = new System.Windows.Forms.Label();
            this.Fast = new System.Windows.Forms.Button();
            this.ProPlus = new System.Windows.Forms.Button();
            this.ProMinus = new System.Windows.Forms.Button();
            this.ElecMinus = new System.Windows.Forms.Button();
            this.ElecPlus = new System.Windows.Forms.Button();
            this.ElecInfo = new System.Windows.Forms.Label();
            this.ElecBox = new System.Windows.Forms.TextBox();
            this.NeutMinus = new System.Windows.Forms.Button();
            this.NeutPlus = new System.Windows.Forms.Button();
            this.NeutInfo = new System.Windows.Forms.Label();
            this.NeutBox = new System.Windows.Forms.TextBox();
            this.AddIons = new System.Windows.Forms.Button();
            this.IonsBox = new System.Windows.Forms.ListBox();
            this.NewIon = new System.Windows.Forms.TextBox();
            this.MySave = new System.Windows.Forms.Button();
            this.MyLoad = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.Delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mol1Text
            // 
            this.Mol1Text.AutoSize = true;
            this.Mol1Text.Location = new System.Drawing.Point(709, 38);
            this.Mol1Text.Name = "Mol1Text";
            this.Mol1Text.Size = new System.Drawing.Size(10, 13);
            this.Mol1Text.TabIndex = 0;
            this.Mol1Text.Text = ".";
            // 
            // PlusText
            // 
            this.PlusText.AutoSize = true;
            this.PlusText.Location = new System.Drawing.Point(710, 63);
            this.PlusText.Name = "PlusText";
            this.PlusText.Size = new System.Drawing.Size(13, 13);
            this.PlusText.TabIndex = 11;
            this.PlusText.Text = "+";
            // 
            // Mol2Text
            // 
            this.Mol2Text.AutoSize = true;
            this.Mol2Text.Location = new System.Drawing.Point(709, 88);
            this.Mol2Text.Name = "Mol2Text";
            this.Mol2Text.Size = new System.Drawing.Size(10, 13);
            this.Mol2Text.TabIndex = 12;
            this.Mol2Text.Text = ".";
            // 
            // EquallyText
            // 
            this.EquallyText.AutoSize = true;
            this.EquallyText.Location = new System.Drawing.Point(709, 113);
            this.EquallyText.Name = "EquallyText";
            this.EquallyText.Size = new System.Drawing.Size(13, 13);
            this.EquallyText.TabIndex = 13;
            this.EquallyText.Text = "=";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(709, 138);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(10, 13);
            this.Result.TabIndex = 14;
            this.Result.Text = ".";
            // 
            // Mol1Check
            // 
            this.Mol1Check.AutoSize = true;
            this.Mol1Check.Checked = true;
            this.Mol1Check.Location = new System.Drawing.Point(646, 38);
            this.Mol1Check.Name = "Mol1Check";
            this.Mol1Check.Size = new System.Drawing.Size(48, 17);
            this.Mol1Check.TabIndex = 15;
            this.Mol1Check.TabStop = true;
            this.Mol1Check.Text = "Mol1";
            this.Mol1Check.UseVisualStyleBackColor = true;
            this.Mol1Check.CheckedChanged += new System.EventHandler(this.FP_CheckedChanged);
            // 
            // Mol2Check
            // 
            this.Mol2Check.AutoSize = true;
            this.Mol2Check.Location = new System.Drawing.Point(646, 88);
            this.Mol2Check.Name = "Mol2Check";
            this.Mol2Check.Size = new System.Drawing.Size(48, 17);
            this.Mol2Check.TabIndex = 17;
            this.Mol2Check.Text = "Mol2";
            this.Mol2Check.UseVisualStyleBackColor = true;
            this.Mol2Check.CheckedChanged += new System.EventHandler(this.SP_CheckedChanged);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(752, 108);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(44, 23);
            this.Start.TabIndex = 19;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // AtomsBox
            // 
            this.AtomsBox.FormattingEnabled = true;
            this.AtomsBox.Location = new System.Drawing.Point(110, 38);
            this.AtomsBox.Name = "AtomsBox";
            this.AtomsBox.Size = new System.Drawing.Size(269, 251);
            this.AtomsBox.TabIndex = 20;
            // 
            // AddAtoms
            // 
            this.AddAtoms.Location = new System.Drawing.Point(110, 7);
            this.AddAtoms.Name = "AddAtoms";
            this.AddAtoms.Size = new System.Drawing.Size(269, 23);
            this.AddAtoms.TabIndex = 22;
            this.AddAtoms.Text = "Add new atom";
            this.AddAtoms.UseVisualStyleBackColor = true;
            this.AddAtoms.Click += new System.EventHandler(this.AddAtoms_Click);
            // 
            // Box1
            // 
            this.Box1.Location = new System.Drawing.Point(55, 9);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(49, 20);
            this.Box1.TabIndex = 23;
            // 
            // ProBox
            // 
            this.ProBox.Location = new System.Drawing.Point(60, 67);
            this.ProBox.Name = "ProBox";
            this.ProBox.ReadOnly = true;
            this.ProBox.Size = new System.Drawing.Size(29, 20);
            this.ProBox.TabIndex = 24;
            this.ProBox.Text = "0";
            // 
            // AddMol
            // 
            this.AddMol.Location = new System.Drawing.Point(646, 7);
            this.AddMol.Name = "AddMol";
            this.AddMol.Size = new System.Drawing.Size(150, 23);
            this.AddMol.TabIndex = 27;
            this.AddMol.Text = "Add selected ion in molecula";
            this.AddMol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddMol.UseVisualStyleBackColor = true;
            this.AddMol.Click += new System.EventHandler(this.AddMol_Click);
            // 
            // IonName
            // 
            this.IonName.AutoSize = true;
            this.IonName.Location = new System.Drawing.Point(14, 12);
            this.IonName.Name = "IonName";
            this.IonName.Size = new System.Drawing.Size(38, 13);
            this.IonName.TabIndex = 29;
            this.IonName.Text = "Name:";
            // 
            // ProInfo
            // 
            this.ProInfo.AutoSize = true;
            this.ProInfo.Location = new System.Drawing.Point(6, 70);
            this.ProInfo.Name = "ProInfo";
            this.ProInfo.Size = new System.Drawing.Size(46, 13);
            this.ProInfo.TabIndex = 30;
            this.ProInfo.Text = "Protons:";
            // 
            // Fast
            // 
            this.Fast.Location = new System.Drawing.Point(9, 103);
            this.Fast.Name = "Fast";
            this.Fast.Size = new System.Drawing.Size(43, 23);
            this.Fast.TabIndex = 32;
            this.Fast.Text = "FAST";
            this.Fast.UseVisualStyleBackColor = true;
            this.Fast.Click += new System.EventHandler(this.Fast_Click);
            // 
            // ProPlus
            // 
            this.ProPlus.Location = new System.Drawing.Point(60, 38);
            this.ProPlus.Name = "ProPlus";
            this.ProPlus.Size = new System.Drawing.Size(29, 23);
            this.ProPlus.TabIndex = 33;
            this.ProPlus.Text = "+";
            this.ProPlus.UseVisualStyleBackColor = true;
            this.ProPlus.Click += new System.EventHandler(this.ProPlus_Click);
            // 
            // ProMinus
            // 
            this.ProMinus.Location = new System.Drawing.Point(60, 93);
            this.ProMinus.Name = "ProMinus";
            this.ProMinus.Size = new System.Drawing.Size(29, 23);
            this.ProMinus.TabIndex = 34;
            this.ProMinus.Text = "-";
            this.ProMinus.UseVisualStyleBackColor = true;
            this.ProMinus.Click += new System.EventHandler(this.ProMinus_Click);
            // 
            // ElecMinus
            // 
            this.ElecMinus.Location = new System.Drawing.Point(60, 180);
            this.ElecMinus.Name = "ElecMinus";
            this.ElecMinus.Size = new System.Drawing.Size(29, 23);
            this.ElecMinus.TabIndex = 38;
            this.ElecMinus.Text = "-";
            this.ElecMinus.UseVisualStyleBackColor = true;
            this.ElecMinus.Click += new System.EventHandler(this.ElecMinus_Click);
            // 
            // ElecPlus
            // 
            this.ElecPlus.Location = new System.Drawing.Point(60, 125);
            this.ElecPlus.Name = "ElecPlus";
            this.ElecPlus.Size = new System.Drawing.Size(29, 23);
            this.ElecPlus.TabIndex = 37;
            this.ElecPlus.Text = "+";
            this.ElecPlus.UseVisualStyleBackColor = true;
            this.ElecPlus.Click += new System.EventHandler(this.ElecPlus_Click);
            // 
            // ElecInfo
            // 
            this.ElecInfo.AutoSize = true;
            this.ElecInfo.Location = new System.Drawing.Point(-2, 157);
            this.ElecInfo.Name = "ElecInfo";
            this.ElecInfo.Size = new System.Drawing.Size(54, 13);
            this.ElecInfo.TabIndex = 36;
            this.ElecInfo.Text = "Electrons:";
            // 
            // ElecBox
            // 
            this.ElecBox.Location = new System.Drawing.Point(60, 154);
            this.ElecBox.Name = "ElecBox";
            this.ElecBox.ReadOnly = true;
            this.ElecBox.Size = new System.Drawing.Size(29, 20);
            this.ElecBox.TabIndex = 35;
            this.ElecBox.Text = "0";
            // 
            // NeutMinus
            // 
            this.NeutMinus.Location = new System.Drawing.Point(60, 267);
            this.NeutMinus.Name = "NeutMinus";
            this.NeutMinus.Size = new System.Drawing.Size(29, 23);
            this.NeutMinus.TabIndex = 42;
            this.NeutMinus.Text = "-";
            this.NeutMinus.UseVisualStyleBackColor = true;
            this.NeutMinus.Click += new System.EventHandler(this.NeutMinus_Click);
            // 
            // NeutPlus
            // 
            this.NeutPlus.Location = new System.Drawing.Point(60, 212);
            this.NeutPlus.Name = "NeutPlus";
            this.NeutPlus.Size = new System.Drawing.Size(29, 23);
            this.NeutPlus.TabIndex = 41;
            this.NeutPlus.Text = "+";
            this.NeutPlus.UseVisualStyleBackColor = true;
            this.NeutPlus.Click += new System.EventHandler(this.NeutPlus_Click);
            // 
            // NeutInfo
            // 
            this.NeutInfo.AutoSize = true;
            this.NeutInfo.Location = new System.Drawing.Point(6, 244);
            this.NeutInfo.Name = "NeutInfo";
            this.NeutInfo.Size = new System.Drawing.Size(53, 13);
            this.NeutInfo.TabIndex = 40;
            this.NeutInfo.Text = "Neutrons:";
            // 
            // NeutBox
            // 
            this.NeutBox.Location = new System.Drawing.Point(60, 241);
            this.NeutBox.Name = "NeutBox";
            this.NeutBox.ReadOnly = true;
            this.NeutBox.Size = new System.Drawing.Size(29, 20);
            this.NeutBox.TabIndex = 39;
            this.NeutBox.Text = "0";
            // 
            // AddIons
            // 
            this.AddIons.Location = new System.Drawing.Point(385, 32);
            this.AddIons.Name = "AddIons";
            this.AddIons.Size = new System.Drawing.Size(255, 23);
            this.AddIons.TabIndex = 44;
            this.AddIons.Text = "Add new ion";
            this.AddIons.UseVisualStyleBackColor = true;
            this.AddIons.Click += new System.EventHandler(this.AddIons_Click);
            // 
            // IonsBox
            // 
            this.IonsBox.FormattingEnabled = true;
            this.IonsBox.Location = new System.Drawing.Point(385, 61);
            this.IonsBox.Name = "IonsBox";
            this.IonsBox.Size = new System.Drawing.Size(255, 225);
            this.IonsBox.TabIndex = 43;
            // 
            // NewIon
            // 
            this.NewIon.Location = new System.Drawing.Point(385, 7);
            this.NewIon.Name = "NewIon";
            this.NewIon.Size = new System.Drawing.Size(255, 20);
            this.NewIon.TabIndex = 45;
            // 
            // MySave
            // 
            this.MySave.Location = new System.Drawing.Point(9, 321);
            this.MySave.Name = "MySave";
            this.MySave.Size = new System.Drawing.Size(95, 23);
            this.MySave.TabIndex = 46;
            this.MySave.Text = "MySave";
            this.MySave.UseVisualStyleBackColor = true;
            this.MySave.Click += new System.EventHandler(this.MySave_Click);
            // 
            // MyLoad
            // 
            this.MyLoad.Location = new System.Drawing.Point(9, 350);
            this.MyLoad.Name = "MyLoad";
            this.MyLoad.Size = new System.Drawing.Size(95, 23);
            this.MyLoad.TabIndex = 47;
            this.MyLoad.Text = "MyLoad";
            this.MyLoad.UseVisualStyleBackColor = true;
            this.MyLoad.Click += new System.EventHandler(this.MyLoad_Click);
            // 
            // OFD
            // 
            this.OFD.Filter = "txt files (*.txt)|*.txt";
            this.OFD.InitialDirectory = "c:\\\\";
            this.OFD.FileOk += new System.ComponentModel.CancelEventHandler(this.OFD_FileOk);
            // 
            // SFD
            // 
            this.SFD.FileName = "Save";
            this.SFD.FileOk += new System.ComponentModel.CancelEventHandler(this.SFD_FileOk);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(802, 7);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(150, 23);
            this.Delete.TabIndex = 48;
            this.Delete.Text = "Delete selected molecula";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 50;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1, 454);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 51;
            this.button3.Text = "Pause";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Proga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 479);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.MyLoad);
            this.Controls.Add(this.MySave);
            this.Controls.Add(this.NewIon);
            this.Controls.Add(this.AddIons);
            this.Controls.Add(this.IonsBox);
            this.Controls.Add(this.NeutMinus);
            this.Controls.Add(this.NeutPlus);
            this.Controls.Add(this.NeutInfo);
            this.Controls.Add(this.NeutBox);
            this.Controls.Add(this.ElecMinus);
            this.Controls.Add(this.ElecPlus);
            this.Controls.Add(this.ElecInfo);
            this.Controls.Add(this.ElecBox);
            this.Controls.Add(this.ProMinus);
            this.Controls.Add(this.ProPlus);
            this.Controls.Add(this.Fast);
            this.Controls.Add(this.ProInfo);
            this.Controls.Add(this.IonName);
            this.Controls.Add(this.AddMol);
            this.Controls.Add(this.ProBox);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.AddAtoms);
            this.Controls.Add(this.AtomsBox);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Mol2Check);
            this.Controls.Add(this.Mol1Check);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.EquallyText);
            this.Controls.Add(this.Mol2Text);
            this.Controls.Add(this.PlusText);
            this.Controls.Add(this.Mol1Text);
            this.Name = "Proga";
            this.Text = "Химия(3)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mol1Text;
        private System.Windows.Forms.Label PlusText;
        private System.Windows.Forms.Label Mol2Text;
        private System.Windows.Forms.Label EquallyText;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.RadioButton Mol1Check;
        private System.Windows.Forms.RadioButton Mol2Check;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.ListBox AtomsBox;
        private System.Windows.Forms.Button AddAtoms;
        private System.Windows.Forms.TextBox Box1;
        private System.Windows.Forms.TextBox ProBox;
        private System.Windows.Forms.Button AddMol;
        private System.Windows.Forms.Label IonName;
        private System.Windows.Forms.Label ProInfo;
        private System.Windows.Forms.Button Fast;
        private System.Windows.Forms.Button ProPlus;
        private System.Windows.Forms.Button ProMinus;
        private System.Windows.Forms.Button ElecMinus;
        private System.Windows.Forms.Button ElecPlus;
        private System.Windows.Forms.Label ElecInfo;
        private System.Windows.Forms.TextBox ElecBox;
        private System.Windows.Forms.Button NeutMinus;
        private System.Windows.Forms.Button NeutPlus;
        private System.Windows.Forms.Label NeutInfo;
        private System.Windows.Forms.TextBox NeutBox;
        private System.Windows.Forms.Button AddIons;
        private System.Windows.Forms.ListBox IonsBox;
        private System.Windows.Forms.TextBox NewIon;
        private System.Windows.Forms.Button MySave;
        private System.Windows.Forms.Button MyLoad;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

