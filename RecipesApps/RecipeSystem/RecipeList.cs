namespace RecipeSystem
{
    public class RecipeList
    {
        public static DataTable GetRecipeList()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeListGet");
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable Load(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            SQLUtility.SetParameterValue(cmd, "@RecipeId", recipeid);
            return SQLUtility.GetDataTable(cmd);
        }
    }
}
