namespace ООП3__Часы_с_паттернами_
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
            this.components = new System.ComponentModel.Container();
            this.DefTimer = new System.Windows.Forms.Timer(this.components);
            this.ClockButton = new System.Windows.Forms.Button();
            this.TimerButton = new System.Windows.Forms.Button();
            this.MyTimerLabel = new System.Windows.Forms.Label();
            this.ChangeMultiplierButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.TimerStopList = new System.Windows.Forms.ListBox();
            this.KrygButton = new System.Windows.Forms.Button();
            this.AlarmList = new System.Windows.Forms.ListBox();
            this.AddAlarmButton = new System.Windows.Forms.Button();
            this.DelAlarmButton = new System.Windows.Forms.Button();
            this.HoursText = new System.Windows.Forms.TextBox();
            this.MinutesText = new System.Windows.Forms.TextBox();
            this.MinusButton1 = new System.Windows.Forms.Button();
            this.MinusButton2 = new System.Windows.Forms.Button();
            this.PlusButton1 = new System.Windows.Forms.Button();
            this.PlusButton2 = new System.Windows.Forms.Button();
            this.Dots = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DrawClock = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // DefTimer
            // 
            this.DefTimer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ClockButton
            // 
            this.ClockButton.Location = new System.Drawing.Point(340, 8);
            this.ClockButton.Name = "ClockButton";
            this.ClockButton.Size = new System.Drawing.Size(120, 23);
            this.ClockButton.TabIndex = 1;
            this.ClockButton.Text = "Смена часов";
            this.ClockButton.UseVisualStyleBackColor = true;
            this.ClockButton.Click += new System.EventHandler(this.ClockButton_Click);
            // 
            // TimerButton
            // 
            this.TimerButton.Location = new System.Drawing.Point(466, 8);
            this.TimerButton.Name = "TimerButton";
            this.TimerButton.Size = new System.Drawing.Size(146, 23);
            this.TimerButton.TabIndex = 2;
            this.TimerButton.Text = "Старт секундомера";
            this.TimerButton.UseVisualStyleBackColor = true;
            this.TimerButton.Click += new System.EventHandler(this.TimerButton_Click);
            // 
            // MyTimerLabel
            // 
            this.MyTimerLabel.AutoSize = true;
            this.MyTimerLabel.Enabled = false;
            this.MyTimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyTimerLabel.Location = new System.Drawing.Point(510, 87);
            this.MyTimerLabel.Name = "MyTimerLabel";
            this.MyTimerLabel.Size = new System.Drawing.Size(102, 20);
            this.MyTimerLabel.TabIndex = 4;
            this.MyTimerLabel.Text = "Секундомер";
            this.MyTimerLabel.Visible = false;
            // 
            // ChangeMultiplierButton
            // 
            this.ChangeMultiplierButton.Location = new System.Drawing.Point(544, 37);
            this.ChangeMultiplierButton.Name = "ChangeMultiplierButton";
            this.ChangeMultiplierButton.Size = new System.Drawing.Size(66, 23);
            this.ChangeMultiplierButton.TabIndex = 5;
            this.ChangeMultiplierButton.Text = "Назад";
            this.ChangeMultiplierButton.UseVisualStyleBackColor = true;
            this.ChangeMultiplierButton.Visible = false;
            this.ChangeMultiplierButton.Click += new System.EventHandler(this.ChangeMultiplier_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(466, 37);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(72, 23);
            this.PauseButton.TabIndex = 6;
            this.PauseButton.Text = "Пауза";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Visible = false;
            this.PauseButton.Click += new System.EventHandler(this.Pause_Click);
            // 
            // TimerStopList
            // 
            this.TimerStopList.FormattingEnabled = true;
            this.TimerStopList.Location = new System.Drawing.Point(475, 180);
            this.TimerStopList.Name = "TimerStopList";
            this.TimerStopList.Size = new System.Drawing.Size(144, 147);
            this.TimerStopList.TabIndex = 7;
            this.TimerStopList.Visible = false;
            // 
            // KrygButton
            // 
            this.KrygButton.Location = new System.Drawing.Point(475, 148);
            this.KrygButton.Name = "KrygButton";
            this.KrygButton.Size = new System.Drawing.Size(144, 23);
            this.KrygButton.TabIndex = 8;
            this.KrygButton.Text = "Круг";
            this.KrygButton.UseVisualStyleBackColor = true;
            this.KrygButton.Visible = false;
            this.KrygButton.Click += new System.EventHandler(this.KrygButton_Click);
            // 
            // AlarmList
            // 
            this.AlarmList.FormattingEnabled = true;
            this.AlarmList.Location = new System.Drawing.Point(340, 179);
            this.AlarmList.Name = "AlarmList";
            this.AlarmList.Size = new System.Drawing.Size(120, 147);
            this.AlarmList.TabIndex = 9;
            // 
            // AddAlarmButton
            // 
            this.AddAlarmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAlarmButton.Location = new System.Drawing.Point(340, 148);
            this.AddAlarmButton.Name = "AddAlarmButton";
            this.AddAlarmButton.Size = new System.Drawing.Size(51, 23);
            this.AddAlarmButton.TabIndex = 10;
            this.AddAlarmButton.Text = "Add";
            this.AddAlarmButton.UseVisualStyleBackColor = true;
            this.AddAlarmButton.Click += new System.EventHandler(this.AddAlarmButton_Click);
            // 
            // DelAlarmButton
            // 
            this.DelAlarmButton.Location = new System.Drawing.Point(407, 148);
            this.DelAlarmButton.Name = "DelAlarmButton";
            this.DelAlarmButton.Size = new System.Drawing.Size(53, 23);
            this.DelAlarmButton.TabIndex = 11;
            this.DelAlarmButton.Text = "Del";
            this.DelAlarmButton.UseVisualStyleBackColor = true;
            this.DelAlarmButton.Click += new System.EventHandler(this.DelAlarmButton_Click);
            // 
            // HoursText
            // 
            this.HoursText.Enabled = false;
            this.HoursText.Location = new System.Drawing.Point(353, 89);
            this.HoursText.Name = "HoursText";
            this.HoursText.Size = new System.Drawing.Size(27, 20);
            this.HoursText.TabIndex = 12;
            this.HoursText.Text = "0";
            // 
            // MinutesText
            // 
            this.MinutesText.Enabled = false;
            this.MinutesText.Location = new System.Drawing.Point(404, 89);
            this.MinutesText.Name = "MinutesText";
            this.MinutesText.Size = new System.Drawing.Size(27, 20);
            this.MinutesText.TabIndex = 13;
            this.MinutesText.Text = "0";
            // 
            // MinusButton1
            // 
            this.MinusButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinusButton1.Location = new System.Drawing.Point(353, 115);
            this.MinusButton1.Name = "MinusButton1";
            this.MinusButton1.Size = new System.Drawing.Size(27, 24);
            this.MinusButton1.TabIndex = 15;
            this.MinusButton1.Text = "-";
            this.MinusButton1.UseVisualStyleBackColor = true;
            this.MinusButton1.Click += new System.EventHandler(this.MinusButton1_Click);
            // 
            // MinusButton2
            // 
            this.MinusButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinusButton2.Location = new System.Drawing.Point(404, 115);
            this.MinusButton2.Name = "MinusButton2";
            this.MinusButton2.Size = new System.Drawing.Size(27, 24);
            this.MinusButton2.TabIndex = 16;
            this.MinusButton2.Text = "-";
            this.MinusButton2.UseVisualStyleBackColor = true;
            this.MinusButton2.Click += new System.EventHandler(this.MinusButton2_Click);
            // 
            // PlusButton1
            // 
            this.PlusButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusButton1.Location = new System.Drawing.Point(353, 59);
            this.PlusButton1.Name = "PlusButton1";
            this.PlusButton1.Size = new System.Drawing.Size(27, 24);
            this.PlusButton1.TabIndex = 18;
            this.PlusButton1.Text = "+";
            this.PlusButton1.UseVisualStyleBackColor = true;
            this.PlusButton1.Click += new System.EventHandler(this.PlusButton1_Click);
            // 
            // PlusButton2
            // 
            this.PlusButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusButton2.Location = new System.Drawing.Point(404, 59);
            this.PlusButton2.Name = "PlusButton2";
            this.PlusButton2.Size = new System.Drawing.Size(27, 24);
            this.PlusButton2.TabIndex = 19;
            this.PlusButton2.Text = "+";
            this.PlusButton2.UseVisualStyleBackColor = true;
            this.PlusButton2.Click += new System.EventHandler(this.PlusButton2_Click);
            // 
            // Dots
            // 
            this.Dots.AutoSize = true;
            this.Dots.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dots.Location = new System.Drawing.Point(386, 87);
            this.Dots.Name = "Dots";
            this.Dots.Size = new System.Drawing.Size(15, 22);
            this.Dots.TabIndex = 20;
            this.Dots.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Часы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Минуты";
            // 
            // DrawClock
            // 
            this.DrawClock.BackColor = System.Drawing.Color.SkyBlue;
            this.DrawClock.Location = new System.Drawing.Point(10, 8);
            this.DrawClock.Name = "DrawClock";
            this.DrawClock.Size = new System.Drawing.Size(320, 320);
            this.DrawClock.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 339);
            this.Controls.Add(this.DrawClock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dots);
            this.Controls.Add(this.PlusButton2);
            this.Controls.Add(this.PlusButton1);
            this.Controls.Add(this.MinusButton2);
            this.Controls.Add(this.MinusButton1);
            this.Controls.Add(this.MinutesText);
            this.Controls.Add(this.HoursText);
            this.Controls.Add(this.DelAlarmButton);
            this.Controls.Add(this.AddAlarmButton);
            this.Controls.Add(this.AlarmList);
            this.Controls.Add(this.KrygButton);
            this.Controls.Add(this.TimerStopList);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.ChangeMultiplierButton);
            this.Controls.Add(this.MyTimerLabel);
            this.Controls.Add(this.TimerButton);
            this.Controls.Add(this.ClockButton);
            this.Name = "Form1";
            this.Text = "Часы+Секундомер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer DefTimer;
        private System.Windows.Forms.Button ClockButton;
        private System.Windows.Forms.Button TimerButton;
        private System.Windows.Forms.Label MyTimerLabel;
        private System.Windows.Forms.Button ChangeMultiplierButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.ListBox TimerStopList;
        private System.Windows.Forms.Button KrygButton;
        private System.Windows.Forms.ListBox AlarmList;
        private System.Windows.Forms.Button AddAlarmButton;
        private System.Windows.Forms.Button DelAlarmButton;
        private System.Windows.Forms.TextBox HoursText;
        private System.Windows.Forms.TextBox MinutesText;
        private System.Windows.Forms.Button MinusButton1;
        private System.Windows.Forms.Button MinusButton2;
        private System.Windows.Forms.Button PlusButton1;
        private System.Windows.Forms.Button PlusButton2;
        private System.Windows.Forms.Label Dots;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel DrawClock;
    }
}

