using System.Windows.Forms;

namespace TempGraphics
{
    partial class MainForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this._ctrlBaton = new System.Windows.Forms.Button();
            this._ctrlCanvas = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // _ctrlBaton
            // 
            this._ctrlBaton.Location = new System.Drawing.Point(12, 583);
            this._ctrlBaton.Name = "_ctrlBaton";
            this._ctrlBaton.Size = new System.Drawing.Size(75, 23);
            this._ctrlBaton.TabIndex = 0;
            this._ctrlBaton.Text = "Батон";
            this._ctrlBaton.UseVisualStyleBackColor = true;
            this._ctrlBaton.Click += new System.EventHandler(this._ctrlBaton_Click);
            // 
            // _ctrlCanvas
            // 
            this._ctrlCanvas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._ctrlCanvas.Location = new System.Drawing.Point(0, 0);
            this._ctrlCanvas.Name = "_ctrlCanvas";
            this._ctrlCanvas.Size = new System.Drawing.Size(1100, 560);
            this._ctrlCanvas.TabIndex = 1;
            this._ctrlCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this._ctrlCanvas_MouseDown);
            this._ctrlCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this._ctrlCanvas_MouseMove);
            this._ctrlCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this._ctrlCanvas_MouseUp);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(137, 586);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(228, 586);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(319, 586);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(534, 566);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(541, 96);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 691);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this._ctrlCanvas);
            this.Controls.Add(this._ctrlBaton);
            this.Name = "MainForm";
            this.Text = "Херня";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



    #endregion

    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.Button _ctrlBaton;
    private System.Windows.Forms.Panel _ctrlCanvas;
    private RadioButton radioButton1;
    private RadioButton radioButton2;
    private RadioButton radioButton3;
    private RichTextBox richTextBox1;
  }
}

