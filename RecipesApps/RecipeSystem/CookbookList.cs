namespace RecipeSystem
{
    public class CookbookList
    {
        public static DataTable GetCookBookList()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookListGet");
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable Load(int cookbookid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookGet");
            SQLUtility.SetParameterValue(cmd, "@CookbookId", cookbookid);
            return SQLUtility.GetDataTable(cmd);
        }
    }
}
