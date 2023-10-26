namespace BD
{
    partial class MainForm
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
            this.Bconnect = new System.Windows.Forms.Button();
            this.Const = new System.Windows.Forms.Button();
            this.TBserver = new System.Windows.Forms.TextBox();
            this.TBport = new System.Windows.Forms.TextBox();
            this.TBuser = new System.Windows.Forms.TextBox();
            this.TBpass = new System.Windows.Forms.TextBox();
            this.TBdatabase = new System.Windows.Forms.TextBox();
            this.Lserver = new System.Windows.Forms.Label();
            this.Lport = new System.Windows.Forms.Label();
            this.Luser = new System.Windows.Forms.Label();
            this.Lpass = new System.Windows.Forms.Label();
            this.Ldatabase = new System.Windows.Forms.Label();
            this.TBinfo = new System.Windows.Forms.TextBox();
            this.GridSub = new System.Windows.Forms.DataGridView();
            this.GridHouse = new System.Windows.Forms.DataGridView();
            this.GridPhone = new System.Windows.Forms.DataGridView();
            this.GridStreet = new System.Windows.Forms.DataGridView();
            this.GridCity = new System.Windows.Forms.DataGridView();
            this.Bupdate = new System.Windows.Forms.Button();
            this.Bdebug = new System.Windows.Forms.Button();
            this.Bnew = new System.Windows.Forms.Button();
            this.Bdelete = new System.Windows.Forms.Button();
            this.CBtables = new System.Windows.Forms.ComboBox();
            this.Ltables = new System.Windows.Forms.Label();
            this.Lname2 = new System.Windows.Forms.Label();
            this.Lname4 = new System.Windows.Forms.Label();
            this.Lname0 = new System.Windows.Forms.Label();
            this.Lname1 = new System.Windows.Forms.Label();
            this.Lname3 = new System.Windows.Forms.Label();
            this.GBsort = new System.Windows.Forms.GroupBox();
            this.Ldirection = new System.Windows.Forms.Label();
            this.Bsort = new System.Windows.Forms.Button();
            this.CBsort = new System.Windows.Forms.ComboBox();
            this.GBcontrol = new System.Windows.Forms.GroupBox();
            this.Bfind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridStreet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCity)).BeginInit();
            this.GBsort.SuspendLayout();
            this.GBcontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bconnect
            // 
            this.Bconnect.Location = new System.Drawing.Point(369, 139);
            this.Bconnect.Name = "Bconnect";
            this.Bconnect.Size = new System.Drawing.Size(93, 23);
            this.Bconnect.TabIndex = 1;
            this.Bconnect.Text = "Подключение";
            this.Bconnect.UseVisualStyleBackColor = true;
            this.Bconnect.Click += new System.EventHandler(this.Bconnect_Click);
            // 
            // Const
            // 
            this.Const.Location = new System.Drawing.Point(310, 139);
            this.Const.Name = "Const";
            this.Const.Size = new System.Drawing.Size(53, 23);
            this.Const.TabIndex = 4;
            this.Const.Text = "Const";
            this.Const.UseVisualStyleBackColor = true;
            this.Const.Click += new System.EventHandler(this.Const_Click);
            // 
            // TBserver
            // 
            this.TBserver.Location = new System.Drawing.Point(369, 9);
            this.TBserver.Name = "TBserver";
            this.TBserver.Size = new System.Drawing.Size(93, 20);
            this.TBserver.TabIndex = 6;
            // 
            // TBport
            // 
            this.TBport.Location = new System.Drawing.Point(369, 35);
            this.TBport.Name = "TBport";
            this.TBport.Size = new System.Drawing.Size(93, 20);
            this.TBport.TabIndex = 7;
            // 
            // TBuser
            // 
            this.TBuser.Location = new System.Drawing.Point(369, 61);
            this.TBuser.Name = "TBuser";
            this.TBuser.Size = new System.Drawing.Size(93, 20);
            this.TBuser.TabIndex = 8;
            // 
            // TBpass
            // 
            this.TBpass.Location = new System.Drawing.Point(369, 87);
            this.TBpass.Name = "TBpass";
            this.TBpass.Size = new System.Drawing.Size(93, 20);
            this.TBpass.TabIndex = 9;
            // 
            // TBdatabase
            // 
            this.TBdatabase.Location = new System.Drawing.Point(369, 113);
            this.TBdatabase.Name = "TBdatabase";
            this.TBdatabase.Size = new System.Drawing.Size(93, 20);
            this.TBdatabase.TabIndex = 10;
            // 
            // Lserver
            // 
            this.Lserver.AutoSize = true;
            this.Lserver.Location = new System.Drawing.Point(310, 12);
            this.Lserver.Name = "Lserver";
            this.Lserver.Size = new System.Drawing.Size(38, 13);
            this.Lserver.TabIndex = 11;
            this.Lserver.Text = "Server";
            // 
            // Lport
            // 
            this.Lport.AutoSize = true;
            this.Lport.Location = new System.Drawing.Point(310, 37);
            this.Lport.Name = "Lport";
            this.Lport.Size = new System.Drawing.Size(26, 13);
            this.Lport.TabIndex = 12;
            this.Lport.Text = "Port";
            // 
            // Luser
            // 
            this.Luser.AutoSize = true;
            this.Luser.Location = new System.Drawing.Point(311, 64);
            this.Luser.Name = "Luser";
            this.Luser.Size = new System.Drawing.Size(29, 13);
            this.Luser.TabIndex = 13;
            this.Luser.Text = "User";
            // 
            // Lpass
            // 
            this.Lpass.AutoSize = true;
            this.Lpass.Location = new System.Drawing.Point(311, 90);
            this.Lpass.Name = "Lpass";
            this.Lpass.Size = new System.Drawing.Size(30, 13);
            this.Lpass.TabIndex = 14;
            this.Lpass.Text = "Pass";
            // 
            // Ldatabase
            // 
            this.Ldatabase.AutoSize = true;
            this.Ldatabase.Location = new System.Drawing.Point(310, 116);
            this.Ldatabase.Name = "Ldatabase";
            this.Ldatabase.Size = new System.Drawing.Size(53, 13);
            this.Ldatabase.TabIndex = 15;
            this.Ldatabase.Text = "Database";
            // 
            // TBinfo
            // 
            this.TBinfo.Enabled = false;
            this.TBinfo.Location = new System.Drawing.Point(310, 168);
            this.TBinfo.Multiline = true;
            this.TBinfo.Name = "TBinfo";
            this.TBinfo.Size = new System.Drawing.Size(464, 135);
            this.TBinfo.TabIndex = 3;
            // 
            // GridSub
            // 
            this.GridSub.AllowUserToAddRows = false;
            this.GridSub.AllowUserToDeleteRows = false;
            this.GridSub.AllowUserToResizeRows = false;
            this.GridSub.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridSub.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSub.Location = new System.Drawing.Point(4, 330);
            this.GridSub.Name = "GridSub";
            this.GridSub.ReadOnly = true;
            this.GridSub.RowHeadersVisible = false;
            this.GridSub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridSub.Size = new System.Drawing.Size(337, 280);
            this.GridSub.TabIndex = 16;
            this.GridSub.Tag = "0";
            // 
            // GridHouse
            // 
            this.GridHouse.AllowUserToAddRows = false;
            this.GridHouse.AllowUserToDeleteRows = false;
            this.GridHouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridHouse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHouse.Location = new System.Drawing.Point(347, 330);
            this.GridHouse.Name = "GridHouse";
            this.GridHouse.ReadOnly = true;
            this.GridHouse.RowHeadersVisible = false;
            this.GridHouse.Size = new System.Drawing.Size(390, 280);
            this.GridHouse.TabIndex = 17;
            this.GridHouse.Tag = "1";
            // 
            // GridPhone
            // 
            this.GridPhone.AllowUserToAddRows = false;
            this.GridPhone.AllowUserToDeleteRows = false;
            this.GridPhone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridPhone.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridPhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPhone.Location = new System.Drawing.Point(5, 23);
            this.GridPhone.Name = "GridPhone";
            this.GridPhone.ReadOnly = true;
            this.GridPhone.RowHeadersVisible = false;
            this.GridPhone.Size = new System.Drawing.Size(300, 280);
            this.GridPhone.TabIndex = 18;
            this.GridPhone.Tag = "2";
            // 
            // GridStreet
            // 
            this.GridStreet.AllowUserToAddRows = false;
            this.GridStreet.AllowUserToDeleteRows = false;
            this.GridStreet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridStreet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridStreet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridStreet.Location = new System.Drawing.Point(743, 330);
            this.GridStreet.Name = "GridStreet";
            this.GridStreet.ReadOnly = true;
            this.GridStreet.RowHeadersVisible = false;
            this.GridStreet.Size = new System.Drawing.Size(337, 280);
            this.GridStreet.TabIndex = 19;
            this.GridStreet.Tag = "3";
            // 
            // GridCity
            // 
            this.GridCity.AllowUserToAddRows = false;
            this.GridCity.AllowUserToDeleteRows = false;
            this.GridCity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridCity.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCity.Location = new System.Drawing.Point(780, 23);
            this.GridCity.Name = "GridCity";
            this.GridCity.ReadOnly = true;
            this.GridCity.RowHeadersVisible = false;
            this.GridCity.Size = new System.Drawing.Size(300, 280);
            this.GridCity.TabIndex = 20;
            this.GridCity.Tag = "4";
            // 
            // Bupdate
            // 
            this.Bupdate.Location = new System.Drawing.Point(468, 139);
            this.Bupdate.Name = "Bupdate";
            this.Bupdate.Size = new System.Drawing.Size(306, 23);
            this.Bupdate.TabIndex = 22;
            this.Bupdate.Text = "Обновить все таблицы";
            this.Bupdate.UseVisualStyleBackColor = true;
            this.Bupdate.Click += new System.EventHandler(this.Breject_Click);
            // 
            // Bdebug
            // 
            this.Bdebug.Location = new System.Drawing.Point(1015, 304);
            this.Bdebug.Name = "Bdebug";
            this.Bdebug.Size = new System.Drawing.Size(65, 23);
            this.Bdebug.TabIndex = 24;
            this.Bdebug.Text = "Debug";
            this.Bdebug.UseVisualStyleBackColor = true;
            this.Bdebug.Click += new System.EventHandler(this.Bdebug_Click);
            // 
            // Bnew
            // 
            this.Bnew.Location = new System.Drawing.Point(6, 43);
            this.Bnew.Name = "Bnew";
            this.Bnew.Size = new System.Drawing.Size(112, 23);
            this.Bnew.TabIndex = 27;
            this.Bnew.Text = "Добавить строку";
            this.Bnew.UseVisualStyleBackColor = true;
            this.Bnew.Click += new System.EventHandler(this.Bnew_Click);
            // 
            // Bdelete
            // 
            this.Bdelete.Location = new System.Drawing.Point(124, 44);
            this.Bdelete.Name = "Bdelete";
            this.Bdelete.Size = new System.Drawing.Size(104, 23);
            this.Bdelete.TabIndex = 28;
            this.Bdelete.Text = "Удалить строку";
            this.Bdelete.UseVisualStyleBackColor = true;
            this.Bdelete.Click += new System.EventHandler(this.Bdelete_Click);
            // 
            // CBtables
            // 
            this.CBtables.FormattingEnabled = true;
            this.CBtables.Location = new System.Drawing.Point(124, 19);
            this.CBtables.Name = "CBtables";
            this.CBtables.Size = new System.Drawing.Size(175, 21);
            this.CBtables.TabIndex = 31;
            this.CBtables.SelectedIndexChanged += new System.EventHandler(this.CBtables_SelectedIndexChanged);
            // 
            // Ltables
            // 
            this.Ltables.AutoSize = true;
            this.Ltables.Location = new System.Drawing.Point(15, 22);
            this.Ltables.Name = "Ltables";
            this.Ltables.Size = new System.Drawing.Size(103, 13);
            this.Ltables.TabIndex = 32;
            this.Ltables.Text = "Выберите таблицу:";
            // 
            // Lname2
            // 
            this.Lname2.AutoSize = true;
            this.Lname2.Location = new System.Drawing.Point(140, 6);
            this.Lname2.Name = "Lname2";
            this.Lname2.Size = new System.Drawing.Size(38, 13);
            this.Lname2.TabIndex = 33;
            this.Lname2.Text = "Phone";
            // 
            // Lname4
            // 
            this.Lname4.AutoSize = true;
            this.Lname4.Location = new System.Drawing.Point(920, 7);
            this.Lname4.Name = "Lname4";
            this.Lname4.Size = new System.Drawing.Size(24, 13);
            this.Lname4.TabIndex = 34;
            this.Lname4.Text = "City";
            // 
            // Lname0
            // 
            this.Lname0.AutoSize = true;
            this.Lname0.Location = new System.Drawing.Point(114, 314);
            this.Lname0.Name = "Lname0";
            this.Lname0.Size = new System.Drawing.Size(112, 13);
            this.Lname0.TabIndex = 35;
            this.Lname0.Text = "Telephone_subscriber";
            // 
            // Lname1
            // 
            this.Lname1.AutoSize = true;
            this.Lname1.Location = new System.Drawing.Point(513, 314);
            this.Lname1.Name = "Lname1";
            this.Lname1.Size = new System.Drawing.Size(73, 13);
            this.Lname1.TabIndex = 36;
            this.Lname1.Text = "House_owner";
            // 
            // Lname3
            // 
            this.Lname3.AutoSize = true;
            this.Lname3.Location = new System.Drawing.Point(891, 314);
            this.Lname3.Name = "Lname3";
            this.Lname3.Size = new System.Drawing.Size(35, 13);
            this.Lname3.TabIndex = 37;
            this.Lname3.Text = "Street";
            // 
            // GBsort
            // 
            this.GBsort.Controls.Add(this.Ldirection);
            this.GBsort.Controls.Add(this.Bsort);
            this.GBsort.Controls.Add(this.CBsort);
            this.GBsort.Location = new System.Drawing.Point(6, 72);
            this.GBsort.Name = "GBsort";
            this.GBsort.Size = new System.Drawing.Size(293, 46);
            this.GBsort.TabIndex = 38;
            this.GBsort.TabStop = false;
            this.GBsort.Text = "Упорядочить по столбцу";
            // 
            // Ldirection
            // 
            this.Ldirection.AutoSize = true;
            this.Ldirection.Location = new System.Drawing.Point(139, 0);
            this.Ldirection.Name = "Ldirection";
            this.Ldirection.Size = new System.Drawing.Size(0, 13);
            this.Ldirection.TabIndex = 40;
            // 
            // Bsort
            // 
            this.Bsort.Location = new System.Drawing.Point(198, 17);
            this.Bsort.Name = "Bsort";
            this.Bsort.Size = new System.Drawing.Size(89, 23);
            this.Bsort.TabIndex = 39;
            this.Bsort.Text = "Сортировать";
            this.Bsort.UseVisualStyleBackColor = true;
            this.Bsort.Click += new System.EventHandler(this.Bsort_Click);
            // 
            // CBsort
            // 
            this.CBsort.FormattingEnabled = true;
            this.CBsort.Location = new System.Drawing.Point(6, 19);
            this.CBsort.Name = "CBsort";
            this.CBsort.Size = new System.Drawing.Size(186, 21);
            this.CBsort.TabIndex = 39;
            this.CBsort.SelectedIndexChanged += new System.EventHandler(this.CBsort_SelectedIndexChanged);
            // 
            // GBcontrol
            // 
            this.GBcontrol.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GBcontrol.Controls.Add(this.Bfind);
            this.GBcontrol.Controls.Add(this.GBsort);
            this.GBcontrol.Controls.Add(this.Bnew);
            this.GBcontrol.Controls.Add(this.Bdelete);
            this.GBcontrol.Controls.Add(this.CBtables);
            this.GBcontrol.Controls.Add(this.Ltables);
            this.GBcontrol.Location = new System.Drawing.Point(468, 9);
            this.GBcontrol.Name = "GBcontrol";
            this.GBcontrol.Size = new System.Drawing.Size(306, 124);
            this.GBcontrol.TabIndex = 41;
            this.GBcontrol.TabStop = false;
            this.GBcontrol.Text = "Управление таблицей";
            // 
            // Bfind
            // 
            this.Bfind.Location = new System.Drawing.Point(234, 44);
            this.Bfind.Name = "Bfind";
            this.Bfind.Size = new System.Drawing.Size(65, 23);
            this.Bfind.TabIndex = 42;
            this.Bfind.Text = "Поиск";
            this.Bfind.UseVisualStyleBackColor = true;
            this.Bfind.Click += new System.EventHandler(this.Bfind_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 613);
            this.Controls.Add(this.GBcontrol);
            this.Controls.Add(this.Bdebug);
            this.Controls.Add(this.Lname3);
            this.Controls.Add(this.Lname1);
            this.Controls.Add(this.Lname0);
            this.Controls.Add(this.Lname4);
            this.Controls.Add(this.Lname2);
            this.Controls.Add(this.Bupdate);
            this.Controls.Add(this.GridCity);
            this.Controls.Add(this.GridStreet);
            this.Controls.Add(this.GridPhone);
            this.Controls.Add(this.GridHouse);
            this.Controls.Add(this.GridSub);
            this.Controls.Add(this.Ldatabase);
            this.Controls.Add(this.Lpass);
            this.Controls.Add(this.Luser);
            this.Controls.Add(this.Lport);
            this.Controls.Add(this.Lserver);
            this.Controls.Add(this.TBdatabase);
            this.Controls.Add(this.TBpass);
            this.Controls.Add(this.TBuser);
            this.Controls.Add(this.TBport);
            this.Controls.Add(this.TBserver);
            this.Controls.Add(this.Const);
            this.Controls.Add(this.TBinfo);
            this.Controls.Add(this.Bconnect);
            this.Name = "MainForm";
            this.Text = "BD";
            ((System.ComponentModel.ISupportInitialize)(this.GridSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridStreet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCity)).EndInit();
            this.GBsort.ResumeLayout(false);
            this.GBsort.PerformLayout();
            this.GBcontrol.ResumeLayout(false);
            this.GBcontrol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bconnect;
        private System.Windows.Forms.Button Const;
        private System.Windows.Forms.TextBox TBserver;
        private System.Windows.Forms.TextBox TBport;
        private System.Windows.Forms.TextBox TBuser;
        private System.Windows.Forms.TextBox TBpass;
        private System.Windows.Forms.TextBox TBdatabase;
        private System.Windows.Forms.Label Lserver;
        private System.Windows.Forms.Label Lport;
        private System.Windows.Forms.Label Luser;
        private System.Windows.Forms.Label Lpass;
        private System.Windows.Forms.Label Ldatabase;
        private System.Windows.Forms.TextBox TBinfo;
        private System.Windows.Forms.DataGridView GridSub;
        private System.Windows.Forms.DataGridView GridHouse;
        private System.Windows.Forms.DataGridView GridPhone;
        private System.Windows.Forms.DataGridView GridStreet;
        private System.Windows.Forms.DataGridView GridCity;
        private System.Windows.Forms.Button Bupdate;
        private System.Windows.Forms.Button Bdebug;
        private System.Windows.Forms.Button Bnew;
        private System.Windows.Forms.Button Bdelete;
        private System.Windows.Forms.ComboBox CBtables;
        private System.Windows.Forms.Label Ltables;
        private System.Windows.Forms.Label Lname2;
        private System.Windows.Forms.Label Lname4;
        private System.Windows.Forms.Label Lname0;
        private System.Windows.Forms.Label Lname1;
        private System.Windows.Forms.Label Lname3;
        private System.Windows.Forms.GroupBox GBsort;
        private System.Windows.Forms.Button Bsort;
        private System.Windows.Forms.ComboBox CBsort;
        private System.Windows.Forms.Label Ldirection;
        private System.Windows.Forms.GroupBox GBcontrol;
        private System.Windows.Forms.Button Bfind;
    }
}

