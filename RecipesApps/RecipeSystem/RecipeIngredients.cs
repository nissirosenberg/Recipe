namespace RecipeSystem
{
    public class RecipeIngredients
    {
        public static DataTable LoadByRecipeId(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeIngredientGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            return SQLUtility.GetDataTable(cmd);
        }

        public static void SaveTable(DataTable dt, int recipeid)
        {
            foreach(DataRow r in dt.Select("", "", DataViewRowState.Added | DataViewRowState.ModifiedCurrent))
            {
                r["RecipeId"] = recipeid;
            };
            SQLUtility.SaveDataTable(dt, "RecipeIngredientUpdate");
        }

        public static void Delete(int recipeingredientid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeIngredientDelete");
            cmd.Parameters["@RecipeIngredientId"].Value = recipeingredientid;
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
