namespace RecipesWinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            mnuFileDashboard.Click += MnuFileDashboard_Click;
            mnuCascade.Click += MnuWindowCascade_Click;
            mnuTile.Click += MnuWindowTile_Click;
            mnuRecipesList.Click += MnuRecipesList_Click;
            mnuMealsList.Click += MnuMealsList_Click;
            mnuCookbooksList.Click += MnuCookbooksList_Click;
            mnuRecipesNewRecipe.Click += MnuRecipesNewRecipe_Click;
            mnuRecipesCloneARecipe.Click += MnuRecipesCloneARecipe_Click;
            mnuCookbooksAutoCreate.Click += MnuCookbooksAutoCreate_Click;
            mnuDataMaintenanceEditData.Click += MnuDataMaintenanceEditData_Click;
            mnuCookbooksNewCookbook.Click += MnuCookbooksNewCookbook_Click;
            this.Shown += FrmMain_Shown;
        }

        private void FrmMain_Shown(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }

        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            bool exists = WindowsFormsUtility.IsFormOpen(frmtype, pkvalue);

            Form? newfrm = null;
            if (exists == false)
            {
                if (frmtype == typeof(frmDashboard))
                {
                    frmDashboard f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmRecipeList))
                {
                    frmRecipeList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmMealList))
                {
                    frmMealList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmCookbookList))
                {
                    frmCookbookList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmSpecificRecipe))
                {
                    frmSpecificRecipe f = new();
                    newfrm = f;
                    f.LoadRecipeForm(pkvalue);
                }
                else if (frmtype == typeof(frmChangeStatus))
                {
                    frmChangeStatus f = new();
                    newfrm = f;
                    f.LoadChangeStatusForm(pkvalue);
                }
                else if(frmtype == typeof(frmCloneARecipe))
                {
                    frmCloneARecipe f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmDataMaintenence))
                {
                    frmDataMaintenence f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmSpecificCookbook))
                {
                    frmSpecificCookbook f = new();
                    newfrm = f;
                    f.LoadCookbookForm(pkvalue);
                }
                else if (frmtype == typeof(frmAutoCreateACookbook))
                {
                    frmAutoCreateACookbook f = new();
                    newfrm = f;
                }

                if (newfrm != null)
                {
                    newfrm.MdiParent = this;
                    newfrm.WindowState = FormWindowState.Maximized;
                    newfrm.FormClosed += Newfrm_FormClosed;
                    newfrm.TextChanged += Newfrm_TextChanged;
                    newfrm.Show();
                }
                WindowsFormsUtility.SetupNav(tsMain);
            }
        }

        private void Newfrm_TextChanged(object? sender, EventArgs e)
        {
            WindowsFormsUtility.SetupNav(tsMain);
        }

        private void Newfrm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            WindowsFormsUtility.SetupNav(tsMain);
        }
        private void MnuWindowTile_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void MnuWindowCascade_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MnuFileDashboard_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }
        private void MnuRecipesList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeList));
        }


        private void MnuMealsList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmMealList));
        }

        private void MnuCookbooksList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookList));
        }

        private void MnuRecipesNewRecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmSpecificRecipe));
        }

        private void MnuRecipesCloneARecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCloneARecipe));
        }

        private void MnuDataMaintenanceEditData_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDataMaintenence));
        }

        private void MnuCookbooksAutoCreate_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmAutoCreateACookbook));
        }

        private void MnuCookbooksNewCookbook_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmSpecificCookbook));
        }
    }
}
