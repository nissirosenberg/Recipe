namespace RecipesWinForms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            mnuMain = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuFileDashboard = new ToolStripMenuItem();
            mnuRecipes = new ToolStripMenuItem();
            mnuRecipesList = new ToolStripMenuItem();
            mnuRecipesNewRecipe = new ToolStripMenuItem();
            mnuRecipesCloneARecipe = new ToolStripMenuItem();
            mnuMeals = new ToolStripMenuItem();
            mnuMealsList = new ToolStripMenuItem();
            mnuCookbooks = new ToolStripMenuItem();
            mnuCookbooksList = new ToolStripMenuItem();
            mnuCookbooksNewCookbook = new ToolStripMenuItem();
            mnuCookbooksAutoCreate = new ToolStripMenuItem();
            mnuDataMaintenance = new ToolStripMenuItem();
            mnuDataMaintenanceEditData = new ToolStripMenuItem();
            mnuWindowCascade = new ToolStripMenuItem();
            mnuTile = new ToolStripMenuItem();
            mnuCascade = new ToolStripMenuItem();
            tsMain = new ToolStrip();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Font = new Font("Assistant SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuFile, mnuRecipes, mnuMeals, mnuCookbooks, mnuDataMaintenance, mnuWindowCascade });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(955, 29);
            mnuMain.TabIndex = 0;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileDashboard });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(46, 25);
            mnuFile.Text = "File";
            // 
            // mnuFileDashboard
            // 
            mnuFileDashboard.Name = "mnuFileDashboard";
            mnuFileDashboard.Size = new Size(155, 26);
            mnuFileDashboard.Text = "Dashboard";
            // 
            // mnuRecipes
            // 
            mnuRecipes.DropDownItems.AddRange(new ToolStripItem[] { mnuRecipesList, mnuRecipesNewRecipe, mnuRecipesCloneARecipe });
            mnuRecipes.Name = "mnuRecipes";
            mnuRecipes.Size = new Size(74, 25);
            mnuRecipes.Text = "Recipes";
            // 
            // mnuRecipesList
            // 
            mnuRecipesList.Name = "mnuRecipesList";
            mnuRecipesList.Size = new Size(178, 26);
            mnuRecipesList.Text = "List";
            // 
            // mnuRecipesNewRecipe
            // 
            mnuRecipesNewRecipe.Name = "mnuRecipesNewRecipe";
            mnuRecipesNewRecipe.Size = new Size(178, 26);
            mnuRecipesNewRecipe.Text = "New Recipe";
            // 
            // mnuRecipesCloneARecipe
            // 
            mnuRecipesCloneARecipe.Name = "mnuRecipesCloneARecipe";
            mnuRecipesCloneARecipe.Size = new Size(178, 26);
            mnuRecipesCloneARecipe.Text = "Clone a Recipe";
            // 
            // mnuMeals
            // 
            mnuMeals.DropDownItems.AddRange(new ToolStripItem[] { mnuMealsList });
            mnuMeals.Name = "mnuMeals";
            mnuMeals.Size = new Size(61, 25);
            mnuMeals.Text = "Meals";
            // 
            // mnuMealsList
            // 
            mnuMealsList.Name = "mnuMealsList";
            mnuMealsList.Size = new Size(105, 26);
            mnuMealsList.Text = "List";
            // 
            // mnuCookbooks
            // 
            mnuCookbooks.DropDownItems.AddRange(new ToolStripItem[] { mnuCookbooksList, mnuCookbooksNewCookbook, mnuCookbooksAutoCreate });
            mnuCookbooks.Name = "mnuCookbooks";
            mnuCookbooks.Size = new Size(99, 25);
            mnuCookbooks.Text = "Cookbooks";
            // 
            // mnuCookbooksList
            // 
            mnuCookbooksList.Name = "mnuCookbooksList";
            mnuCookbooksList.Size = new Size(183, 26);
            mnuCookbooksList.Text = "List";
            // 
            // mnuCookbooksNewCookbook
            // 
            mnuCookbooksNewCookbook.Name = "mnuCookbooksNewCookbook";
            mnuCookbooksNewCookbook.Size = new Size(183, 26);
            mnuCookbooksNewCookbook.Text = "New Cookbook";
            // 
            // mnuCookbooksAutoCreate
            // 
            mnuCookbooksAutoCreate.Name = "mnuCookbooksAutoCreate";
            mnuCookbooksAutoCreate.Size = new Size(183, 26);
            mnuCookbooksAutoCreate.Text = "Auto-Create";
            // 
            // mnuDataMaintenance
            // 
            mnuDataMaintenance.DropDownItems.AddRange(new ToolStripItem[] { mnuDataMaintenanceEditData });
            mnuDataMaintenance.Name = "mnuDataMaintenance";
            mnuDataMaintenance.Size = new Size(145, 25);
            mnuDataMaintenance.Text = "Data Maintenance";
            // 
            // mnuDataMaintenanceEditData
            // 
            mnuDataMaintenanceEditData.Name = "mnuDataMaintenanceEditData";
            mnuDataMaintenanceEditData.Size = new Size(143, 26);
            mnuDataMaintenanceEditData.Text = "Edit Data";
            // 
            // mnuWindowCascade
            // 
            mnuWindowCascade.DropDownItems.AddRange(new ToolStripItem[] { mnuTile, mnuCascade });
            mnuWindowCascade.Name = "mnuWindowCascade";
            mnuWindowCascade.Size = new Size(78, 25);
            mnuWindowCascade.Text = "Window";
            // 
            // mnuTile
            // 
            mnuTile.Name = "mnuTile";
            mnuTile.Size = new Size(136, 26);
            mnuTile.Text = "Tile";
            // 
            // mnuCascade
            // 
            mnuCascade.Name = "mnuCascade";
            mnuCascade.Size = new Size(136, 26);
            mnuCascade.Text = "Cascade";
            // 
            // tsMain
            // 
            tsMain.Location = new Point(0, 29);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(955, 25);
            tsMain.TabIndex = 1;
            tsMain.Text = "toolStrip1";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(955, 688);
            Controls.Add(tsMain);
            Controls.Add(mnuMain);
            Font = new Font("Assistant SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = mnuMain;
            Margin = new Padding(4);
            Name = "frmMain";
            Text = "Hearty Hearth";
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileDashboard;
        private ToolStripMenuItem mnuRecipes;
        private ToolStripMenuItem mnuRecipesList;
        private ToolStripMenuItem mnuRecipesNewRecipe;
        private ToolStripMenuItem mnuRecipesCloneARecipe;
        private ToolStripMenuItem mnuMeals;
        private ToolStripMenuItem mnuMealsList;
        private ToolStripMenuItem mnuCookbooks;
        private ToolStripMenuItem mnuCookbooksList;
        private ToolStripMenuItem mnuCookbooksNewCookbook;
        private ToolStripMenuItem mnuCookbooksAutoCreate;
        private ToolStripMenuItem mnuDataMaintenance;
        private ToolStripMenuItem mnuDataMaintenanceEditData;
        private ToolStripMenuItem mnuWindowCascade;
        private ToolStripMenuItem mnuTile;
        private ToolStripMenuItem mnuCascade;
        private ToolStrip tsMain;
    }
}