namespace RecipesWinForms
{
    public partial class frmMealList : Form
    {
        public frmMealList()
        {
            InitializeComponent();
            this.Activated += FrmMealList_Activated;
        }

        private void FrmMealList_Activated(object? sender, EventArgs e)
        {
            gMealList.DataSource = MealList.GetMealList();
            WindowsFormsUtility.FormatGridForSearchResults(gMealList, "MealListGet");
        }
    }
}
