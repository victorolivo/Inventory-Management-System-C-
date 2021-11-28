
namespace VictorJOlivoRamirez_InventoryManagementSystem2
{
    partial class MainScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.mainTitleLabel = new System.Windows.Forms.Label();
            this.mainPartsDgvLablel = new System.Windows.Forms.Label();
            this.mainPartSearchTextBox = new System.Windows.Forms.TextBox();
            this.mainProductSearchTextBox = new System.Windows.Forms.TextBox();
            this.mainProductSearchButton = new System.Windows.Forms.Button();
            this.mainProductsDgvLabel = new System.Windows.Forms.Label();
            this.mainPartsDgv = new System.Windows.Forms.DataGridView();
            this.mainProductsDgv = new System.Windows.Forms.DataGridView();
            this.mainAddPartButton = new System.Windows.Forms.Button();
            this.mainAddProductButton = new System.Windows.Forms.Button();
            this.mainModifyPartButton = new System.Windows.Forms.Button();
            this.mainModifyProductButton = new System.Windows.Forms.Button();
            this.mainDeletePartButton = new System.Windows.Forms.Button();
            this.mainDeleteProductButton = new System.Windows.Forms.Button();
            this.mainExitButton = new System.Windows.Forms.Button();
            this.mainPartSearchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainPartsDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainProductsDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTitleLabel
            // 
            this.mainTitleLabel.AutoSize = true;
            this.mainTitleLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitleLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.mainTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.mainTitleLabel.Name = "mainTitleLabel";
            this.mainTitleLabel.Size = new System.Drawing.Size(330, 27);
            this.mainTitleLabel.TabIndex = 0;
            this.mainTitleLabel.Text = "Inventory Management System";
            // 
            // mainPartsDgvLablel
            // 
            this.mainPartsDgvLablel.AutoSize = true;
            this.mainPartsDgvLablel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainPartsDgvLablel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPartsDgvLablel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainPartsDgvLablel.Location = new System.Drawing.Point(28, 81);
            this.mainPartsDgvLablel.Name = "mainPartsDgvLablel";
            this.mainPartsDgvLablel.Size = new System.Drawing.Size(76, 31);
            this.mainPartsDgvLablel.TabIndex = 1;
            this.mainPartsDgvLablel.Text = "Parts";
            // 
            // mainPartSearchTextBox
            // 
            this.mainPartSearchTextBox.AcceptsReturn = true;
            this.mainPartSearchTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mainPartSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainPartSearchTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPartSearchTextBox.Location = new System.Drawing.Point(355, 77);
            this.mainPartSearchTextBox.Name = "mainPartSearchTextBox";
            this.mainPartSearchTextBox.Size = new System.Drawing.Size(186, 21);
            this.mainPartSearchTextBox.TabIndex = 1;
            this.mainPartSearchTextBox.TextChanged += new System.EventHandler(this.mainPartSearchTextBox_TextChanged);
            // 
            // mainProductSearchTextBox
            // 
            this.mainProductSearchTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mainProductSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainProductSearchTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainProductSearchTextBox.Location = new System.Drawing.Point(895, 77);
            this.mainProductSearchTextBox.Name = "mainProductSearchTextBox";
            this.mainProductSearchTextBox.Size = new System.Drawing.Size(186, 21);
            this.mainProductSearchTextBox.TabIndex = 6;
            this.mainProductSearchTextBox.TextChanged += new System.EventHandler(this.mainProductSearchTextBox_TextChanged);
            // 
            // mainProductSearchButton
            // 
            this.mainProductSearchButton.BackColor = System.Drawing.Color.Transparent;
            this.mainProductSearchButton.FlatAppearance.BorderSize = 0;
            this.mainProductSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainProductSearchButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainProductSearchButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainProductSearchButton.Image = global::VictorJOlivoRamirez_InventoryManagementSystem2.Properties.Resources.Webp_net_resizeimage;
            this.mainProductSearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mainProductSearchButton.Location = new System.Drawing.Point(768, 69);
            this.mainProductSearchButton.Name = "mainProductSearchButton";
            this.mainProductSearchButton.Size = new System.Drawing.Size(118, 38);
            this.mainProductSearchButton.TabIndex = 7;
            this.mainProductSearchButton.Text = "Search";
            this.mainProductSearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainProductSearchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.mainProductSearchButton.UseVisualStyleBackColor = false;
            this.mainProductSearchButton.Click += new System.EventHandler(this.mainProductSearchButton_Click);
            // 
            // mainProductsDgvLabel
            // 
            this.mainProductsDgvLabel.AutoSize = true;
            this.mainProductsDgvLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainProductsDgvLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainProductsDgvLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainProductsDgvLabel.Location = new System.Drawing.Point(570, 81);
            this.mainProductsDgvLabel.Name = "mainProductsDgvLabel";
            this.mainProductsDgvLabel.Size = new System.Drawing.Size(122, 31);
            this.mainProductsDgvLabel.TabIndex = 4;
            this.mainProductsDgvLabel.Text = "Products";
            // 
            // mainPartsDgv
            // 
            this.mainPartsDgv.AllowUserToAddRows = false;
            this.mainPartsDgv.AllowUserToDeleteRows = false;
            this.mainPartsDgv.AllowUserToResizeColumns = false;
            this.mainPartsDgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.mainPartsDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.mainPartsDgv.AutoGenerateColumns = false;
            this.mainPartsDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainPartsDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.mainPartsDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainPartsDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.mainPartsDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainPartsDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.mainPartsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainPartsDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.inStockDataGridViewTextBoxColumn1,
            this.minDataGridViewTextBoxColumn1,
            this.maxDataGridViewTextBoxColumn1});
            this.mainPartsDgv.DataSource = this.partBindingSource;
            this.mainPartsDgv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mainPartsDgv.Location = new System.Drawing.Point(33, 115);
            this.mainPartsDgv.MaximumSize = new System.Drawing.Size(507, 347);
            this.mainPartsDgv.MinimumSize = new System.Drawing.Size(507, 347);
            this.mainPartsDgv.Name = "mainPartsDgv";
            this.mainPartsDgv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainPartsDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mainPartsDgv.RowHeadersVisible = false;
            this.mainPartsDgv.RowHeadersWidth = 62;
            this.mainPartsDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.mainPartsDgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.mainPartsDgv.RowTemplate.Height = 28;
            this.mainPartsDgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mainPartsDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainPartsDgv.Size = new System.Drawing.Size(507, 347);
            this.mainPartsDgv.TabIndex = 7;
            this.mainPartsDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainPartsDgv_CellClick);
            // 
            // mainProductsDgv
            // 
            this.mainProductsDgv.AllowUserToAddRows = false;
            this.mainProductsDgv.AllowUserToDeleteRows = false;
            this.mainProductsDgv.AllowUserToResizeColumns = false;
            this.mainProductsDgv.AllowUserToResizeRows = false;
            this.mainProductsDgv.AutoGenerateColumns = false;
            this.mainProductsDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainProductsDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.mainProductsDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainProductsDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.mainProductsDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.mainProductsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainProductsDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.inStockDataGridViewTextBoxColumn,
            this.minDataGridViewTextBoxColumn,
            this.maxDataGridViewTextBoxColumn});
            this.mainProductsDgv.DataSource = this.productBindingSource;
            this.mainProductsDgv.Location = new System.Drawing.Point(575, 116);
            this.mainProductsDgv.MaximumSize = new System.Drawing.Size(507, 347);
            this.mainProductsDgv.MinimumSize = new System.Drawing.Size(507, 347);
            this.mainProductsDgv.Name = "mainProductsDgv";
            this.mainProductsDgv.ReadOnly = true;
            this.mainProductsDgv.RowHeadersVisible = false;
            this.mainProductsDgv.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.mainProductsDgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.mainProductsDgv.RowTemplate.Height = 28;
            this.mainProductsDgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mainProductsDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainProductsDgv.Size = new System.Drawing.Size(507, 347);
            this.mainProductsDgv.TabIndex = 8;
            this.mainProductsDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainProductsDgv_CellClick);
            // 
            // mainAddPartButton
            // 
            this.mainAddPartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainAddPartButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainAddPartButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainAddPartButton.Location = new System.Drawing.Point(297, 468);
            this.mainAddPartButton.Name = "mainAddPartButton";
            this.mainAddPartButton.Size = new System.Drawing.Size(65, 40);
            this.mainAddPartButton.TabIndex = 3;
            this.mainAddPartButton.Text = "Add";
            this.mainAddPartButton.UseVisualStyleBackColor = true;
            this.mainAddPartButton.Click += new System.EventHandler(this.mainAddPartButton_Click);
            // 
            // mainAddProductButton
            // 
            this.mainAddProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainAddProductButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainAddProductButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainAddProductButton.Location = new System.Drawing.Point(837, 468);
            this.mainAddProductButton.Name = "mainAddProductButton";
            this.mainAddProductButton.Size = new System.Drawing.Size(65, 40);
            this.mainAddProductButton.TabIndex = 8;
            this.mainAddProductButton.Text = "Add";
            this.mainAddProductButton.UseVisualStyleBackColor = true;
            this.mainAddProductButton.Click += new System.EventHandler(this.mainAddProductButton_Click);
            // 
            // mainModifyPartButton
            // 
            this.mainModifyPartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainModifyPartButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainModifyPartButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainModifyPartButton.Location = new System.Drawing.Point(368, 468);
            this.mainModifyPartButton.Name = "mainModifyPartButton";
            this.mainModifyPartButton.Size = new System.Drawing.Size(88, 40);
            this.mainModifyPartButton.TabIndex = 4;
            this.mainModifyPartButton.Text = "Modify";
            this.mainModifyPartButton.UseVisualStyleBackColor = true;
            this.mainModifyPartButton.Click += new System.EventHandler(this.mainModifyPartButton_Click);
            // 
            // mainModifyProductButton
            // 
            this.mainModifyProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainModifyProductButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainModifyProductButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainModifyProductButton.Location = new System.Drawing.Point(908, 469);
            this.mainModifyProductButton.Name = "mainModifyProductButton";
            this.mainModifyProductButton.Size = new System.Drawing.Size(88, 40);
            this.mainModifyProductButton.TabIndex = 9;
            this.mainModifyProductButton.Text = "Modify";
            this.mainModifyProductButton.UseVisualStyleBackColor = true;
            this.mainModifyProductButton.Click += new System.EventHandler(this.mainModifyProductButton_Click);
            // 
            // mainDeletePartButton
            // 
            this.mainDeletePartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainDeletePartButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDeletePartButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainDeletePartButton.Location = new System.Drawing.Point(462, 468);
            this.mainDeletePartButton.Name = "mainDeletePartButton";
            this.mainDeletePartButton.Size = new System.Drawing.Size(79, 40);
            this.mainDeletePartButton.TabIndex = 5;
            this.mainDeletePartButton.Text = "Delete";
            this.mainDeletePartButton.UseVisualStyleBackColor = true;
            this.mainDeletePartButton.Click += new System.EventHandler(this.mainDeletePartButton_Click);
            // 
            // mainDeleteProductButton
            // 
            this.mainDeleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainDeleteProductButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDeleteProductButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainDeleteProductButton.Location = new System.Drawing.Point(1002, 468);
            this.mainDeleteProductButton.Name = "mainDeleteProductButton";
            this.mainDeleteProductButton.Size = new System.Drawing.Size(79, 40);
            this.mainDeleteProductButton.TabIndex = 10;
            this.mainDeleteProductButton.Text = "Delete";
            this.mainDeleteProductButton.UseVisualStyleBackColor = true;
            this.mainDeleteProductButton.Click += new System.EventHandler(this.mainDeleteProductButton_Click);
            // 
            // mainExitButton
            // 
            this.mainExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainExitButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainExitButton.Location = new System.Drawing.Point(1006, 545);
            this.mainExitButton.Name = "mainExitButton";
            this.mainExitButton.Size = new System.Drawing.Size(75, 40);
            this.mainExitButton.TabIndex = 11;
            this.mainExitButton.Text = "Exit";
            this.mainExitButton.UseVisualStyleBackColor = true;
            this.mainExitButton.Click += new System.EventHandler(this.mainExitButton_Click);
            // 
            // mainPartSearchButton
            // 
            this.mainPartSearchButton.BackColor = System.Drawing.Color.Transparent;
            this.mainPartSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainPartSearchButton.FlatAppearance.BorderSize = 0;
            this.mainPartSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainPartSearchButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPartSearchButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainPartSearchButton.Image = global::VictorJOlivoRamirez_InventoryManagementSystem2.Properties.Resources.Webp_net_resizeimage;
            this.mainPartSearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mainPartSearchButton.Location = new System.Drawing.Point(229, 68);
            this.mainPartSearchButton.Name = "mainPartSearchButton";
            this.mainPartSearchButton.Size = new System.Drawing.Size(118, 38);
            this.mainPartSearchButton.TabIndex = 2;
            this.mainPartSearchButton.Text = "Search";
            this.mainPartSearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainPartSearchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.mainPartSearchButton.UseVisualStyleBackColor = false;
            this.mainPartSearchButton.Click += new System.EventHandler(this.mainPartSearchButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1057, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.mainExitButton_Click);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID ";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            this.inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn.HeaderText = "InStock";
            this.inStockDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            this.inStockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minDataGridViewTextBoxColumn
            // 
            this.minDataGridViewTextBoxColumn.DataPropertyName = "Min";
            this.minDataGridViewTextBoxColumn.HeaderText = "Min";
            this.minDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            this.minDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxDataGridViewTextBoxColumn
            // 
            this.maxDataGridViewTextBoxColumn.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            this.maxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(VictorJOlivoRamirez_InventoryManagementSystem2.Product);
            // 
            // partIDDataGridViewTextBoxColumn
            // 
            this.partIDDataGridViewTextBoxColumn.DataPropertyName = "PartID";
            this.partIDDataGridViewTextBoxColumn.HeaderText = "PartID";
            this.partIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.partIDDataGridViewTextBoxColumn.Name = "partIDDataGridViewTextBoxColumn";
            this.partIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // inStockDataGridViewTextBoxColumn1
            // 
            this.inStockDataGridViewTextBoxColumn1.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn1.HeaderText = "InStock";
            this.inStockDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.inStockDataGridViewTextBoxColumn1.Name = "inStockDataGridViewTextBoxColumn1";
            this.inStockDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // minDataGridViewTextBoxColumn1
            // 
            this.minDataGridViewTextBoxColumn1.DataPropertyName = "Min";
            this.minDataGridViewTextBoxColumn1.HeaderText = "Min";
            this.minDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.minDataGridViewTextBoxColumn1.Name = "minDataGridViewTextBoxColumn1";
            this.minDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // maxDataGridViewTextBoxColumn1
            // 
            this.maxDataGridViewTextBoxColumn1.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn1.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.maxDataGridViewTextBoxColumn1.Name = "maxDataGridViewTextBoxColumn1";
            this.maxDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(VictorJOlivoRamirez_InventoryManagementSystem2.Part);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1112, 605);
            this.Controls.Add(this.mainExitButton);
            this.Controls.Add(this.mainDeleteProductButton);
            this.Controls.Add(this.mainDeletePartButton);
            this.Controls.Add(this.mainModifyProductButton);
            this.Controls.Add(this.mainModifyPartButton);
            this.Controls.Add(this.mainAddProductButton);
            this.Controls.Add(this.mainAddPartButton);
            this.Controls.Add(this.mainProductsDgv);
            this.Controls.Add(this.mainPartsDgv);
            this.Controls.Add(this.mainProductSearchTextBox);
            this.Controls.Add(this.mainProductSearchButton);
            this.Controls.Add(this.mainProductsDgvLabel);
            this.Controls.Add(this.mainPartSearchTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainPartSearchButton);
            this.Controls.Add(this.mainPartsDgvLablel);
            this.Controls.Add(this.mainTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1112, 605);
            this.MinimumSize = new System.Drawing.Size(1112, 605);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainScreen_FormClosed);
            this.Shown += new System.EventHandler(this.MainScreen_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.mainPartsDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainProductsDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTitleLabel;
        private System.Windows.Forms.Label mainPartsDgvLablel;
        private System.Windows.Forms.Button mainPartSearchButton;
        private System.Windows.Forms.TextBox mainPartSearchTextBox;
        private System.Windows.Forms.TextBox mainProductSearchTextBox;
        private System.Windows.Forms.Button mainProductSearchButton;
        private System.Windows.Forms.Label mainProductsDgvLabel;
        private System.Windows.Forms.DataGridView mainPartsDgv;
        private System.Windows.Forms.DataGridView mainProductsDgv;
        private System.Windows.Forms.Button mainAddPartButton;
        private System.Windows.Forms.Button mainAddProductButton;
        private System.Windows.Forms.Button mainModifyPartButton;
        private System.Windows.Forms.Button mainModifyProductButton;
        private System.Windows.Forms.Button mainDeletePartButton;
        private System.Windows.Forms.Button mainDeleteProductButton;
        private System.Windows.Forms.Button mainExitButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource partBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}

