﻿namespace RecipesWinForms
{
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            gRecipeList.CellDoubleClick += GRecipeList_CellDoubleClick;
            btnNewRecipe.Click += BtnNewRecipe_Click;
            gRecipeList.KeyDown += GRecipeList_KeyDown;
            this.Activated += FrmRecipeList_Activated;
        }


        private void FrmRecipeList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            gRecipeList.DataSource = RecipeList.GetRecipeList();
            WindowsFormsUtility.FormatGridForSearchResults(gRecipeList, "RecipeListGet");
        }

        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gRecipeList, rowindex, "RecipeId");
            }
            if (this.MdiParent != null & this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmSpecificRecipe), id);
            }
        }


        private void GRecipeList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }

        private void GRecipeList_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gRecipeList.SelectedRows.Count > 0)
            {
                ShowRecipeForm(gRecipeList.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }
    }
}
