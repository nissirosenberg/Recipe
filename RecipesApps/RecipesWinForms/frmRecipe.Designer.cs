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
            tblMain = new TableLayoutPanel();
            lblRecipeName = new Label();
            lblCalories = new Label();
            lblDateDrafted = new Label();
            txtRecipeName = new TextBox();
            txtCalories = new TextBox();
            txtDateDrafted = new TextBox();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            lblCurrentStatus = new Label();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            txtCurrentStatus = new TextBox();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(lblCalories, 0, 1);
            tblMain.Controls.Add(lblDateDrafted, 0, 2);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Controls.Add(txtCalories, 1, 1);
            tblMain.Controls.Add(txtDateDrafted, 1, 2);
            tblMain.Controls.Add(lblDatePublished, 0, 3);
            tblMain.Controls.Add(lblDateArchived, 0, 4);
            tblMain.Controls.Add(lblCurrentStatus, 0, 5);
            tblMain.Controls.Add(txtDatePublished, 1, 3);
            tblMain.Controls.Add(txtDateArchived, 1, 4);
            tblMain.Controls.Add(txtCurrentStatus, 1, 5);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 6;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tblMain.Size = new Size(338, 207);
            tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.Anchor = AnchorStyles.Left;
            lblRecipeName.AutoSize = true;
            lblRecipeName.Location = new Point(3, 6);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(105, 21);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe Name:";
            // 
            // lblCalories
            // 
            lblCalories.Anchor = AnchorStyles.Left;
            lblCalories.AutoSize = true;
            lblCalories.Location = new Point(3, 40);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(69, 21);
            lblCalories.TabIndex = 1;
            lblCalories.Text = "Calories:";
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.Anchor = AnchorStyles.Left;
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.Location = new Point(3, 74);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(98, 21);
            lblDateDrafted.TabIndex = 2;
            lblDateDrafted.Text = "Date Drafted";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(123, 3);
            txtRecipeName.Multiline = true;
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(212, 28);
            txtRecipeName.TabIndex = 3;
            // 
            // txtCalories
            // 
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Location = new Point(123, 37);
            txtCalories.Multiline = true;
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(212, 28);
            txtCalories.TabIndex = 4;
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Dock = DockStyle.Fill;
            txtDateDrafted.Location = new Point(123, 71);
            txtDateDrafted.Multiline = true;
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.Size = new Size(212, 28);
            txtDateDrafted.TabIndex = 5;
            // 
            // lblDatePublished
            // 
            lblDatePublished.Anchor = AnchorStyles.Left;
            lblDatePublished.AutoSize = true;
            lblDatePublished.Location = new Point(3, 108);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(114, 21);
            lblDatePublished.TabIndex = 6;
            lblDatePublished.Text = "Date Published";
            // 
            // lblDateArchived
            // 
            lblDateArchived.Anchor = AnchorStyles.Left;
            lblDateArchived.AutoSize = true;
            lblDateArchived.Location = new Point(3, 142);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(107, 21);
            lblDateArchived.TabIndex = 7;
            lblDateArchived.Text = "Date Archived";
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.Anchor = AnchorStyles.Left;
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Location = new Point(3, 178);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(109, 21);
            lblCurrentStatus.TabIndex = 8;
            lblCurrentStatus.Text = "Current Status";
            // 
            // txtDatePublished
            // 
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Location = new Point(123, 105);
            txtDatePublished.Multiline = true;
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(212, 28);
            txtDatePublished.TabIndex = 9;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Location = new Point(123, 139);
            txtDateArchived.Multiline = true;
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(212, 28);
            txtDateArchived.TabIndex = 10;
            // 
            // txtCurrentStatus
            // 
            txtCurrentStatus.Dock = DockStyle.Fill;
            txtCurrentStatus.Location = new Point(123, 173);
            txtCurrentStatus.Multiline = true;
            txtCurrentStatus.Name = "txtCurrentStatus";
            txtCurrentStatus.Size = new Size(212, 31);
            txtCurrentStatus.TabIndex = 11;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 207);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmRecipe";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private Label lblCalories;
        private Label lblDateDrafted;
        private TextBox txtRecipeName;
        private TextBox txtCalories;
        private TextBox txtDateDrafted;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private Label lblCurrentStatus;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private TextBox txtCurrentStatus;
    }
}