namespace RecipesWinForms
{
    partial class frmRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipe));
            tblMain = new TableLayoutPanel();
            lblRecipeName = new Label();
            lblCalories = new Label();
            lblDateDrafted = new Label();
            txtRecipeName = new TextBox();
            txtCalories = new TextBox();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            lblCurrentStatus = new Label();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            txtCurrentStatus = new TextBox();
            lblUserName = new Label();
            lblCuisineTypeName = new Label();
            dtpDateDrafted = new DateTimePicker();
            tsMain = new ToolStrip();
            btnDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnSave = new ToolStripButton();
            lstUserName = new ComboBox();
            lstCuisineTypeName = new ComboBox();
            tblMain.SuspendLayout();
            tsMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(lblCalories, 0, 3);
            tblMain.Controls.Add(lblDateDrafted, 0, 4);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Controls.Add(txtCalories, 1, 3);
            tblMain.Controls.Add(lblDatePublished, 0, 5);
            tblMain.Controls.Add(lblDateArchived, 0, 6);
            tblMain.Controls.Add(lblCurrentStatus, 0, 7);
            tblMain.Controls.Add(txtDatePublished, 1, 5);
            tblMain.Controls.Add(txtDateArchived, 1, 6);
            tblMain.Controls.Add(txtCurrentStatus, 1, 7);
            tblMain.Controls.Add(lblUserName, 0, 1);
            tblMain.Controls.Add(lblCuisineTypeName, 0, 2);
            tblMain.Controls.Add(dtpDateDrafted, 1, 4);
            tblMain.Controls.Add(tsMain, 1, 8);
            tblMain.Controls.Add(lstUserName, 1, 1);
            tblMain.Controls.Add(lstCuisineTypeName, 1, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 9;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.Size = new Size(425, 342);
            tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.Anchor = AnchorStyles.Left;
            lblRecipeName.AutoSize = true;
            lblRecipeName.Location = new Point(3, 8);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(105, 21);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe Name:";
            // 
            // lblCalories
            // 
            lblCalories.Anchor = AnchorStyles.Left;
            lblCalories.AutoSize = true;
            lblCalories.Location = new Point(3, 119);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(69, 21);
            lblCalories.TabIndex = 3;
            lblCalories.Text = "Calories:";
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.Anchor = AnchorStyles.Left;
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.Location = new Point(3, 156);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(101, 21);
            lblDateDrafted.TabIndex = 4;
            lblDateDrafted.Text = "Date Drafted:";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(126, 3);
            txtRecipeName.Multiline = true;
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(296, 31);
            txtRecipeName.TabIndex = 8;
            // 
            // txtCalories
            // 
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Location = new Point(126, 114);
            txtCalories.Multiline = true;
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(296, 31);
            txtCalories.TabIndex = 11;
            // 
            // lblDatePublished
            // 
            lblDatePublished.Anchor = AnchorStyles.Left;
            lblDatePublished.AutoSize = true;
            lblDatePublished.Location = new Point(3, 193);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(117, 21);
            lblDatePublished.TabIndex = 5;
            lblDatePublished.Text = "Date Published:";
            // 
            // lblDateArchived
            // 
            lblDateArchived.Anchor = AnchorStyles.Left;
            lblDateArchived.AutoSize = true;
            lblDateArchived.Location = new Point(3, 230);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(110, 21);
            lblDateArchived.TabIndex = 6;
            lblDateArchived.Text = "Date Archived:";
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.Anchor = AnchorStyles.Left;
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Location = new Point(3, 267);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(112, 21);
            lblCurrentStatus.TabIndex = 7;
            lblCurrentStatus.Text = "Current Status:";
            // 
            // txtDatePublished
            // 
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Location = new Point(126, 188);
            txtDatePublished.Multiline = true;
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.ReadOnly = true;
            txtDatePublished.Size = new Size(296, 31);
            txtDatePublished.TabIndex = 13;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Location = new Point(126, 225);
            txtDateArchived.Multiline = true;
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.ReadOnly = true;
            txtDateArchived.Size = new Size(296, 31);
            txtDateArchived.TabIndex = 14;
            // 
            // txtCurrentStatus
            // 
            txtCurrentStatus.Dock = DockStyle.Fill;
            txtCurrentStatus.Location = new Point(126, 262);
            txtCurrentStatus.Multiline = true;
            txtCurrentStatus.Name = "txtCurrentStatus";
            txtCurrentStatus.ReadOnly = true;
            txtCurrentStatus.Size = new Size(296, 31);
            txtCurrentStatus.TabIndex = 15;
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Left;
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(3, 45);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(91, 21);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User Name:";
            // 
            // lblCuisineTypeName
            // 
            lblCuisineTypeName.Anchor = AnchorStyles.Left;
            lblCuisineTypeName.AutoSize = true;
            lblCuisineTypeName.Location = new Point(3, 82);
            lblCuisineTypeName.Name = "lblCuisineTypeName";
            lblCuisineTypeName.Size = new Size(100, 21);
            lblCuisineTypeName.TabIndex = 2;
            lblCuisineTypeName.Text = "Cuisine Type:";
            // 
            // dtpDateDrafted
            // 
            dtpDateDrafted.Format = DateTimePickerFormat.Short;
            dtpDateDrafted.Location = new Point(126, 151);
            dtpDateDrafted.Name = "dtpDateDrafted";
            dtpDateDrafted.Size = new Size(144, 29);
            dtpDateDrafted.TabIndex = 12;
            // 
            // tsMain
            // 
            tsMain.Anchor = AnchorStyles.Right;
            tsMain.Dock = DockStyle.None;
            tsMain.Items.AddRange(new ToolStripItem[] { btnDelete, toolStripSeparator1, btnSave });
            tsMain.Location = new Point(302, 305);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(123, 28);
            tsMain.TabIndex = 4;
            tsMain.Text = "toolStrip1";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DodgerBlue;
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(58, 25);
            btnDelete.Text = "&Delete";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DodgerBlue;
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(47, 25);
            btnSave.Text = "&Save";
            // 
            // lstUserName
            // 
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(126, 40);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(161, 29);
            lstUserName.TabIndex = 9;
            // 
            // lstCuisineTypeName
            // 
            lstCuisineTypeName.FormattingEnabled = true;
            lstCuisineTypeName.ImeMode = ImeMode.NoControl;
            lstCuisineTypeName.Location = new Point(126, 77);
            lstCuisineTypeName.Name = "lstCuisineTypeName";
            lstCuisineTypeName.Size = new Size(161, 29);
            lstCuisineTypeName.TabIndex = 10;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 342);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmRecipe";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private Label lblCalories;
        private Label lblDateDrafted;
        private TextBox txtRecipeName;
        private TextBox txtCalories;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private Label lblCurrentStatus;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private Label lblUserName;
        private Label lblCuisineTypeName;
        private ToolStrip tsMain;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnSave;
        private DateTimePicker dtpDateDrafted;
        private ComboBox lstUserName;
        private ComboBox lstCuisineTypeName;
        private TextBox txtCurrentStatus;
    }
}