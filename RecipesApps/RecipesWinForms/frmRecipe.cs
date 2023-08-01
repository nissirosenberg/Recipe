using System.Data;
using CPUFramework;
using CPUWindowsFormFramework;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Collections.Generic;

namespace RecipesWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe;

        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }


        public void ShowForm(int recipeid)
        {
            string sql = "select r.* from Recipe r join Users u on r.UserId = u.UserId join CuisineType c on c.CuisineTypeId = r.CuisineTypeId where r.RecipeId = " + recipeid.ToString();
            dtrecipe = SQLUtility.GetDataTable(sql);
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtusers = SQLUtility.GetDataTable("select UserId, UserName from Users");
            DataTable dtcuisinetype = SQLUtility.GetDataTable("select CuisineTypeId, CuisineTypeName from CuisineType");

            WindowsFormsUtility.SetControlBinding(txtRecipeName, dtrecipe);
            //Is there a shorter way I can do this? I had a problem using the procedure because my tablename is Users,
            //and my columns are User. User is a reserved word in sql.
            lstUserName.DataSource = dtusers;
            lstUserName.ValueMember = "UserId";
            lstUserName.DisplayMember = "UserName";
            lstUserName.DataBindings.Add("SelectedValue", dtrecipe, lstUserName.ValueMember, false, DataSourceUpdateMode.OnPropertyChanged);
            WindowsFormsUtility.SetListBinding(lstCuisineTypeName, dtcuisinetype, dtrecipe, "CuisineType");
            WindowsFormsUtility.SetControlBinding(txtCalories, dtrecipe);
            WindowsFormsUtility.SetControlBinding(dtpDateDrafted, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtCurrentStatus, dtrecipe);
            this.Show();
        }

        private void Save()
        {

            SQLUtility.DebugPrintDataTable(dtrecipe);

            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "";
            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update recipe set",
                    $"UserId = '{r["UserId"]}',",
                    $"CuisineTypeId = '{r["CuisineTypeId"]}',",
                    $"RecipeName = '{r["RecipeName"]}',",
                    $"Calories = {r["Calories"]}",
                    //$"DateDrafted = '{r["DateDrafted"]}',",
                    //$"DatePublished = '{r["DatePublished"]}',",
                    //$"DateArchived = '{r["DateArchived"]}'",
                    $"where RecipeId = {r["RecipeId"]}");
            }
            else
            {
                sql = "insert Recipe(UserId, CuisineTypeId, RecipeName, Calories)";
                sql += $"select {r["UserId"]}, {r["CuisineTypeId"]}, '{r["RecipeName"]}', {r["Calories"]}";
            }

            Debug.Print("------------");
            SQLUtility.ExecuteSQL(sql);
        }

        private void Delete()
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = "delete Recipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
            this.Close();
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
