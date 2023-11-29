namespace RecipeSystem
{
    public class MealList
    {
        public static DataTable GetMealList()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("MealListGet");
            return SQLUtility.GetDataTable(cmd);
        }
    }
}
