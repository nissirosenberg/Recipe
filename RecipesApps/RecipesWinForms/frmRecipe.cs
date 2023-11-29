namespace RecipesWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe;
        BindingSource bindsource = new();

        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }


        public void ShowForm(int recipeid)
        {
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtusers = Recipe.GetUsersList();
            DataTable dtcuisinetype = Recipe.GetCuisineTypeList();
            WindowsFormsUtility.SetControlBinding(txtRecipeName, bindsource);
            lstUserName.DataSource = dtusers;
            lstUserName.ValueMember = "UserId";
            lstUserName.DisplayMember = "UserName";
            lstUserName.DataBindings.Add("SelectedValue", dtrecipe, lstUserName.ValueMember, false, DataSourceUpdateMode.OnPropertyChanged);
            WindowsFormsUtility.SetListBinding(lstCuisineTypeName, dtcuisinetype, dtrecipe, "CuisineType");
            WindowsFormsUtility.SetControlBinding(txtCalories, bindsource);
            WindowsFormsUtility.SetControlBinding(dtpDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, bindsource);
            WindowsFormsUtility.SetControlBinding(txtCurrentStatus, bindsource);
            this.Show();
        }

        private void Save()
        {

            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtrecipe);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this recipe?", "Recipe", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtrecipe);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }



        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}
