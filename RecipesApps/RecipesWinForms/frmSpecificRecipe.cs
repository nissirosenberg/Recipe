using RecipeSystem;

namespace RecipesWinForms
{
    public partial class frmSpecificRecipe : Form
    {
        int recipeid = 0;
        string deletecolumnname = "deletecolumn";
        DataTable dtspecificrecipe;
        DataTable dtrecipeingredient;
        DataTable dtrecipesteps;
        BindingSource bindsource = new();
        public frmSpecificRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            btnSaveIngredient.Click += BtnSaveIngredient_Click;
            btnSaveSteps.Click += BtnSaveSteps_Click;
            gIngredient.CellContentClick += GIngredient_CellContentClick;
            gSteps.CellContentClick += GSteps_CellContentClick;
            this.Activated += FrmSpecificRecipe_Activated;
            this.FormClosing += FrmSpecificRecipe_FormClosing;
        }



        public void LoadRecipeForm(int specificrecipeid, bool setbinding = true)
        {
            recipeid = specificrecipeid;
            this.Tag = recipeid;
            dtspecificrecipe = RecipeList.Load(recipeid);
            bindsource.DataSource = dtspecificrecipe;

            if (recipeid == 0)
            {
                dtspecificrecipe.Rows.Add();
            }

            DataTable dtcuisinetypes = SpecificRecipe.GetCuisineTypeList(true);
            DataTable dtusers = SpecificRecipe.GetUsersList(true);

            if (setbinding == true)
            {
                WindowsFormsUtility.SetListBinding(lstCuisineTypeName, dtcuisinetypes, dtspecificrecipe, "CuisineType");
                WindowsFormsUtility.SetListBinding(lstUserName, dtusers, dtspecificrecipe, "User");

                //lstUserName.DataSource = dtusers;
                //lstUserName.ValueMember = "UserId";
                //lstUserName.DisplayMember = "UserName";
                //lstUserName.DataBindings.Add("SelectedValue", dtspecificrecipe, lstUserName.ValueMember, false, DataSourceUpdateMode.OnPropertyChanged);



                WindowsFormsUtility.SetControlBinding(txtRecipeName, bindsource);
                WindowsFormsUtility.SetControlBinding(txtCalories, bindsource);
                WindowsFormsUtility.SetControlBinding(txtCurrentStatus, bindsource);
                WindowsFormsUtility.SetControlBinding(txtDateDrafted, bindsource);
                WindowsFormsUtility.SetControlBinding(txtDatePublished, bindsource);
                WindowsFormsUtility.SetControlBinding(txtDateArchived, bindsource);
                LoadRecipeIngredient();
                LoadRecipeSteps();
            }
            this.Text = SpecificRecipe.GetRecipeName(dtspecificrecipe);
        }

        private void LoadRecipeIngredient()
        {
            dtrecipeingredient = RecipeIngredients.LoadByRecipeId(recipeid);
            gIngredient.Columns.Clear();
            gIngredient.DataSource = dtrecipeingredient;
            WindowsFormsUtility.AddComboBoxToGrid(gIngredient, DataMaintenence.GetDataList("Measurement"), "Measurement", "MeasurementName");
            WindowsFormsUtility.AddComboBoxToGrid(gIngredient, DataMaintenence.GetDataList("Ingredient"), "Ingredient", "IngredientName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gIngredient, deletecolumnname);
            WindowsFormsUtility.FormatGridForEdit(gIngredient, "RecipeIngredient");
            SetButtonsEnabledBasedOnNewRecord();
        }

        private void LoadRecipeSteps()
        {
            dtrecipesteps = RecipeSteps.LoadByRecipeId(recipeid);
            gSteps.Columns.Clear();
            gSteps.DataSource = dtrecipesteps;
            WindowsFormsUtility.AddDeleteButtonToGrid(gSteps, deletecolumnname);
            WindowsFormsUtility.FormatGridForEdit(gSteps, "RecipeSteps");
        }

        private void ShowChangeStatusForm()
        {
            ((frmMain)this.MdiParent).OpenForm(typeof(frmChangeStatus), recipeid);
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                SpecificRecipe.Save(dtspecificrecipe);

                b = true;
                bindsource.ResetBindings(false);
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtspecificrecipe, "RecipeId");
                this.Tag = recipeid;
                SetButtonsEnabledBasedOnNewRecord();
                this.Text = SpecificRecipe.GetRecipeName(dtspecificrecipe);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;

        }

        private void SaveRecipeIngredient()
        {
            try
            {
                RecipeIngredients.SaveTable(dtrecipeingredient, recipeid);
            }
            catch (Exception ex)
            {
                LoadRecipeIngredient();
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void SaveRecipeSteps()
        {
            try
            {
                RecipeSteps.SaveTable(dtrecipesteps, recipeid);
            }
            catch (Exception ex)
            {
                LoadRecipeSteps();
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this Recipe?", this.Text, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                SpecificRecipe.Delete(dtspecificrecipe);
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

        private void DeleteRecipeIngredient(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gIngredient, rowindex, "RecipeIngredientId");
            if (id > 0)
            {
                try
                {
                    RecipeIngredients.Delete(id);
                    LoadRecipeIngredient();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gIngredient.Rows.Count)
            {
                gIngredient.Rows.RemoveAt(rowindex);
            }
        }

        private void DeleteRecipeSteps(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gSteps, rowindex, "RecipeDirectionsId");
            if (id > 0)
            {
                try
                {
                    RecipeSteps.Delete(id);
                    LoadRecipeSteps();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gSteps.Rows.Count)
            {
                gSteps.Rows.RemoveAt(rowindex);
            }
        }

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = recipeid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnChangeStatus.Enabled = b;
            btnSaveIngredient.Enabled = b;
            btnSaveSteps.Enabled = b;
        }



        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }


        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            ShowChangeStatusForm();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSaveIngredient_Click(object? sender, EventArgs e)
        {
            SaveRecipeIngredient();
        }
        private void BtnSaveSteps_Click(object? sender, EventArgs e)
        {
            SaveRecipeSteps();
        }
        private void GIngredient_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteRecipeIngredient(e.RowIndex);
        }
        private void GSteps_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteRecipeSteps(e.RowIndex);
        }
        private void FrmSpecificRecipe_Activated(object? sender, EventArgs e)
        {
            LoadRecipeForm(recipeid, false);
        }

        private void FrmSpecificRecipe_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtspecificrecipe) == true)
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
