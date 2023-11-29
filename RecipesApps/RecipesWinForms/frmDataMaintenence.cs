namespace RecipesWinForms
{
    public partial class frmDataMaintenence : Form
    {
        private enum TableTypeEnum { User, CuisineType, Ingredient, Measurement, Course };
        TableTypeEnum currenttabletype = TableTypeEnum.User;
        string deletecolumnname = "deletecol";
        DataTable dtlist = new();
        public frmDataMaintenence()
        {
            InitializeComponent();
            BindData(currenttabletype);
            SetupRadioButtons();
            btnSave.Click += BtnSave_Click;
            gData.CellContentClick += GData_CellContentClick;
        }


        private void BindData(TableTypeEnum tabletype)
        {
            currenttabletype = tabletype;
            dtlist = DataMaintenence.GetDataList(currenttabletype.ToString());
            gData.Columns.Clear();
            gData.DataSource = dtlist;
            WindowsFormsUtility.AddDeleteButtonToGrid(gData, deletecolumnname);
            WindowsFormsUtility.FormatGridForEdit(gData, currenttabletype.ToString());
        }

        private bool Save()
        {
            bool b = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                DataMaintenence.SaveDataList(dtlist, currenttabletype.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            return b;
        }

        private bool Delete(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gData, rowindex, $"{currenttabletype}Id");
            bool deleted = false;
            if (id != 0)
            {
                try
                {
                    DataMaintenence.DeleteRow(currenttabletype.ToString(), id);
                    deleted = true;
                    BindData(currenttabletype);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id == 0 && rowindex < gData.Rows.Count)
            {
                gData.Rows.Remove(gData.Rows[rowindex]);
            }
            return deleted;
        }

        private void SetupRadioButtons()
        {
            foreach (Control c in pnlOptionButtons.Controls)
            {
                if (c is RadioButton)
                {
                    c.Click += C_Click;
                }
                optUsers.Tag = TableTypeEnum.User;
                optCuisines.Tag = TableTypeEnum.CuisineType;
                optIngredient.Tag = TableTypeEnum.Ingredient;
                optMeasurement.Tag = TableTypeEnum.Measurement;
                optCourse.Tag = TableTypeEnum.Course;
            }
        }

        private void C_Click(object? sender, EventArgs e)
        {
            if (sender is Control && ((Control)sender).Tag is TableTypeEnum)
            {
                BindData((TableTypeEnum)((Control)sender).Tag);
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void GData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gData.Columns[e.ColumnIndex].Name == deletecolumnname)
            {
                string beforedeletemessage = "Are you sure you want to delete this information?";
                if (currenttabletype == TableTypeEnum.User)
                {
                    beforedeletemessage = "Are you sure you want to delete this user and all related recipes, meals, and cookbooks?";
                }
                var res = MessageBox.Show(beforedeletemessage, Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        Delete(e.RowIndex);
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
        }
    }
}
