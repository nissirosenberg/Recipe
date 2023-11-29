namespace RecipeSystem
{
    public static class AutoCreateARecipe
    {
        public static int AutoCreateRecipe(int userid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("AutoCreateACookbook");
            SQLUtility.SetParameterValue(cmd, "@UserId", userid);
            SQLUtility.ExecuteSQL(cmd);
            return SQLUtility.GetIntReturnValueFromSproc(cmd.Parameters, "@CookbookId");
        }
    }
}
