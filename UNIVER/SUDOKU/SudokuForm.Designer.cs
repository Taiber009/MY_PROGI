namespace SUDOKU
{
    partial class SudokuForm
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
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid5 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid6 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid7 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid8 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid9 = new System.Windows.Forms.DataGridView();
            this.BNewgame = new System.Windows.Forms.Button();
            this.BSave = new System.Windows.Forms.Button();
            this.BLoad = new System.Windows.Forms.Button();
            this.LDiffInfo = new System.Windows.Forms.Label();
            this.LDiff = new System.Windows.Forms.Label();
            this.LTimer = new System.Windows.Forms.Label();
            this.BEnd = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid9)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid1
            // 
            this.Grid1.AllowUserToAddRows = false;
            this.Grid1.AllowUserToDeleteRows = false;
            this.Grid1.AllowUserToResizeColumns = false;
            this.Grid1.AllowUserToResizeRows = false;
            this.Grid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid1.ColumnHeadersVisible = false;
            this.Grid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.Grid1.Location = new System.Drawing.Point(11, 9);
            this.Grid1.MultiSelect = false;
            this.Grid1.Name = "Grid1";
            this.Grid1.RowHeadersVisible = false;
            this.Grid1.Size = new System.Drawing.Size(66, 63);
            this.Grid1.TabIndex = 0;
            this.Grid1.TabStop = false;
            this.Grid1.Tag = "0";
            this.Grid1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellEndEdit);
            this.Grid1.MouseLeave += new System.EventHandler(this.Grid_Leave);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MaxInputLength = 1;
            this.Column1.Name = "Column1";
            this.Column1.Width = 5;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MaxInputLength = 1;
            this.Column2.Name = "Column2";
            this.Column2.Width = 5;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MaxInputLength = 1;
            this.Column3.Name = "Column3";
            this.Column3.Width = 5;
            // 
            // Grid2
            // 
            this.Grid2.AllowUserToAddRows = false;
            this.Grid2.AllowUserToDeleteRows = false;
            this.Grid2.AllowUserToResizeColumns = false;
            this.Grid2.AllowUserToResizeRows = false;
            this.Grid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid2.ColumnHeadersVisible = false;
            this.Grid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.Grid2.Location = new System.Drawing.Point(83, 9);
            this.Grid2.MultiSelect = false;
            this.Grid2.Name = "Grid2";
            this.Grid2.RowHeadersVisible = false;
            this.Grid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Grid2.Size = new System.Drawing.Size(66, 63);
            this.Grid2.TabIndex = 1;
            this.Grid2.TabStop = false;
            this.Grid2.Tag = "1";
            this.Grid2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellEndEdit);
            this.Grid2.MouseLeave += new System.EventHandler(this.Grid_Leave);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 5;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Column3";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 5;
            // 
            // Grid3
            // 
            this.Grid3.AllowUserToAddRows = false;
            this.Grid3.AllowUserToDeleteRows = false;
            this.Grid3.AllowUserToResizeColumns = false;
            this.Grid3.AllowUserToResizeRows = false;
            this.Grid3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid3.ColumnHeadersVisible = false;
            this.Grid3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.Grid3.Location = new System.Drawing.Point(155, 9);
            this.Grid3.MultiSelect = false;
            this.Grid3.Name = "Grid3";
            this.Grid3.RowHeadersVisible = false;
            this.Grid3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Grid3.Size = new System.Drawing.Size(66, 63);
            this.Grid3.TabIndex = 2;
            this.Grid3.TabStop = false;
            this.Grid3.Tag = "2";
            this.Grid3.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellEndEdit);
            this.Grid3.MouseLeave += new System.EventHandler(this.Grid_Leave);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn4.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 5;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn5.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 5;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Column3";
            this.dataGridViewTextBoxColumn6.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 5;
            // 
            // Grid4
            // 
            this.Grid4.AllowUserToAddRows = false;
            this.Grid4.AllowUserToDeleteRows = false;
            this.Grid4.AllowUserToResizeColumns = false;
            this.Grid4.AllowUserToResizeRows = false;
            this.Grid4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid4.ColumnHeadersVisible = false;
            this.Grid4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.Grid4.Location = new System.Drawing.Point(11, 78);
            this.Grid4.MultiSelect = false;
            this.Grid4.Name = "Grid4";
            this.Grid4.RowHeadersVisible = false;
            this.Grid4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Grid4.Size = new System.Drawing.Size(66, 63);
            this.Grid4.TabIndex = 3;
            this.Grid4.TabStop = false;
            this.Grid4.Tag = "3";
            this.Grid4.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellEndEdit);
            this.Grid4.MouseLeave += new System.EventHandler(this.Grid_Leave);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn7.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 5;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn8.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 5;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Column3";
            this.dataGridViewTextBoxColumn9.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 5;
            // 
            // Grid5
            // 
            this.Grid5.AllowUserToAddRows = false;
            this.Grid5.AllowUserToDeleteRows = false;
            this.Grid5.AllowUserToResizeColumns = false;
            this.Grid5.AllowUserToResizeRows = false;
            this.Grid5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid5.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid5.ColumnHeadersVisible = false;
            this.Grid5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.Grid5.Location = new System.Drawing.Point(83, 78);
            this.Grid5.MultiSelect = false;
            this.Grid5.Name = "Grid5";
            this.Grid5.RowHeadersVisible = false;
            this.Grid5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Grid5.Size = new System.Drawing.Size(66, 63);
            this.Grid5.TabIndex = 4;
            this.Grid5.TabStop = false;
            this.Grid5.Tag = "4";
            this.Grid5.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellEndEdit);
            this.Grid5.MouseLeave += new System.EventHandler(this.Grid_Leave);
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn10.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 5;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn11.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 5;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Column3";
            this.dataGridViewTextBoxColumn12.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 5;
            // 
            // Grid6
            // 
            this.Grid6.AllowUserToAddRows = false;
            this.Grid6.AllowUserToDeleteRows = false;
            this.Grid6.AllowUserToResizeColumns = false;
            this.Grid6.AllowUserToResizeRows = false;
            this.Grid6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid6.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid6.ColumnHeadersVisible = false;
            this.Grid6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.Grid6.Location = new System.Drawing.Point(155, 78);
            this.Grid6.MultiSelect = false;
            this.Grid6.Name = "Grid6";
            this.Grid6.RowHeadersVisible = false;
            this.Grid6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Grid6.Size = new System.Drawing.Size(66, 63);
            this.Grid6.TabIndex = 5;
            this.Grid6.TabStop = false;
            this.Grid6.Tag = "5";
            this.Grid6.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellEndEdit);
            this.Grid6.MouseLeave += new System.EventHandler(this.Grid_Leave);
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn13.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 5;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn14.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 5;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Column3";
            this.dataGridViewTextBoxColumn15.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 5;
            // 
            // Grid7
            // 
            this.Grid7.AllowUserToAddRows = false;
            this.Grid7.AllowUserToDeleteRows = false;
            this.Grid7.AllowUserToResizeColumns = false;
            this.Grid7.AllowUserToResizeRows = false;
            this.Grid7.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid7.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid7.ColumnHeadersVisible = false;
            this.Grid7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.Grid7.Location = new System.Drawing.Point(11, 147);
            this.Grid7.MultiSelect = false;
            this.Grid7.Name = "Grid7";
            this.Grid7.RowHeadersVisible = false;
            this.Grid7.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Grid7.Size = new System.Drawing.Size(66, 63);
            this.Grid7.TabIndex = 6;
            this.Grid7.TabStop = false;
            this.Grid7.Tag = "6";
            this.Grid7.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellEndEdit);
            this.Grid7.MouseLeave += new System.EventHandler(this.Grid_Leave);
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn16.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 5;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn17.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 5;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "Column3";
            this.dataGridViewTextBoxColumn18.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 5;
            // 
            // Grid8
            // 
            this.Grid8.AllowUserToAddRows = false;
            this.Grid8.AllowUserToDeleteRows = false;
            this.Grid8.AllowUserToResizeColumns = false;
            this.Grid8.AllowUserToResizeRows = false;
            this.Grid8.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid8.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid8.ColumnHeadersVisible = false;
            this.Grid8.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.Grid8.Location = new System.Drawing.Point(83, 147);
            this.Grid8.MultiSelect = false;
            this.Grid8.Name = "Grid8";
            this.Grid8.RowHeadersVisible = false;
            this.Grid8.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Grid8.Size = new System.Drawing.Size(66, 63);
            this.Grid8.TabIndex = 7;
            this.Grid8.TabStop = false;
            this.Grid8.Tag = "7";
            this.Grid8.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellEndEdit);
            this.Grid8.MouseLeave += new System.EventHandler(this.Grid_Leave);
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn19.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 5;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn20.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 5;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.HeaderText = "Column3";
            this.dataGridViewTextBoxColumn21.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 5;
            // 
            // Grid9
            // 
            this.Grid9.AllowUserToAddRows = false;
            this.Grid9.AllowUserToDeleteRows = false;
            this.Grid9.AllowUserToResizeColumns = false;
            this.Grid9.AllowUserToResizeRows = false;
            this.Grid9.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid9.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid9.ColumnHeadersVisible = false;
            this.Grid9.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.Grid9.Location = new System.Drawing.Point(155, 147);
            this.Grid9.MultiSelect = false;
            this.Grid9.Name = "Grid9";
            this.Grid9.RowHeadersVisible = false;
            this.Grid9.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Grid9.Size = new System.Drawing.Size(66, 63);
            this.Grid9.TabIndex = 8;
            this.Grid9.TabStop = false;
            this.Grid9.Tag = "8";
            this.Grid9.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellEndEdit);
            this.Grid9.MouseLeave += new System.EventHandler(this.Grid_Leave);
            // 
            // BNewgame
            // 
            this.BNewgame.Location = new System.Drawing.Point(227, 103);
            this.BNewgame.Name = "BNewgame";
            this.BNewgame.Size = new System.Drawing.Size(98, 23);
            this.BNewgame.TabIndex = 9;
            this.BNewgame.Text = "Новая игра";
            this.BNewgame.UseVisualStyleBackColor = true;
            this.BNewgame.Click += new System.EventHandler(this.BNewgame_Click);
            // 
            // BSave
            // 
            this.BSave.Location = new System.Drawing.Point(227, 158);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(98, 23);
            this.BSave.TabIndex = 10;
            this.BSave.Text = "Сохранить игру";
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Visible = false;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // BLoad
            // 
            this.BLoad.Location = new System.Drawing.Point(227, 187);
            this.BLoad.Name = "BLoad";
            this.BLoad.Size = new System.Drawing.Size(98, 23);
            this.BLoad.TabIndex = 11;
            this.BLoad.Text = "Загрузить игру";
            this.BLoad.UseVisualStyleBackColor = true;
            this.BLoad.Click += new System.EventHandler(this.BLoad_Click);
            // 
            // LDiffInfo
            // 
            this.LDiffInfo.AutoSize = true;
            this.LDiffInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LDiffInfo.Location = new System.Drawing.Point(228, 61);
            this.LDiffInfo.Name = "LDiffInfo";
            this.LDiffInfo.Size = new System.Drawing.Size(83, 17);
            this.LDiffInfo.TabIndex = 12;
            this.LDiffInfo.Text = "Сложность:";
            this.LDiffInfo.Visible = false;
            // 
            // LDiff
            // 
            this.LDiff.AutoSize = true;
            this.LDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LDiff.Location = new System.Drawing.Point(227, 78);
            this.LDiff.Name = "LDiff";
            this.LDiff.Size = new System.Drawing.Size(0, 22);
            this.LDiff.TabIndex = 13;
            // 
            // LTimer
            // 
            this.LTimer.AutoSize = true;
            this.LTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LTimer.Location = new System.Drawing.Point(249, 26);
            this.LTimer.Name = "LTimer";
            this.LTimer.Size = new System.Drawing.Size(40, 25);
            this.LTimer.TabIndex = 14;
            this.LTimer.Text = "0:0";
            this.LTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LTimer.Visible = false;
            // 
            // BEnd
            // 
            this.BEnd.Location = new System.Drawing.Point(227, 132);
            this.BEnd.Name = "BEnd";
            this.BEnd.Size = new System.Drawing.Size(98, 23);
            this.BEnd.TabIndex = 15;
            this.BEnd.Text = "Закончить игру";
            this.BEnd.UseVisualStyleBackColor = true;
            this.BEnd.Visible = false;
            this.BEnd.Click += new System.EventHandler(this.BEnd_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // SFD
            // 
            this.SFD.CreatePrompt = true;
            this.SFD.Filter = "txt files (*.txt)|*.txt";
            this.SFD.FilterIndex = 2;
            // 
            // OFD
            // 
            this.OFD.Filter = "txt files (*.txt)|*.txt";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn22.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 5;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn23.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 5;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.HeaderText = "Column3";
            this.dataGridViewTextBoxColumn24.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 5;
            // 
            // SudokuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 218);
            this.Controls.Add(this.BEnd);
            this.Controls.Add(this.LTimer);
            this.Controls.Add(this.LDiff);
            this.Controls.Add(this.LDiffInfo);
            this.Controls.Add(this.BLoad);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.BNewgame);
            this.Controls.Add(this.Grid9);
            this.Controls.Add(this.Grid8);
            this.Controls.Add(this.Grid7);
            this.Controls.Add(this.Grid6);
            this.Controls.Add(this.Grid5);
            this.Controls.Add(this.Grid4);
            this.Controls.Add(this.Grid3);
            this.Controls.Add(this.Grid2);
            this.Controls.Add(this.Grid1);
            this.Name = "SudokuForm";
            this.ShowIcon = false;
            this.Text = "Судоку";
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView Grid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView Grid3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView Grid4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridView Grid5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridView Grid6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridView Grid7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridView Grid8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridView Grid9;
        private System.Windows.Forms.Button BNewgame;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.Button BLoad;
        private System.Windows.Forms.Label LDiffInfo;
        private System.Windows.Forms.Label LDiff;
        private System.Windows.Forms.Label LTimer;
        private System.Windows.Forms.Button BEnd;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
    }
}

