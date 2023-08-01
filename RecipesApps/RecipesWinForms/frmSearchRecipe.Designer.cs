namespace RecipesWinForms
{
    partial class frmSearchRecipe
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
            gRecipe = new DataGridView();
            tblMain = new TableLayoutPanel();
            tblHeader = new TableLayoutPanel();
            lblRecipeName = new Label();
            txtRecipeName = new TextBox();
            btnSearch = new Button();
            btnNew = new Button();
            ((System.ComponentModel.ISupportInitialize)gRecipe).BeginInit();
            tblMain.SuspendLayout();
            tblHeader.SuspendLayout();
            SuspendLayout();
            // 
            // gRecipe
            // 
            gRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gRecipe.Dock = DockStyle.Fill;
            gRecipe.Location = new Point(3, 46);
            gRecipe.Name = "gRecipe";
            gRecipe.RowTemplate.Height = 25;
            gRecipe.Size = new Size(371, 194);
            gRecipe.TabIndex = 1;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(tblHeader, 0, 0);
            tblMain.Controls.Add(gRecipe, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(377, 243);
            tblMain.TabIndex = 1;
            // 
            // tblHeader
            // 
            tblHeader.AutoSize = true;
            tblHeader.ColumnCount = 4;
            tblHeader.ColumnStyles.Add(new ColumnStyle());
            tblHeader.ColumnStyles.Add(new ColumnStyle());
            tblHeader.ColumnStyles.Add(new ColumnStyle());
            tblHeader.ColumnStyles.Add(new ColumnStyle());
            tblHeader.Controls.Add(lblRecipeName, 0, 0);
            tblHeader.Controls.Add(txtRecipeName, 1, 0);
            tblHeader.Controls.Add(btnSearch, 2, 0);
            tblHeader.Controls.Add(btnNew, 3, 0);
            tblHeader.Location = new Point(3, 3);
            tblHeader.Name = "tblHeader";
            tblHeader.RowCount = 1;
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblHeader.Size = new Size(353, 37);
            tblHeader.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.Anchor = AnchorStyles.Left;
            lblRecipeName.AutoSize = true;
            lblRecipeName.Location = new Point(3, 11);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(80, 15);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe Name:";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(89, 3);
            txtRecipeName.Multiline = true;
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(100, 31);
            txtRecipeName.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Left;
            btnSearch.AutoSize = true;
            btnSearch.BackColor = Color.DodgerBlue;
            btnSearch.Location = new Point(195, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 31);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.DodgerBlue;
            btnNew.Dock = DockStyle.Fill;
            btnNew.Location = new Point(276, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(74, 31);
            btnNew.TabIndex = 3;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // frmSearchRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 243);
            Controls.Add(tblMain);
            Name = "frmSearchRecipe";
            Text = "Search Recipe";
            ((System.ComponentModel.ISupportInitialize)gRecipe).EndInit();
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblHeader.ResumeLayout(false);
            tblHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gRecipe;
        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblHeader;
        private Label lblRecipeName;
        private TextBox txtRecipeName;
        private Button btnSearch;
        private Button btnNew;
    }
}