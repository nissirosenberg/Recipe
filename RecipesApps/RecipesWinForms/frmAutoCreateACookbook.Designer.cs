namespace RecipesWinForms
{
    partial class frmAutoCreateACookbook
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
            btnCreateCookbook = new Button();
            lstUsers = new ComboBox();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(btnCreateCookbook, 1, 0);
            tblMain.Controls.Add(lstUsers, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Size = new Size(622, 148);
            tblMain.TabIndex = 0;
            // 
            // btnCreateCookbook
            // 
            btnCreateCookbook.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCreateCookbook.AutoSize = true;
            btnCreateCookbook.Location = new Point(361, 58);
            btnCreateCookbook.Margin = new Padding(50, 3, 50, 3);
            btnCreateCookbook.Name = "btnCreateCookbook";
            btnCreateCookbook.Size = new Size(211, 31);
            btnCreateCookbook.TabIndex = 1;
            btnCreateCookbook.Text = "Create Cookbook";
            btnCreateCookbook.UseVisualStyleBackColor = true;
            // 
            // lstUsers
            // 
            lstUsers.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lstUsers.FormattingEnabled = true;
            lstUsers.Location = new Point(50, 62);
            lstUsers.Margin = new Padding(50, 3, 50, 3);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(211, 29);
            lstUsers.TabIndex = 0;
            // 
            // frmAutoCreateACookbook
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(622, 148);
            Controls.Add(tblMain);
            Font = new Font("Assistant SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAutoCreateACookbook";
            Text = "Auto-Create A Cookbook";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnCreateCookbook;
        private ComboBox lstUsers;
    }
}