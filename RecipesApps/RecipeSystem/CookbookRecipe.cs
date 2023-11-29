namespace RecipeSystem
{
    public class CookbookRecipe
    {
        public static void SaveTable(DataTable dt, int cookbookid)
        {
            foreach(DataRow r in dt.Select("", "", DataViewRowState.Added | DataViewRowState.ModifiedCurrent))
            {
                r["CookbookId"] = cookbookid; 
            };
            SQLUtility.SaveDataTable(dt, "CookbookRecipeUpdate");
        }

        public static void Delete(int cookbookrecipeid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookRecipeDelete");
            cmd.Parameters["@CookbookRecipeId"].Value = cookbookrecipeid;
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
