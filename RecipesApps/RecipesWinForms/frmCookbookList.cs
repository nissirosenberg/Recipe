namespace RecipesWinForms
{
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            this.Activated += FrmCookbookList_Activated;
            btnNewCookbook.Click += BtnNewCookbook_Click;
            gCookbookList.CellDoubleClick += GCookbookList_CellDoubleClick;
            gCookbookList.KeyDown += GCookbookList_KeyDown;
        }


        private void FrmCookbookList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            gCookbookList.DataSource = CookbookList.GetCookBookList();
            WindowsFormsUtility.FormatGridForSearchResults(gCookbookList, "CookbookListGet");
        }

        private void ShowCookbookForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gCookbookList, rowindex, "CookbookId");
            }
            if(this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmSpecificCookbook), id);
            }
        }
        private void GCookbookList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowCookbookForm(e.RowIndex);
        }

        private void GCookbookList_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gCookbookList.SelectedRows.Count > 0)
            {
                ShowCookbookForm(gCookbookList.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }
        private void BtnNewCookbook_Click(object? sender, EventArgs e)
        {
            ShowCookbookForm(-1);
        }
    }
}
