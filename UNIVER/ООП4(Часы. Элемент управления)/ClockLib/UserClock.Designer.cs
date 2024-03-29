﻿namespace ClockLib
{
    partial class UserClock
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DrawClock = new System.Windows.Forms.Panel();
            this.ClockButton = new System.Windows.Forms.Button();
            this.DefTimer = new System.Windows.Forms.Timer(this.components);
            this.TimeZones = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DrawClock
            // 
            this.DrawClock.BackColor = System.Drawing.Color.SkyBlue;
            this.DrawClock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawClock.Location = new System.Drawing.Point(0, 23);
            this.DrawClock.Name = "DrawClock";
            this.DrawClock.Size = new System.Drawing.Size(456, 347);
            this.DrawClock.TabIndex = 25;
            // 
            // ClockButton
            // 
            this.ClockButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClockButton.Location = new System.Drawing.Point(0, 0);
            this.ClockButton.Name = "ClockButton";
            this.ClockButton.Size = new System.Drawing.Size(456, 23);
            this.ClockButton.TabIndex = 24;
            this.ClockButton.Text = "Смена часов";
            this.ClockButton.UseVisualStyleBackColor = true;
            this.ClockButton.Click += new System.EventHandler(this.ClockButton_Click);
            // 
            // DefTimer
            // 
            this.DefTimer.Tick += new System.EventHandler(this.DefTimer_Tick);
            // 
            // TimeZones
            // 
            this.TimeZones.Dock = System.Windows.Forms.DockStyle.Right;
            this.TimeZones.FormattingEnabled = true;
            this.TimeZones.Location = new System.Drawing.Point(238, 23);
            this.TimeZones.Name = "TimeZones";
            this.TimeZones.Size = new System.Drawing.Size(218, 347);
            this.TimeZones.TabIndex = 0;
            // 
            // UserClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TimeZones);
            this.Controls.Add(this.DrawClock);
            this.Controls.Add(this.ClockButton);
            this.Name = "UserClock";
            this.Size = new System.Drawing.Size(456, 370);
            this.Load += new System.EventHandler(this.UserClock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DrawClock;
        private System.Windows.Forms.Button ClockButton;
        private System.Windows.Forms.Timer DefTimer;
        private System.Windows.Forms.ListBox TimeZones;

    }
}
