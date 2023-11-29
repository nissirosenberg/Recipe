namespace RecipesWinForms
{
    partial class frmRecipeList
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
            btnNewRecipe = new Button();
            gRecipeList = new DataGridView();
            tblRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipeList).BeginInit();
            SuspendLayout();
            // 
            // tblRecipe
            // 
            tblRecipe.ColumnCount = 1;
            tblRecipe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblRecipe.Controls.Add(btnNewRecipe, 0, 0);
            tblRecipe.Controls.Add(gRecipeList, 0, 1);
            tblRecipe.Dock = DockStyle.Fill;
            tblRecipe.Location = new Point(0, 0);
            tblRecipe.Margin = new Padding(3, 4, 3, 4);
            tblRecipe.Name = "tblRecipe";
            tblRecipe.RowCount = 2;
            tblRecipe.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tblRecipe.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tblRecipe.Size = new Size(601, 481);
            tblRecipe.TabIndex = 0;
            // 
            // btnNewRecipe
            // 
            btnNewRecipe.Anchor = AnchorStyles.Left;
            btnNewRecipe.BackColor = Color.LimeGreen;
            btnNewRecipe.Location = new Point(20, 12);
            btnNewRecipe.Margin = new Padding(20, 3, 3, 3);
            btnNewRecipe.Name = "btnNewRecipe";
            btnNewRecipe.Size = new Size(155, 48);
            btnNewRecipe.TabIndex = 1;
            btnNewRecipe.Text = "&New Recipe";
            btnNewRecipe.UseVisualStyleBackColor = false;
            // 
            // gRecipeList
            // 
            gRecipeList.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            gRecipeList.BackgroundColor = Color.White;
            gRecipeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gRecipeList.Location = new Point(20, 132);
            gRecipeList.Margin = new Padding(20, 3, 20, 3);
            gRecipeList.Name = "gRecipeList";
            gRecipeList.RowTemplate.Height = 25;
            gRecipeList.Size = new Size(561, 289);
            gRecipeList.TabIndex = 0;
            // 
            // frmRecipeList
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(601, 481);
            Controls.Add(tblRecipe);
            Font = new Font("Assistant SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRecipeList";
            Text = "Recipe List";
            tblRecipe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gRecipeList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblRecipe;
        private Button btnNewRecipe;
        private DataGridView gRecipeList;
    }
}