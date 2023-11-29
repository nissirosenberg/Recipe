namespace RecipeSystem
{
    public class SpecificRecipe
    {
        public static DataTable GetCuisineTypeList(bool includeblank = false)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("CuisineTypeGet");
            SQLUtility.SetParameterValue(cmd, "@All", 1);
            SQLUtility.SetParameterValue(cmd, "@IncludeBlank", includeblank);
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable GetUsersList(bool includeblank = false)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("UserGet");
            SQLUtility.SetParameterValue(cmd, "@All", 1);
            SQLUtility.SetParameterValue(cmd, "@IncludeBlank", includeblank);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void Save(DataTable dtrecipe) 
        {
            if(dtrecipe.Rows.Count == 0)
            {
                throw new Exception("Cannot call Recipe Save Method because there are no rows in the datatable.");
            }
            DataRow r = dtrecipe.Rows[0];
            SqlCommand cmd = SQLUtility.SaveDataRow(r, "RecipeUpdate");
        }

        
        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeDelete");
            SQLUtility.SetParameterValue(cmd, "@RecipeId", id);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static string GetRecipeName(DataTable dt)
        {
            string value = "New Recipe";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dt, "RecipeId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsString(dt, "RecipeName");
            }
            return value;
        }
    }
}
