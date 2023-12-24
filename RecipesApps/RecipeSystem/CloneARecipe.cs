namespace RecipeSystem
{
    public class CloneARecipe
    {
        public static int CloneRecipe(int basedonrecipeid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeClone");
            SQLUtility.SetParameterValue(cmd, "@BaseRecipeId", basedonrecipeid);
             
            SQLUtility.ExecuteSQL(cmd);
            return SQLUtility.GetIntReturnValueFromSproc(cmd.Parameters, "@RecipeId");
        }
    }
}
