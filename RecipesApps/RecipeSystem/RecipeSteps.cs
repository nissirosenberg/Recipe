namespace RecipeSystem
{
    public class RecipeSteps
    {
        public static DataTable LoadByRecipeId(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeDirectionsGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            return SQLUtility.GetDataTable(cmd);
        }

        public static void SaveTable(DataTable dt, int recipeid)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added | DataViewRowState.ModifiedCurrent))
            {
                r["RecipeId"] = recipeid;
            };
            SQLUtility.SaveDataTable(dt, "RecipeDirectionsUpdate");
        }

        public static void Delete(int recipedirectionsid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeDirectionsDelete");
            cmd.Parameters["@RecipeDirectionsId"].Value = recipedirectionsid;
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
