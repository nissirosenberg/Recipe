namespace RecipesWinForms
{
    public partial class frmSpecificCookbook : Form
    {
        int cookbookid = 0;
        string deletecolumnname = "deletecolumn";
        DataTable dtspecificcookbook;
        DataTable dtcookbookrecipes;
        BindingSource bindsource = new();

        public frmSpecificCookbook()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSaveCookbookRecipes.Click += BtnSaveCookbookRecipes_Click;
            gCookbookRecipes.CellContentClick += GCookbookRecipes_CellContentClick;
            this.FormClosing += FrmSpecificCookbook_FormClosing;
        }



        public void LoadCookbookForm(int specificcookbookid)
        {
            cookbookid = specificcookbookid;
            this.Tag = cookbookid;
            dtspecificcookbook = CookbookList.Load(cookbookid);
            bindsource.DataSource = dtspecificcookbook;

            if (cookbookid == 0)
            {
                dtspecificcookbook.Rows.Add();
            }
            WindowsFormsUtility.SetControlBinding(txtCookbookName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtPrice, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateCreated, bindsource);
            DataTable dtusers = SpecificRecipe.GetUsersList(true);
            lstUsers.DataSource = dtusers;
            lstUsers.ValueMember = "UserId";
            lstUsers.DisplayMember = "UserName";
            lstUsers.DataBindings.Add("SelectedValue", dtspecificcookbook, lstUsers.ValueMember, false, DataSourceUpdateMode.OnPropertyChanged);
            WindowsFormsUtility.SetControlBinding(cbxActive, bindsource);
            LoadCookbookRecipes();
            SetButtonsEnabledBasedOnNewRecord();
            this.Text = SpecificCookbook.GetCookbookName(dtspecificcookbook);
        }

        private void LoadCookbookRecipes()
        {
            dtcookbookrecipes = SpecificCookbook.LoadByCookbookId(cookbookid);
            gCookbookRecipes.Columns.Clear();
            gCookbookRecipes.DataSource = dtcookbookrecipes;
            WindowsFormsUtility.AddComboBoxToGrid(gCookbookRecipes, DataMaintenence.GetDataList("Recipe"), "Recipe", "RecipeName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gCookbookRecipes, deletecolumnname);
            WindowsFormsUtility.FormatGridForEdit(gCookbookRecipes, "CookbookRecipe");
        }


        private bool Save()
        {
            bool saved = false;
            Application.UseWaitCursor = true;
            try
            {
                SpecificCookbook.Save(dtspecificcookbook);
                saved = true;
                bindsource.ResetBindings(false);
                cookbookid = SQLUtility.GetValueFromFirstRowAsInt(dtspecificcookbook, "CookbookId");
                this.Tag = cookbookid;
                SetButtonsEnabledBasedOnNewRecord();
                this.Text = SpecificCookbook.GetCookbookName(dtspecificcookbook);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cookbook");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return saved;
        }

        private void SaveCookbookRecipe()
        {
            try
            {
                CookbookRecipe.SaveTable(dtcookbookrecipes, cookbookid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void Delete()
        {

            var response = MessageBox.Show("Are you sure you want to delete this Cookbook?", this.Text, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                SpecificCookbook.Delete(dtspecificcookbook);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void DeleteCookbookRecipes(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gCookbookRecipes, rowindex, "CookbookRecipeId");
            if (id > 0)
            {
                try
                {
                    CookbookRecipe.Delete(id);
                    LoadCookbookRecipes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gCookbookRecipes.Rows.Count)
            {
                gCookbookRecipes.Rows.RemoveAt(rowindex);
            }
        }

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = cookbookid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnSaveCookbookRecipes.Enabled = b;
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void BtnSaveCookbookRecipes_Click(object? sender, EventArgs e)
        {
            SaveCookbookRecipe();
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void GCookbookRecipes_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteCookbookRecipes(e.RowIndex);
        }


        private void FrmSpecificCookbook_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtspecificcookbook) == true)
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing this form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }
    }
}


