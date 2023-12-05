namespace RecipesWinForms
{
    partial class frmSpecificCookbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpecificCookbook));
            tblMain = new TableLayoutPanel();
            toolStrip1 = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            lblCookbookName = new Label();
            lblUser = new Label();
            lblPrice = new Label();
            lblActive = new Label();
            txtCookbookName = new TextBox();
            lstUserName = new ComboBox();
            cbxActive = new CheckBox();
            tblCookbookRecipes = new TableLayoutPanel();
            btnSaveCookbookRecipes = new Button();
            gCookbookRecipes = new DataGridView();
            tblPriceDateCreated = new TableLayoutPanel();
            txtPrice = new TextBox();
            txtDateCreated = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblDateCreated = new Label();
            tblMain.SuspendLayout();
            toolStrip1.SuspendLayout();
            tblCookbookRecipes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gCookbookRecipes).BeginInit();
            tblPriceDateCreated.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tblMain.Controls.Add(toolStrip1, 0, 0);
            tblMain.Controls.Add(lblCookbookName, 0, 1);
            tblMain.Controls.Add(lblUser, 0, 2);
            tblMain.Controls.Add(lblPrice, 0, 4);
            tblMain.Controls.Add(lblActive, 0, 5);
            tblMain.Controls.Add(txtCookbookName, 1, 1);
            tblMain.Controls.Add(lstUserName, 1, 2);
            tblMain.Controls.Add(cbxActive, 1, 5);
            tblMain.Controls.Add(tblCookbookRecipes, 0, 6);
            tblMain.Controls.Add(tblPriceDateCreated, 1, 4);
            tblMain.Controls.Add(tableLayoutPanel1, 1, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 7;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 213F));
            tblMain.Size = new Size(652, 644);
            tblMain.TabIndex = 0;
            // 
            // toolStrip1
            // 
            tblMain.SetColumnSpan(toolStrip1, 2);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete });
            toolStrip1.Location = new Point(4, 4);
            toolStrip1.Margin = new Padding(4);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(644, 28);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSave.Font = new Font("Assistant SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(47, 25);
            btnSave.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDelete.Font = new Font("Assistant SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(58, 25);
            btnDelete.Text = "Delete";
            // 
            // lblCookbookName
            // 
            lblCookbookName.Anchor = AnchorStyles.Left;
            lblCookbookName.AutoSize = true;
            lblCookbookName.Location = new Point(3, 50);
            lblCookbookName.Name = "lblCookbookName";
            lblCookbookName.Size = new Size(122, 21);
            lblCookbookName.TabIndex = 0;
            lblCookbookName.Text = "Cookbook Name";
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Left;
            lblUser.AutoSize = true;
            lblUser.Location = new Point(3, 100);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(41, 21);
            lblUser.TabIndex = 2;
            lblUser.Text = "User";
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Left;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(3, 200);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(44, 21);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price";
            // 
            // lblActive
            // 
            lblActive.Anchor = AnchorStyles.Left;
            lblActive.AutoSize = true;
            lblActive.Location = new Point(3, 250);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(52, 21);
            lblActive.TabIndex = 4;
            lblActive.Text = "Active";
            // 
            // txtCookbookName
            // 
            txtCookbookName.Anchor = AnchorStyles.Left;
            txtCookbookName.Location = new Point(131, 47);
            txtCookbookName.Name = "txtCookbookName";
            txtCookbookName.Size = new Size(249, 28);
            txtCookbookName.TabIndex = 1;
            // 
            // lstUserName
            // 
            lstUserName.Anchor = AnchorStyles.Left;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(131, 99);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(249, 29);
            lstUserName.TabIndex = 3;
            // 
            // cbxActive
            // 
            cbxActive.Anchor = AnchorStyles.Left;
            cbxActive.AutoSize = true;
            cbxActive.Location = new Point(131, 248);
            cbxActive.MaximumSize = new Size(40, 40);
            cbxActive.MinimumSize = new Size(25, 25);
            cbxActive.Name = "cbxActive";
            cbxActive.Size = new Size(25, 25);
            cbxActive.TabIndex = 5;
            cbxActive.UseVisualStyleBackColor = true;
            // 
            // tblCookbookRecipes
            // 
            tblCookbookRecipes.BackColor = SystemColors.ControlLight;
            tblCookbookRecipes.ColumnCount = 1;
            tblMain.SetColumnSpan(tblCookbookRecipes, 2);
            tblCookbookRecipes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblCookbookRecipes.Controls.Add(btnSaveCookbookRecipes, 0, 0);
            tblCookbookRecipes.Controls.Add(gCookbookRecipes, 0, 1);
            tblCookbookRecipes.Dock = DockStyle.Fill;
            tblCookbookRecipes.Location = new Point(3, 289);
            tblCookbookRecipes.Name = "tblCookbookRecipes";
            tblCookbookRecipes.RowCount = 2;
            tblCookbookRecipes.RowStyles.Add(new RowStyle());
            tblCookbookRecipes.RowStyles.Add(new RowStyle(SizeType.Percent, 72.94686F));
            tblCookbookRecipes.Size = new Size(646, 352);
            tblCookbookRecipes.TabIndex = 9;
            // 
            // btnSaveCookbookRecipes
            // 
            btnSaveCookbookRecipes.AutoSize = true;
            btnSaveCookbookRecipes.Location = new Point(3, 3);
            btnSaveCookbookRecipes.Name = "btnSaveCookbookRecipes";
            btnSaveCookbookRecipes.Size = new Size(75, 31);
            btnSaveCookbookRecipes.TabIndex = 0;
            btnSaveCookbookRecipes.Text = "Save";
            btnSaveCookbookRecipes.UseVisualStyleBackColor = true;
            // 
            // gCookbookRecipes
            // 
            gCookbookRecipes.BackgroundColor = Color.White;
            gCookbookRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gCookbookRecipes.Dock = DockStyle.Fill;
            gCookbookRecipes.Location = new Point(3, 40);
            gCookbookRecipes.Name = "gCookbookRecipes";
            gCookbookRecipes.RowTemplate.Height = 25;
            gCookbookRecipes.Size = new Size(640, 309);
            gCookbookRecipes.TabIndex = 1;
            // 
            // tblPriceDateCreated
            // 
            tblPriceDateCreated.ColumnCount = 2;
            tblPriceDateCreated.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPriceDateCreated.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPriceDateCreated.Controls.Add(txtPrice, 0, 0);
            tblPriceDateCreated.Controls.Add(txtDateCreated, 1, 0);
            tblPriceDateCreated.Dock = DockStyle.Fill;
            tblPriceDateCreated.Location = new Point(131, 189);
            tblPriceDateCreated.Name = "tblPriceDateCreated";
            tblPriceDateCreated.RowCount = 1;
            tblPriceDateCreated.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblPriceDateCreated.Size = new Size(518, 44);
            tblPriceDateCreated.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Left;
            txtPrice.Location = new Point(3, 8);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 28);
            txtPrice.TabIndex = 0;
            // 
            // txtDateCreated
            // 
            txtDateCreated.Anchor = AnchorStyles.Left;
            txtDateCreated.Enabled = false;
            txtDateCreated.Location = new Point(262, 8);
            txtDateCreated.Name = "txtDateCreated";
            txtDateCreated.Size = new Size(182, 28);
            txtDateCreated.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblDateCreated, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(131, 139);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(518, 44);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // lblDateCreated
            // 
            lblDateCreated.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDateCreated.AutoSize = true;
            lblDateCreated.Location = new Point(262, 23);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(96, 21);
            lblDateCreated.TabIndex = 0;
            lblDateCreated.Text = "DateCreated";
            // 
            // frmSpecificCookbook
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(652, 644);
            Controls.Add(tblMain);
            Font = new Font("Assistant SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(0, 7, 0, 7);
            Name = "frmSpecificCookbook";
            Text = "Cookbook";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tblCookbookRecipes.ResumeLayout(false);
            tblCookbookRecipes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gCookbookRecipes).EndInit();
            tblPriceDateCreated.ResumeLayout(false);
            tblPriceDateCreated.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private ToolStrip toolStrip1;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private Label lblCookbookName;
        private Label lblUser;
        private Label lblPrice;
        private Label lblActive;
        private TextBox txtCookbookName;
        private ComboBox lstUserName;
        private CheckBox cbxActive;
        private TableLayoutPanel tblCookbookRecipes;
        private Button btnSaveCookbookRecipes;
        private DataGridView gCookbookRecipes;
        private TableLayoutPanel tblPriceDateCreated;
        private TextBox txtPrice;
        private TextBox txtDateCreated;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblDateCreated;
    }
}