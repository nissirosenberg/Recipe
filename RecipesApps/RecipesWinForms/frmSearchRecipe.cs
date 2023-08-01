using CPUFramework;
using System.Data;
using CPUWindowsFormFramework;

namespace RecipesWinForms
{
    public partial class frmSearchRecipe : Form
    {
        public frmSearchRecipe()
        {
            InitializeComponent();
            WindowsFormsUtility.FormatGridForSearchResults(gRecipe);

            btnSearch.Click += BtnSearch_Click;
            gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;
            btnNew.Click += BtnNew_Click;
        }

        private void SearchForRecipe(string recipename)
        {
            string sql = "select RecipeId, RecipeName from Recipe r " +
                "where r.RecipeName like '%" + recipename + "%'";


            DataTable dt = SQLUtility.GetDataTable(sql);
            gRecipe.DataSource = dt;
            gRecipe.Columns["RecipeId"].Visible = false;
        }

        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = (int)gRecipe.Rows[rowindex].Cells["RecipeId"].Value;
            }
            frmRecipe frm = new frmRecipe();
            frm.ShowForm(id);
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchForRecipe(txtRecipeName.Text);
        }


        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }


        private void GRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }
    }
}
