namespace RecipesWinForms
{
    public partial class frmAutoCreateACookbook : Form
    {
        int cookbookid = 0;
        BindingSource bindsource = new();
        DataTable dtspecificcookbook;
        public frmAutoCreateACookbook()
        {
            InitializeComponent();
            BindData();
            btnCreateCookbook.Click += BtnCreateCookbook_Click;
        }



        private void BindData()
        {
            bindsource.DataSource = dtspecificcookbook;
            dtspecificcookbook = CookbookList.Load(cookbookid);
            DataTable dtusers = SpecificRecipe.GetUsersList(true);
            lstUsers.DataSource = dtusers;
            lstUsers.ValueMember = "UserId";
            lstUsers.DisplayMember = "FullName";
            lstUsers.DataBindings.Add("SelectedValue", dtspecificcookbook, lstUsers.ValueMember, false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void AutoCreateCookbook()
        {
            int userid = WindowsFormsUtility.GetIdFromComboBox(lstUsers);
            Cursor = Cursors.WaitCursor;
            try
            {
                int newcookbookid = AutoCreateARecipe.AutoCreateRecipe(userid);
                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmSpecificCookbook), newcookbookid);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void BtnCreateCookbook_Click(object? sender, EventArgs e)
        {
            AutoCreateCookbook();
        }
    }
}
