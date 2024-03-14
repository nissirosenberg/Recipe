namespace RecipesWinForms
{
    public partial class frmChangeStatus : Form
    {
        DataTable dtspecificrecipe;
        BindingSource bindsource = new();
        int recipeid = 0;

        public frmChangeStatus()
        {
            InitializeComponent();
            btnArchive.Click += BtnUpdate_Click;
            btnPublish.Click += BtnUpdate_Click;
            btnDraft.Click += BtnUpdate_Click;
            this.Shown += FrmChangeStatus_Shown;
        }

      

        private void FrmChangeStatus_Shown(object? sender, EventArgs e)
        {
            SetButtonsEnableBasedOnCurrentStatus();
        }

        public void LoadChangeStatusForm(int specificrecipeid, bool setcontrolbinding = true)
        {
            recipeid = specificrecipeid;
            this.Tag = recipeid;
            dtspecificrecipe = RecipeList.Load(recipeid);
            bindsource.DataSource = dtspecificrecipe;
            if (setcontrolbinding == true)
            {
                WindowsFormsUtility.SetControlBinding(txtDateDrafted, bindsource);
                WindowsFormsUtility.SetControlBinding(txtDatePublished, bindsource);
                WindowsFormsUtility.SetControlBinding(txtDateArchived, bindsource);
                WindowsFormsUtility.SetControlBinding(lblCurrentStatus, bindsource);
                WindowsFormsUtility.SetControlBinding(lblRecipeName, bindsource);
            }
        }



        private void SetButtonsEnableBasedOnCurrentStatus()
        {
            string currentstatus = lblCurrentStatus.Text;
            if (currentstatus == "Draft")
            {
                btnDraft.Enabled = false;
            }
            if (currentstatus == "Published")
            {
                btnPublish.Enabled = false;
            }
            if (currentstatus == "Archived")
            {
                btnArchive.Enabled = false;
            }
        }

        private void StatusUpdate(object sender)
        {
            TextBox tb = txtDateDrafted;
            if (sender == btnArchive)
            {
                tb = txtDateArchived;
            }
            else if (sender == btnPublish)
            {
                tb = txtDatePublished;
            }
            try
            {
                tb.Text = DateTime.Now.ToString();
                SpecificRecipe.Save(dtspecificrecipe);
                LoadChangeStatusForm(recipeid, false);
            }
            catch (Exception ex)
            {
                LoadChangeStatusForm(recipeid, false);
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }


        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            if (sender is Button)
            {
                string statusname = "Drafted";
                if (sender == btnPublish)
                {
                    statusname = "Published";
                }
                else if (sender == btnArchive)
                {
                    statusname = "Archived";
                }
                var res = MessageBox.Show($"Are you sure you want to change this recipe to {statusname}?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        StatusUpdate(sender);
                        break;
                    case DialogResult.Cancel:
                        return;
                        break;
                }
            }
        }


    }
}
