using System.Data;
using CPUFramework;


namespace RecipesWinForms
{
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
        }

        public void ShowForm(int recipeid)
        {
            string sql = "select * from Recipe r where r.RecipeId = " + recipeid.ToString();
            DataTable dt = SQLUtility.GetDataTable(sql);
            txtRecipeName.DataBindings.Add("Text", dt, "RecipeName");
            txtCalories.DataBindings.Add("Text", dt, "Calories");
            txtDateDrafted.DataBindings.Add("Text", dt, "DateDrafted");
            txtDatePublished.DataBindings.Add("Text", dt, "DatePublished");
            txtDateArchived.DataBindings.Add("Text", dt, "DateArchived");
            txtCurrentStatus.DataBindings.Add("Text", dt, "CurrentStatus");
            this.Show();
        }

    }
}
