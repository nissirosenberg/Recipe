namespace RecipesWinForms
{
    partial class frmCookbookList
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
            tblRecipe = new TableLayoutPanel();
            btnNewCookbook = new Button();
            gCookbookList = new DataGridView();
            tblRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gCookbookList).BeginInit();
            SuspendLayout();
            // 
            // tblRecipe
            // 
            tblRecipe.ColumnCount = 1;
            tblRecipe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblRecipe.Controls.Add(btnNewCookbook, 0, 0);
            tblRecipe.Controls.Add(gCookbookList, 0, 1);
            tblRecipe.Dock = DockStyle.Fill;
            tblRecipe.Location = new Point(0, 0);
            tblRecipe.Margin = new Padding(3, 6, 3, 6);
            tblRecipe.Name = "tblRecipe";
            tblRecipe.RowCount = 2;
            tblRecipe.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tblRecipe.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tblRecipe.Size = new Size(610, 469);
            tblRecipe.TabIndex = 1;
            // 
            // btnNewCookbook
            // 
            btnNewCookbook.Anchor = AnchorStyles.Left;
            btnNewCookbook.BackColor = Color.LimeGreen;
            btnNewCookbook.Location = new Point(23, 11);
            btnNewCookbook.Margin = new Padding(23, 4, 3, 4);
            btnNewCookbook.Name = "btnNewCookbook";
            btnNewCookbook.Size = new Size(149, 47);
            btnNewCookbook.TabIndex = 0;
            btnNewCookbook.Text = "&New Cookbook";
            btnNewCookbook.UseVisualStyleBackColor = false;
            // 
            // gCookbookList
            // 
            gCookbookList.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            gCookbookList.BackgroundColor = Color.White;
            gCookbookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gCookbookList.Location = new Point(40, 105);
            gCookbookList.Margin = new Padding(40, 3, 40, 3);
            gCookbookList.Name = "gCookbookList";
            gCookbookList.RowTemplate.Height = 25;
            gCookbookList.Size = new Size(530, 329);
            gCookbookList.TabIndex = 1;
            // 
            // frmCookbookList
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(610, 469);
            Controls.Add(tblRecipe);
            Font = new Font("Assistant SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCookbookList";
            Text = "Cookbook List";
            tblRecipe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gCookbookList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblRecipe;
        private Button btnNewCookbook;
        private DataGridView gCookbookList;
    }
}