
using System.Data;
using System.Diagnostics;

namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable SearchRecipes(string recipename)
        {
            string sql = "select RecipeId, RecipeName from Recipe r " +
              "where r.RecipeName like '%" + recipename + "%'";
            DataTable dt = SQLUtility.GetDataTable(sql);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            string sql = "select * from Recipe r join Users u on r.UserId = u.UserId join CuisineType c on c.CuisineTypeId = r.CuisineTypeId where r.RecipeId = " + recipeid.ToString();
            return SQLUtility.GetDataTable(sql);
        }

        public static DataTable GetUsersList()
        {
            return SQLUtility.GetDataTable("select UserId, UserName from Users");
        }

        public static DataTable GetCuisineTypeList()
        {
            return SQLUtility.GetDataTable("select CuisineTypeId, CuisineTypeName from CuisineType");
        }

        public static void Save(DataTable dtrecipe)
        {
            SQLUtility.DebugPrintDataTable(dtrecipe);

            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "";
            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update recipe set",
                    $"UserId = '{r["UserId"]}',",
                    $"CuisineTypeId = '{r["CuisineTypeId"]}',",
                    $"RecipeName = '{r["RecipeName"]}',",
                    $"Calories = {r["Calories"]},",
                    $"DateDrafted = '{r["DateDrafted"]}'",
                    //$"DatePublished = '{r["DatePublished"]}',",
                    //$"DateArchived = '{r["DateArchived"]}'",
                    $"where RecipeId = {r["RecipeId"]}");
            }
            else
            {
                sql = "insert Recipe(UserId, CuisineTypeId, RecipeName, Calories, DateDrafted)";
                sql += $"select {r["UserId"]}, {r["CuisineTypeId"]}, '{r["RecipeName"]}', {r["Calories"]}, '{r["DateDrafted"]}'";
            }

            Debug.Print("------------");
            SQLUtility.ExecuteSQL(sql);
        }

        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = "delete Recipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
        }
    }
}
