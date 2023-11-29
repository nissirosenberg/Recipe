namespace RecipeSystem
{
    public class Dashboard
    {
        public static DataTable GetTotalRecipesMealsCookbooks()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("TotalRecipesMealsCookbooksGet");
            return SQLUtility.GetDataTable(cmd);
        }

    }
}
