namespace MyDBSM
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            startPanel = new Panel();
            dbCreateButton = new Button();
            importButton = new Button();
            dbInfoPanel = new Panel();
            name_label = new Label();
            exportButton = new Button();
            button3 = new Button();
            columnsTableButton = new Button();
            dataTableButton = new Button();
            tableListBox = new ListBox();
            addTableButton = new Button();
            dbRenameButton = new Button();
            dbDeleteButton = new Button();
            splitter1 = new Splitter();
            tableColumnsPanel = new Panel();
            addNewColumnButton = new Button();
            deleteColumnButton = new Button();
            saveChangesColumnsButton = new Button();
            backFromColumnsButton = new Button();
            dataGridView1 = new DataGridView();
            ColumnName = new DataGridViewTextBoxColumn();
            DataType = new DataGridViewComboBoxColumn();
            IsNullable = new DataGridViewCheckBoxColumn();
            valuesPanel = new Panel();
            projectTableButton = new Button();
            deleteRowButton = new Button();
            newRowButton = new Button();
            saveValuesButton = new Button();
            backFromValuesButton = new Button();
            valuesGrid = new DataGridView();
            startPanel.SuspendLayout();
            dbInfoPanel.SuspendLayout();
            tableColumnsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            valuesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)valuesGrid).BeginInit();
            SuspendLayout();
            // 
            // startPanel
            // 
            startPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            startPanel.BackColor = Color.AliceBlue;
            startPanel.Controls.Add(dbCreateButton);
            startPanel.Controls.Add(importButton);
            startPanel.Location = new Point(0, 0);
            startPanel.Margin = new Padding(2);
            startPanel.Name = "startPanel";
            startPanel.Size = new Size(1045, 608);
            startPanel.TabIndex = 0;
            // 
            // dbCreateButton
            // 
            dbCreateButton.BackColor = Color.GhostWhite;
            dbCreateButton.Cursor = Cursors.Hand;
            dbCreateButton.FlatAppearance.BorderColor = Color.Black;
            dbCreateButton.FlatAppearance.BorderSize = 3;
            dbCreateButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            dbCreateButton.FlatAppearance.MouseOverBackColor = Color.MintCream;
            dbCreateButton.FlatStyle = FlatStyle.Flat;
            dbCreateButton.Font = new Font("Tw Cen MT Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dbCreateButton.ForeColor = Color.FromArgb(73, 56, 29);
            dbCreateButton.Location = new Point(548, 321);
            dbCreateButton.Margin = new Padding(2);
            dbCreateButton.Name = "dbCreateButton";
            dbCreateButton.Size = new Size(244, 69);
            dbCreateButton.TabIndex = 2;
            dbCreateButton.Text = "Create";
            dbCreateButton.UseVisualStyleBackColor = false;
            dbCreateButton.Click += dbCreateButton_Click;
            // 
            // importButton
            // 
            importButton.BackColor = Color.GhostWhite;
            importButton.Cursor = Cursors.Hand;
            importButton.FlatAppearance.BorderColor = Color.Black;
            importButton.FlatAppearance.BorderSize = 3;
            importButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            importButton.FlatAppearance.MouseOverBackColor = Color.MintCream;
            importButton.FlatStyle = FlatStyle.Flat;
            importButton.Font = new Font("Tw Cen MT Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            importButton.ForeColor = Color.FromArgb(73, 56, 29);
            importButton.Location = new Point(863, 321);
            importButton.Margin = new Padding(2);
            importButton.Name = "importButton";
            importButton.Size = new Size(244, 69);
            importButton.TabIndex = 1;
            importButton.Text = "Import";
            importButton.UseVisualStyleBackColor = false;
            importButton.Click += importButton_Click;
            // 
            // dbInfoPanel
            // 
            dbInfoPanel.BackColor = Color.AliceBlue;
            dbInfoPanel.Controls.Add(name_label);
            dbInfoPanel.Controls.Add(exportButton);
            dbInfoPanel.Controls.Add(button3);
            dbInfoPanel.Controls.Add(columnsTableButton);
            dbInfoPanel.Controls.Add(dataTableButton);
            dbInfoPanel.Controls.Add(tableListBox);
            dbInfoPanel.Controls.Add(addTableButton);
            dbInfoPanel.Controls.Add(dbRenameButton);
            dbInfoPanel.Controls.Add(dbDeleteButton);
            dbInfoPanel.Controls.Add(splitter1);
            dbInfoPanel.Dock = DockStyle.Fill;
            dbInfoPanel.Location = new Point(0, 0);
            dbInfoPanel.Margin = new Padding(2);
            dbInfoPanel.Name = "dbInfoPanel";
            dbInfoPanel.Size = new Size(1045, 608);
            dbInfoPanel.TabIndex = 4;
            dbInfoPanel.Paint += dbInfoPanel_Paint;
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Tw Cen MT Condensed Extra Bold", 28F, FontStyle.Regular, GraphicsUnit.Point);
            name_label.Location = new Point(7, 7);
            name_label.Margin = new Padding(2, 0, 2, 0);
            name_label.Name = "name_label";
            name_label.Size = new Size(59, 45);
            name_label.TabIndex = 0;
            name_label.Text = "DB";
            // 
            // exportButton
            // 
            exportButton.BackColor = Color.GhostWhite;
            exportButton.Cursor = Cursors.Hand;
            exportButton.Font = new Font("Tw Cen MT Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            exportButton.ForeColor = Color.FromArgb(73, 56, 29);
            exportButton.Location = new Point(234, 63);
            exportButton.Margin = new Padding(2);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(214, 32);
            exportButton.TabIndex = 11;
            exportButton.Text = "Export db";
            exportButton.UseVisualStyleBackColor = false;
            exportButton.Click += exportButton_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.GhostWhite;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Tw Cen MT Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(192, 0, 0);
            button3.Location = new Point(497, 554);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(158, 34);
            button3.TabIndex = 10;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // columnsTableButton
            // 
            columnsTableButton.BackColor = Color.GhostWhite;
            columnsTableButton.Cursor = Cursors.Hand;
            columnsTableButton.Font = new Font("Tw Cen MT Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            columnsTableButton.ForeColor = Color.FromArgb(73, 56, 29);
            columnsTableButton.Location = new Point(335, 554);
            columnsTableButton.Margin = new Padding(2);
            columnsTableButton.Name = "columnsTableButton";
            columnsTableButton.Size = new Size(158, 34);
            columnsTableButton.TabIndex = 9;
            columnsTableButton.Text = "View columns";
            columnsTableButton.UseVisualStyleBackColor = false;
            columnsTableButton.Click += columnsTableButton_Click;
            // 
            // dataTableButton
            // 
            dataTableButton.BackColor = Color.GhostWhite;
            dataTableButton.Cursor = Cursors.Hand;
            dataTableButton.Font = new Font("Tw Cen MT Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            dataTableButton.ForeColor = Color.FromArgb(73, 56, 29);
            dataTableButton.Location = new Point(173, 554);
            dataTableButton.Margin = new Padding(2);
            dataTableButton.Name = "dataTableButton";
            dataTableButton.Size = new Size(158, 34);
            dataTableButton.TabIndex = 8;
            dataTableButton.Text = "View data";
            dataTableButton.UseVisualStyleBackColor = false;
            dataTableButton.Click += dataTableButton_Click;
            // 
            // tableListBox
            // 
            tableListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableListBox.BackColor = Color.Ivory;
            tableListBox.Cursor = Cursors.Help;
            tableListBox.Font = new Font("Tw Cen MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tableListBox.FormattingEnabled = true;
            tableListBox.ItemHeight = 28;
            tableListBox.Location = new Point(7, 122);
            tableListBox.Margin = new Padding(2);
            tableListBox.Name = "tableListBox";
            tableListBox.Size = new Size(348, 424);
            tableListBox.TabIndex = 7;
            // 
            // addTableButton
            // 
            addTableButton.BackColor = Color.GhostWhite;
            addTableButton.Cursor = Cursors.Hand;
            addTableButton.Font = new Font("Tw Cen MT Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addTableButton.ForeColor = Color.FromArgb(73, 56, 29);
            addTableButton.Location = new Point(11, 555);
            addTableButton.Margin = new Padding(2);
            addTableButton.Name = "addTableButton";
            addTableButton.Size = new Size(158, 32);
            addTableButton.TabIndex = 6;
            addTableButton.Text = "Add table";
            addTableButton.UseVisualStyleBackColor = false;
            addTableButton.Click += addTableButton_Click;
            // 
            // dbRenameButton
            // 
            dbRenameButton.BackColor = Color.GhostWhite;
            dbRenameButton.Cursor = Cursors.Hand;
            dbRenameButton.Font = new Font("Tw Cen MT Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            dbRenameButton.ForeColor = Color.FromArgb(73, 56, 29);
            dbRenameButton.Location = new Point(11, 63);
            dbRenameButton.Margin = new Padding(2);
            dbRenameButton.Name = "dbRenameButton";
            dbRenameButton.Size = new Size(214, 32);
            dbRenameButton.TabIndex = 4;
            dbRenameButton.Text = "Rename ";
            dbRenameButton.UseVisualStyleBackColor = false;
            dbRenameButton.Click += dbRenameButton_Click;
            // 
            // dbDeleteButton
            // 
            dbDeleteButton.BackColor = Color.GhostWhite;
            dbDeleteButton.Cursor = Cursors.Hand;
            dbDeleteButton.Font = new Font("Tw Cen MT Condensed", 16F, FontStyle.Bold, GraphicsUnit.Point);
            dbDeleteButton.ForeColor = Color.FromArgb(192, 0, 0);
            dbDeleteButton.Location = new Point(456, 63);
            dbDeleteButton.Margin = new Padding(2);
            dbDeleteButton.Name = "dbDeleteButton";
            dbDeleteButton.Size = new Size(214, 32);
            dbDeleteButton.TabIndex = 3;
            dbDeleteButton.Text = "Delete database";
            dbDeleteButton.UseVisualStyleBackColor = false;
            dbDeleteButton.Click += dbDeleteButton_Click;
            // 
            // splitter1
            // 
            splitter1.BackColor = Color.White;
            splitter1.BorderStyle = BorderStyle.FixedSingle;
            splitter1.Dock = DockStyle.Top;
            splitter1.Location = new Point(0, 0);
            splitter1.Margin = new Padding(2);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(1045, 104);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // tableColumnsPanel
            // 
            tableColumnsPanel.BackColor = Color.MintCream;
            tableColumnsPanel.Controls.Add(addNewColumnButton);
            tableColumnsPanel.Controls.Add(deleteColumnButton);
            tableColumnsPanel.Controls.Add(saveChangesColumnsButton);
            tableColumnsPanel.Controls.Add(backFromColumnsButton);
            tableColumnsPanel.Controls.Add(dataGridView1);
            tableColumnsPanel.Dock = DockStyle.Fill;
            tableColumnsPanel.Location = new Point(0, 0);
            tableColumnsPanel.Name = "tableColumnsPanel";
            tableColumnsPanel.Size = new Size(1045, 608);
            tableColumnsPanel.TabIndex = 12;
            tableColumnsPanel.Visible = false;
            // 
            // addNewColumnButton
            // 
            addNewColumnButton.BackColor = Color.GhostWhite;
            addNewColumnButton.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            addNewColumnButton.ForeColor = Color.FromArgb(73, 56, 29);
            addNewColumnButton.Location = new Point(200, 12);
            addNewColumnButton.Name = "addNewColumnButton";
            addNewColumnButton.Size = new Size(97, 37);
            addNewColumnButton.TabIndex = 4;
            addNewColumnButton.Text = "Create";
            addNewColumnButton.UseVisualStyleBackColor = false;
            addNewColumnButton.Click += addNewColumnButton_Click;
            // 
            // deleteColumnButton
            // 
            deleteColumnButton.BackColor = Color.GhostWhite;
            deleteColumnButton.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            deleteColumnButton.ForeColor = Color.FromArgb(192, 0, 0);
            deleteColumnButton.Location = new Point(303, 12);
            deleteColumnButton.Name = "deleteColumnButton";
            deleteColumnButton.Size = new Size(97, 37);
            deleteColumnButton.TabIndex = 3;
            deleteColumnButton.Text = "Delete ";
            deleteColumnButton.UseVisualStyleBackColor = false;
            deleteColumnButton.Click += deleteColumnButton_Click;
            // 
            // saveChangesColumnsButton
            // 
            saveChangesColumnsButton.BackColor = Color.GhostWhite;
            saveChangesColumnsButton.Font = new Font("Tw Cen MT Condensed Extra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            saveChangesColumnsButton.ForeColor = Color.FromArgb(73, 56, 29);
            saveChangesColumnsButton.Location = new Point(97, 11);
            saveChangesColumnsButton.Name = "saveChangesColumnsButton";
            saveChangesColumnsButton.Size = new Size(97, 39);
            saveChangesColumnsButton.TabIndex = 2;
            saveChangesColumnsButton.Text = "Save";
            saveChangesColumnsButton.UseVisualStyleBackColor = false;
            saveChangesColumnsButton.Click += saveChangesColumnsButton_Click;
            // 
            // backFromColumnsButton
            // 
            backFromColumnsButton.BackColor = Color.GhostWhite;
            backFromColumnsButton.Font = new Font("Tw Cen MT Condensed Extra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            backFromColumnsButton.ForeColor = Color.FromArgb(73, 56, 29);
            backFromColumnsButton.Location = new Point(12, 9);
            backFromColumnsButton.Name = "backFromColumnsButton";
            backFromColumnsButton.Size = new Size(59, 43);
            backFromColumnsButton.TabIndex = 1;
            backFromColumnsButton.Text = "←";
            backFromColumnsButton.UseVisualStyleBackColor = false;
            backFromColumnsButton.Click += backFromColumnsButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.BackgroundColor = Color.Ivory;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnName, DataType, IsNullable });
            dataGridView1.Location = new Point(12, 58);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(590, 570);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Column name";
            ColumnName.MinimumWidth = 8;
            ColumnName.Name = "ColumnName";
            ColumnName.Width = 150;
            // 
            // DataType
            // 
            DataType.HeaderText = "Data type";
            DataType.Items.AddRange(new object[] { "Integer", "Real", "Char", "String", "Color", "Color interval" });
            DataType.MinimumWidth = 8;
            DataType.Name = "DataType";
            DataType.Width = 150;
            // 
            // IsNullable
            // 
            IsNullable.HeaderText = "Is nullable";
            IsNullable.MinimumWidth = 8;
            IsNullable.Name = "IsNullable";
            IsNullable.Width = 150;
            // 
            // valuesPanel
            // 
            valuesPanel.BackColor = Color.DimGray;
            valuesPanel.Controls.Add(deleteRowButton);
            valuesPanel.Controls.Add(newRowButton);
            valuesPanel.Controls.Add(saveValuesButton);
            valuesPanel.Controls.Add(backFromValuesButton);
            valuesPanel.Controls.Add(valuesGrid);
            valuesPanel.Dock = DockStyle.Fill;
            valuesPanel.Location = new Point(0, 0);
            valuesPanel.Name = "valuesPanel";
            valuesPanel.Size = new Size(1045, 608);
            valuesPanel.TabIndex = 5;
            // 
            // deleteRowButton
            // 
            deleteRowButton.BackColor = Color.Azure;
            deleteRowButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteRowButton.ForeColor = Color.FromArgb(192, 0, 0);
            deleteRowButton.Location = new Point(328, 6);
            deleteRowButton.Margin = new Padding(2);
            deleteRowButton.Name = "deleteRowButton";
            deleteRowButton.Size = new Size(120, 39);
            deleteRowButton.TabIndex = 4;
            deleteRowButton.Text = "Delete ";
            deleteRowButton.UseVisualStyleBackColor = false;
            deleteRowButton.Click += deleteRowButton_Click;
            // 
            // newRowButton
            // 
            newRowButton.BackColor = Color.Azure;
            newRowButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            newRowButton.ForeColor = Color.FromArgb(73, 56, 29);
            newRowButton.Location = new Point(204, 7);
            newRowButton.Margin = new Padding(2);
            newRowButton.Name = "newRowButton";
            newRowButton.Size = new Size(120, 39);
            newRowButton.TabIndex = 3;
            newRowButton.Text = "Create row";
            newRowButton.UseVisualStyleBackColor = false;
            newRowButton.Click += newRowButton_Click;
            // 
            // saveValuesButton
            // 
            saveValuesButton.BackColor = Color.GhostWhite;
            saveValuesButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saveValuesButton.ForeColor = Color.FromArgb(73, 56, 29);
            saveValuesButton.Location = new Point(80, 6);
            saveValuesButton.Margin = new Padding(2);
            saveValuesButton.Name = "saveValuesButton";
            saveValuesButton.Size = new Size(120, 39);
            saveValuesButton.TabIndex = 2;
            saveValuesButton.Text = "Save ";
            saveValuesButton.UseVisualStyleBackColor = false;
            saveValuesButton.Click += saveValuesButton_Click;
            // 
            // backFromValuesButton
            // 
            backFromValuesButton.BackColor = Color.Azure;
            backFromValuesButton.Font = new Font("Tw Cen MT", 20F, FontStyle.Bold, GraphicsUnit.Point);
            backFromValuesButton.ForeColor = Color.FromArgb(73, 56, 29);
            backFromValuesButton.Location = new Point(5, 4);
            backFromValuesButton.Margin = new Padding(2);
            backFromValuesButton.Name = "backFromValuesButton";
            backFromValuesButton.Size = new Size(47, 44);
            backFromValuesButton.TabIndex = 1;
            backFromValuesButton.Text = "←";
            backFromValuesButton.UseVisualStyleBackColor = false;
            backFromValuesButton.Click += backFromValuesButton_Click;
            // 
            // valuesGrid
            // 
            valuesGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            valuesGrid.BackgroundColor = Color.Ivory;
            valuesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            valuesGrid.Location = new Point(0, 50);
            valuesGrid.Name = "valuesGrid";
            valuesGrid.RowHeadersWidth = 62;
            valuesGrid.RowTemplate.Height = 25;
            valuesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            valuesGrid.Size = new Size(1045, 507);
            valuesGrid.TabIndex = 0;
/*            valuesGrid.CellContentClick += valuesGrid_CellContentClick;
*/            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1045, 608);
            Controls.Add(dbInfoPanel);
            Controls.Add(startPanel);
            Controls.Add(valuesPanel);
            Controls.Add(tableColumnsPanel);
            ForeColor = Color.FromArgb(73, 56, 29);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "DataBaseControll";
            Load += Form1_Load;
            startPanel.ResumeLayout(false);
            dbInfoPanel.ResumeLayout(false);
            dbInfoPanel.PerformLayout();
            tableColumnsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            valuesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)valuesGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel startPanel;
        private Button importButton;
        private Button dbCreateButton;
        private Panel dbInfoPanel;
        private Label name_label;
        private Button dbDeleteButton;
        private Splitter splitter1;
        private Button dbRenameButton;
        private Button addTableButton;
        private ListBox tableListBox;
        private Button button3;
        private Button columnsTableButton;
        private Button dataTableButton;
        private Button exportButton;
        private Panel tableColumnsPanel;
        private DataGridView dataGridView1;
        private Button backFromColumnsButton;
        private Button saveChangesColumnsButton;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewComboBoxColumn DataType;
        private DataGridViewCheckBoxColumn IsNullable;
        private Button deleteColumnButton;
        private Button addNewColumnButton;
        private Panel valuesPanel;
        private DataGridView valuesGrid;
        private Button backFromValuesButton;
        private Button saveValuesButton;
        private Button newRowButton;
        private Button deleteRowButton;
        private Button projectTableButton;

    }
}