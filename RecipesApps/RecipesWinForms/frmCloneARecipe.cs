namespace RecipesWinForms
{
    public partial class frmCloneARecipe : Form
    {
        public frmCloneARecipe()
        {
            InitializeComponent();
            BindData();
            btnClone.Click += BtnClone_Click;
        }


        private void BindData()
        {
            WindowsFormsUtility.SetListBinding(lstRecipeName, RecipeList.GetRecipeList(), null, "Recipe") ;

        }

        private void CloneRecipe()
        {
            int recipeid = WindowsFormsUtility.GetIdFromComboBox(lstRecipeName);
            Cursor = Cursors.WaitCursor;
            try
            {
                int newrecipeid = CloneARecipe.CloneRecipe(recipeid);
               
                if(this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmSpecificRecipe), newrecipeid);
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }       
        }


        private void BtnClone_Click(object? sender, EventArgs e)
        {
            CloneRecipe();
        }
    }
}
