namespace RecipesWinForms
{
    partial class frmChangeStatus
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
            tblStatusDates = new TableLayoutPanel();
            lblDrafted = new Label();
            lblPublished = new Label();
            lblArchived = new Label();
            txtDateDrafted = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            lblStatusDates = new Label();
            tblStatuses = new TableLayoutPanel();
            btnDraft = new Button();
            btnArchive = new Button();
            btnPublish = new Button();
            lblRecipeName = new Label();
            tblCurrentStatus = new TableLayoutPanel();
            lblCurrentStatus = new Label();
            lblCurrentStatusText = new Label();
            tblMain.SuspendLayout();
            tblStatusDates.SuspendLayout();
            tblStatuses.SuspendLayout();
            tblCurrentStatus.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(tblStatusDates, 0, 2);
            tblMain.Controls.Add(tblStatuses, 0, 3);
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(tblCurrentStatus, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 19.4908085F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 19.4908F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 19.4908F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 41.5275879F));
            tblMain.Size = new Size(731, 580);
            tblMain.TabIndex = 0;
            // 
            // tblStatusDates
            // 
            tblStatusDates.ColumnCount = 5;
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblStatusDates.Controls.Add(lblDrafted, 1, 0);
            tblStatusDates.Controls.Add(lblPublished, 2, 0);
            tblStatusDates.Controls.Add(lblArchived, 3, 0);
            tblStatusDates.Controls.Add(txtDateDrafted, 1, 1);
            tblStatusDates.Controls.Add(txtDatePublished, 2, 1);
            tblStatusDates.Controls.Add(txtDateArchived, 3, 1);
            tblStatusDates.Controls.Add(lblStatusDates, 0, 1);
            tblStatusDates.Dock = DockStyle.Fill;
            tblStatusDates.Location = new Point(3, 229);
            tblStatusDates.Name = "tblStatusDates";
            tblStatusDates.RowCount = 2;
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatusDates.Size = new Size(725, 107);
            tblStatusDates.TabIndex = 2;
            // 
            // lblDrafted
            // 
            lblDrafted.Anchor = AnchorStyles.Bottom;
            lblDrafted.AutoSize = true;
            lblDrafted.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDrafted.Location = new Point(183, 29);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(69, 24);
            lblDrafted.TabIndex = 1;
            lblDrafted.Text = "Drafted";
            // 
            // lblPublished
            // 
            lblPublished.Anchor = AnchorStyles.Bottom;
            lblPublished.AutoSize = true;
            lblPublished.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPublished.Location = new Point(315, 29);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(94, 24);
            lblPublished.TabIndex = 3;
            lblPublished.Text = "Published";
            // 
            // lblArchived
            // 
            lblArchived.Anchor = AnchorStyles.Bottom;
            lblArchived.AutoSize = true;
            lblArchived.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblArchived.Location = new Point(465, 29);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(85, 24);
            lblArchived.TabIndex = 5;
            lblArchived.Text = "Archived";
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDateDrafted.BackColor = Color.White;
            txtDateDrafted.Font = new Font("Assistant SemiBold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateDrafted.Location = new Point(148, 64);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.ReadOnly = true;
            txtDateDrafted.Size = new Size(139, 32);
            txtDateDrafted.TabIndex = 2;
            txtDateDrafted.TabStop = false;
            txtDateDrafted.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDatePublished.BackColor = Color.White;
            txtDatePublished.Font = new Font("Assistant SemiBold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDatePublished.Location = new Point(293, 64);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.ReadOnly = true;
            txtDatePublished.Size = new Size(139, 32);
            txtDatePublished.TabIndex = 4;
            txtDatePublished.TabStop = false;
            txtDatePublished.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDateArchived.BackColor = Color.White;
            txtDateArchived.Font = new Font("Assistant SemiBold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateArchived.Location = new Point(438, 64);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.ReadOnly = true;
            txtDateArchived.Size = new Size(139, 32);
            txtDateArchived.TabIndex = 6;
            txtDateArchived.TabStop = false;
            txtDateArchived.TextAlign = HorizontalAlignment.Center;
            // 
            // lblStatusDates
            // 
            lblStatusDates.Anchor = AnchorStyles.Right;
            lblStatusDates.AutoSize = true;
            lblStatusDates.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatusDates.Location = new Point(30, 68);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(112, 24);
            lblStatusDates.TabIndex = 0;
            lblStatusDates.Text = "Status Dates";
            // 
            // tblStatuses
            // 
            tblStatuses.ColumnCount = 3;
            tblStatuses.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatuses.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatuses.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatuses.Controls.Add(btnDraft, 0, 0);
            tblStatuses.Controls.Add(btnArchive, 2, 0);
            tblStatuses.Controls.Add(btnPublish, 1, 0);
            tblStatuses.Dock = DockStyle.Fill;
            tblStatuses.Location = new Point(3, 342);
            tblStatuses.Name = "tblStatuses";
            tblStatuses.RowCount = 1;
            tblStatuses.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblStatuses.Size = new Size(725, 235);
            tblStatuses.TabIndex = 0;
            // 
            // btnDraft
            // 
            btnDraft.Anchor = AnchorStyles.None;
            btnDraft.AutoSize = true;
            btnDraft.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDraft.Location = new Point(13, 78);
            btnDraft.Name = "btnDraft";
            btnDraft.Size = new Size(214, 78);
            btnDraft.TabIndex = 0;
            btnDraft.Text = "Draft";
            btnDraft.UseVisualStyleBackColor = true;
            // 
            // btnArchive
            // 
            btnArchive.Anchor = AnchorStyles.None;
            btnArchive.AutoSize = true;
            btnArchive.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnArchive.Location = new Point(496, 77);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(214, 81);
            btnArchive.TabIndex = 2;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = true;
            // 
            // btnPublish
            // 
            btnPublish.Anchor = AnchorStyles.None;
            btnPublish.AutoSize = true;
            btnPublish.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPublish.Location = new Point(254, 78);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(214, 78);
            btnPublish.TabIndex = 1;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = true;
            // 
            // lblRecipeName
            // 
            lblRecipeName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblRecipeName.AutoSize = true;
            lblRecipeName.Font = new Font("Assistant SemiBold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecipeName.Location = new Point(3, 35);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(725, 42);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblCurrentStatus
            // 
            tblCurrentStatus.ColumnCount = 2;
            tblCurrentStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblCurrentStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblCurrentStatus.Controls.Add(lblCurrentStatus, 1, 0);
            tblCurrentStatus.Controls.Add(lblCurrentStatusText, 0, 0);
            tblCurrentStatus.Dock = DockStyle.Fill;
            tblCurrentStatus.Location = new Point(3, 116);
            tblCurrentStatus.Name = "tblCurrentStatus";
            tblCurrentStatus.RowCount = 1;
            tblCurrentStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblCurrentStatus.Size = new Size(725, 107);
            tblCurrentStatus.TabIndex = 3;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.Anchor = AnchorStyles.Left;
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Font = new Font("Assistant", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentStatus.Location = new Point(365, 37);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(0, 32);
            lblCurrentStatus.TabIndex = 2;
            lblCurrentStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentStatusText
            // 
            lblCurrentStatusText.Anchor = AnchorStyles.Right;
            lblCurrentStatusText.AutoSize = true;
            lblCurrentStatusText.Font = new Font("Assistant SemiBold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentStatusText.Location = new Point(194, 37);
            lblCurrentStatusText.Name = "lblCurrentStatusText";
            lblCurrentStatusText.Size = new Size(165, 32);
            lblCurrentStatusText.TabIndex = 3;
            lblCurrentStatusText.Text = "Current Status:";
            // 
            // frmChangeStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 580);
            Controls.Add(tblMain);
            Name = "frmChangeStatus";
            Text = "Change Status";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblStatusDates.ResumeLayout(false);
            tblStatusDates.PerformLayout();
            tblStatuses.ResumeLayout(false);
            tblStatuses.PerformLayout();
            tblCurrentStatus.ResumeLayout(false);
            tblCurrentStatus.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblStatusDates;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private Label lblStatusDates;
        private TextBox txtDateDrafted;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private TableLayoutPanel tblStatuses;
        private Button btnDraft;
        private Button btnArchive;
        private Button btnPublish;
        private Label lblRecipeName;
        private TableLayoutPanel tblCurrentStatus;
        private Label lblCurrentStatus;
        private Label lblCurrentStatusText;
    }
}