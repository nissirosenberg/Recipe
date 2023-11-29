namespace RecipesWinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            this.Activated += FrmDashboard_Activated;
            btnRecipeList.Click += BtnRecipeList_Click;
            btnMealList.Click += BtnMealList_Click;
            btnCookbookList.Click += BtnCookbookList_Click;
        }

        private void BindData()
        {
            gTotals.DataSource = Dashboard.GetTotalRecipesMealsCookbooks();
            WindowsFormsUtility.FormatGridForSearchResults(gTotals, "TotalRecipesMealsCookbooksGet");

        }

        private void ShowForm(string listname)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                if (listname == "Recipe")
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeList));
                }
                else if (listname == "Meal")
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmMealList));
                }
                else if (listname == "Cookbook")
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookList));
                }
            }
        }

        private void FrmDashboard_Activated(object? sender, EventArgs e)
        {
            BindData();
        }
        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {
            ShowForm("Recipe");
        }
        private void BtnMealList_Click(object? sender, EventArgs e)
        {
            ShowForm("Meal");
        }
        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {
            ShowForm("Cookbook");
        }
    }
}
