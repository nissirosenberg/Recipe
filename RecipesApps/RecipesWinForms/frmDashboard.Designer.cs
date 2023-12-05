namespace RecipesWinForms
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            tblMain = new TableLayoutPanel();
            tblButtons = new TableLayoutPanel();
            btnRecipeList = new Button();
            btnMealList = new Button();
            btnCookbookList = new Button();
            lblTite = new Label();
            lblDescription = new Label();
            gTotals = new DataGridView();
            tblMain.SuspendLayout();
            tblButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gTotals).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.BackColor = Color.White;
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblMain.Controls.Add(tblButtons, 1, 4);
            tblMain.Controls.Add(lblTite, 1, 1);
            tblMain.Controls.Add(lblDescription, 1, 2);
            tblMain.Controls.Add(gTotals, 1, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Font = new Font("Assistant SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(3, 4, 3, 4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 6;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(595, 502);
            tblMain.TabIndex = 0;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 3;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblButtons.Controls.Add(btnRecipeList, 0, 0);
            tblButtons.Controls.Add(btnMealList, 1, 0);
            tblButtons.Controls.Add(btnCookbookList, 2, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(122, 382);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle());
            tblButtons.Size = new Size(351, 94);
            tblButtons.TabIndex = 2;
            // 
            // btnRecipeList
            // 
            btnRecipeList.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnRecipeList.BackColor = Color.LimeGreen;
            btnRecipeList.Font = new Font("Assistant SemiBold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecipeList.Location = new Point(3, 23);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(111, 47);
            btnRecipeList.TabIndex = 0;
            btnRecipeList.Text = "&Recipe List";
            btnRecipeList.UseVisualStyleBackColor = false;
            // 
            // btnMealList
            // 
            btnMealList.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnMealList.BackColor = Color.LimeGreen;
            btnMealList.Font = new Font("Assistant SemiBold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnMealList.Location = new Point(120, 23);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(111, 47);
            btnMealList.TabIndex = 1;
            btnMealList.Text = "&Meal List";
            btnMealList.UseVisualStyleBackColor = false;
            // 
            // btnCookbookList
            // 
            btnCookbookList.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCookbookList.BackColor = Color.LimeGreen;
            btnCookbookList.Font = new Font("Assistant SemiBold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCookbookList.Location = new Point(237, 23);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(111, 47);
            btnCookbookList.TabIndex = 2;
            btnCookbookList.Text = "&Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = false;
            // 
            // lblTite
            // 
            lblTite.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTite.AutoSize = true;
            lblTite.Font = new Font("Assistant SemiBold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTite.Location = new Point(122, 40);
            lblTite.Name = "lblTite";
            lblTite.Size = new Size(351, 72);
            lblTite.TabIndex = 0;
            lblTite.Text = "Hearty Hearth Desktop App\r\n\r\n";
            lblTite.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Bottom;
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(123, 112);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(348, 147);
            lblDescription.TabIndex = 1;
            lblDescription.Text = resources.GetString("lblDescription.Text");
            lblDescription.TextAlign = ContentAlignment.BottomCenter;
            // 
            // gTotals
            // 
            gTotals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            gTotals.BackgroundColor = Color.White;
            gTotals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gTotals.Enabled = false;
            gTotals.Location = new Point(187, 262);
            gTotals.MultiSelect = false;
            gTotals.Name = "gTotals";
            gTotals.RowTemplate.Height = 25;
            gTotals.ScrollBars = ScrollBars.None;
            gTotals.Size = new Size(220, 114);
            gTotals.TabIndex = 3;
            gTotals.TabStop = false;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 502);
            Controls.Add(tblMain);
            Font = new Font("Assistant SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDashboard";
            Text = "Dashboard";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gTotals).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblButtons;
        private Label lblTite;
        private Label lblDescription;
        private DataGridView gTotals;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
    }
}