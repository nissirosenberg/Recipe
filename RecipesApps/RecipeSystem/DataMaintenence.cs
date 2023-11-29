namespace RecipeSystem
{
    public static class DataMaintenence
    {
        public static DataTable GetDataList(string tablename, bool includeblank = false)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand(tablename + "Get");
            SQLUtility.SetParameterValue(cmd, "@All", 1);
            if(includeblank == true)
            {
                SQLUtility.SetParameterValue(cmd, "@IncludeBlank", includeblank);
            }
            return SQLUtility.GetDataTable(cmd);
        }

        public static void SaveDataList(DataTable dt, string tablename)
        {
            SQLUtility.SaveDataTable(dt, tablename + "Update");
        }

        public static void DeleteRow(string tablename, int id)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(tablename + "Delete");
            SQLUtility.SetParameterValue(cmd, $"@{tablename}Id", id);
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
