namespace RecipeSystem
{
    public  class SpecificCookbook
    {
       public static DataTable LoadByCookbookId(int cookbookid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookRecipeGet");
            cmd.Parameters["@CookbookId"].Value = cookbookid;
            return SQLUtility.GetDataTable(cmd);
        }

        public static string GetCookbookName(DataTable dt)
        {
            string value = "New Recipe";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dt, "CookbookId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsString(dt, "CookbookName");
            }
            return value;
        }

        public static void Save(DataTable dtcookbook)
        {
            if (dtcookbook.Rows.Count == 0)
            {
                throw new Exception("Cannot call Cookbook Save Method because there are no rows in the datatable");
            }
            DataRow r = dtcookbook.Rows[0];
            SQLUtility.SaveDataRow(r, "CookbookUpdate");
        }
        public static void Delete(DataTable dtcookbook)
        {
            int id = (int)dtcookbook.Rows[0]["CookbookId"];
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookDelete");
            SQLUtility.SetParameterValue(cmd, "@CookbookId", id);
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
