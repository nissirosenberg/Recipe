namespace RecipesWinForms
{
    partial class frmCloneARecipe
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
            btnClone = new Button();
            lstRecipeName = new ComboBox();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(btnClone, 0, 1);
            tblMain.Controls.Add(lstRecipeName, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(554, 327);
            tblMain.TabIndex = 0;
            // 
            // btnClone
            // 
            btnClone.Location = new Point(3, 152);
            btnClone.Name = "btnClone";
            btnClone.Size = new Size(151, 36);
            btnClone.TabIndex = 0;
            btnClone.Text = "Clone";
            btnClone.UseVisualStyleBackColor = true;
            // 
            // lstRecipeName
            // 
            lstRecipeName.Anchor = AnchorStyles.Left;
            lstRecipeName.FormattingEnabled = true;
            lstRecipeName.Location = new Point(3, 60);
            lstRecipeName.Margin = new Padding(3, 60, 3, 60);
            lstRecipeName.Name = "lstRecipeName";
            lstRecipeName.Size = new Size(335, 29);
            lstRecipeName.TabIndex = 1;
            // 
            // frmCloneARecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 327);
            Controls.Add(tblMain);
            Font = new Font("Assistant SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCloneARecipe";
            Text = "Clone A Recipe";
            tblMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnClone;
        private ComboBox lstRecipeName;
    }
}