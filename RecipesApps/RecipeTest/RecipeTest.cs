
using System.Data;

namespace RecipeTest
{
    public class RecipeTest
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server=.\\SQLExpress01;Database=HeartyHearthDB;Trusted_Connection=true");
        }

        [Test]
        public void SearchRecipes()
        {
            string criteria = "a";
            int numrecipes = SQLUtility.GetFirstColumFirstRowValue("Select Total = count(*) from Recipe r where r.RecipeName like '%" + criteria + "%'");
            Assume.That(numrecipes > 0, "No recipes in DB, can't test");
            TestContext.WriteLine("There are " + numrecipes + " recipes that contain " + criteria + " in its name");
            TestContext.WriteLine("Ensure that recipe search returns " + numrecipes + " rows");

            DataTable dt = Recipe.SearchRecipes(criteria);
            int results = dt.Rows.Count;

            Assert.IsTrue(results == numrecipes, "Results of recipe search does not match number of recipes");
            TestContext.WriteLine("Number of rows returns by recipe search is " + results);
        }

        [Test]
        public void InsertNewRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select * from Recipe where RecipeId = 0");
            DataRow r =  dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);

            int userid = SQLUtility.GetFirstColumFirstRowValue("select top 1 UserId from Users");
            Assume.That(userid > 0, "No users in DB, can't run test");
            int cuisinetypeid = SQLUtility.GetFirstColumFirstRowValue("select top 1 CuisineTypeId from CuisineType");
            Assume.That(cuisinetypeid > 0, "No cuisine types in DB, can't run test");

            string recipetestname = "Test " + DateTime.Now.ToString();
            r["UserId"] = userid;
            r["CuisineTypeId"] = cuisinetypeid;
            r["RecipeName"] = recipetestname;
            r["Calories"] = 4000;
            r["DateDrafted"] = DateTime.Now.ToString();
            TestContext.WriteLine($"Insert Recipe with UserId {userid}, and CuisineTypeId {cuisinetypeid}, and RecipeName " + recipetestname);
            Recipe.Save(dt);

            int newid = SQLUtility.GetFirstColumFirstRowValue("select RecipeId from Recipe where RecipeName = '" + recipetestname + "'");
            Assert.IsTrue(newid > 0, "The data was not inserted");
            TestContext.WriteLine("Recipe with RecipeName " + recipetestname + " is found in the DB with primary key value of " + newid);
        }

        [Test]
        public void ChangeRecipe()
        {
            int recipeid = GetExistingId("Recipe");
            Assume.That(recipeid > 0);
            DataTable dtrecipe = SQLUtility.GetDataTable("select top 1 r.RecipeId, r.RecipeName, u.UserId, u.UserName, r.CuisineTypeId, ct.CuisineTypeName, r.Calories from Recipe r join Users u on r.UserId = u.UserId join CuisineType ct on r.CuisineTypeId = ct.CuisineTypeId where r.RecipeId = " + recipeid);
            
            string recipename = dtrecipe.Rows[0]["RecipeName"].ToString();
            int userid = (int)dtrecipe.Rows[0]["UserId"];
            int cuisinetypeid = (int)dtrecipe.Rows[0]["CuisineTypeId"];
            int calories = (int)dtrecipe.Rows[0]["Calories"];
            
            TestContext.WriteLine("Info for RecipeId " + recipeid + $": {Environment.NewLine}  RecipeName = " + recipename + $"{Environment.NewLine}  UserId = " + userid + $"{Environment.NewLine}  CuisineTypeId = " + cuisinetypeid + $"{Environment.NewLine}  Calories = " + calories );
            
            recipename += "x";
            int randomuserid = SQLUtility.GetFirstColumFirstRowValue("select top 1 UserId from Users where UserId <> " + userid);
            int randomcuisinetypeid = SQLUtility.GetFirstColumFirstRowValue("select top 1 CuisineTypeId from CuisineType where CuisineTypeId <> " + cuisinetypeid);
            calories = calories + 7;
            
            TestContext.WriteLine("Change RecipeName to " + recipename + " and UserId to " + randomuserid + " and CuisineTypeId to " + randomcuisinetypeid + " and Calories to " + calories);
        


            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["RecipeName"] = recipename;
            dt.Rows[0]["UserId"] = randomuserid;
            dt.Rows[0]["CuisineTypeId"] = randomcuisinetypeid;
            dt.Rows[0]["Calories"] = calories;
            Recipe.Save(dt);
        


            DataTable dtrecipenew = SQLUtility.GetDataTable("select top 1 r.RecipeId, r.RecipeName, r.UserId, u.UserName, r.CuisineTypeId, ct.CuisineTypeName, r.Calories from Recipe r join Users u on r.UserId = u.UserId join CuisineType ct on r.CuisineTypeId = ct.CuisineTypeId where r.RecipeId = " + recipeid);
            
            string recipnamenew = dtrecipenew.Rows[0]["RecipeName"].ToString();
            int useridnew = (int)dtrecipenew.Rows[0]["UserId"];
            int cuisinetypeidnew = (int)dtrecipenew.Rows[0]["CuisineTypeId"];
            int caloriesnew = (int)dtrecipenew.Rows[0]["Calories"];
            
            Assert.IsTrue(recipnamenew == recipename, "RecipeId " + recipeid + ": RecipeName didn't change");
            Assert.IsTrue(useridnew == randomuserid, "RecipeId " + recipeid + ": UserId didn't change");
            Assert.IsTrue(cuisinetypeidnew == randomcuisinetypeid, "RecipeId " + recipeid + ": CuisineTypeName didn't change");
            Assert.IsTrue(caloriesnew == calories, "RecipeId " + recipeid + ": Calories didn't change");
            TestContext.WriteLine("Info for RecipeId " + recipeid + $" has successfully changed. {Environment.NewLine}Currently:" 
                                    + Environment.NewLine + "  RecipeName = " + recipnamenew 
                                    + Environment.NewLine + "  UserId = " + useridnew
                                    + Environment.NewLine + "  CuisineTypeId = " + cuisinetypeidnew
                                    + Environment.NewLine + "  Calories = " + caloriesnew);
        }

        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select r.RecipeId, r.RecipeName from Recipe r left join RecipeIngredients ri on r.RecipeId = ri.RecipeId left join RecipeDirections rd on r.RecipeId = rd.RecipeId left join CookbookRecipe cr on r.RecipeId = cr.RecipeId where ri.RecipeIngredientsId is null and rd.RecipeDirectionsId is null and cr.CookbookRecipeId is null");
            int recipeid = 0;
            string recipename = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["RecipeId"];
                recipename = dt.Rows[0]["RecipeName"].ToString();
            }
            Assume.That(recipeid > 0, "No recipes without related records in DB, can't test");
            TestContext.WriteLine("Existing recipe without relatated records, with id " + recipeid);
            TestContext.WriteLine("Ensure that app can delete with RecipeId " + recipeid);
            Recipe.Delete(dt);
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from Recipe where RecipeId = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "Record with RecipeId " + recipeid + " exists in DB");
            TestContext.WriteLine("Recipe with RecipeId " + recipeid + " doesn't exist in DB");
        }

        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingId("Recipe");
            Assume.That(recipeid > 0, "No recipes in DB, can't test");
            TestContext.WriteLine("Existing RecipeId = " + recipeid);
            TestContext.WriteLine("Ensure that app loads recipe " + recipeid);

            DataTable dt = Recipe.Load(recipeid);
            int loadedid = (int)dt.Rows[0]["RecipeId"];
            Assert.IsTrue(loadedid == recipeid, loadedid + " <> " + recipeid);
            TestContext.WriteLine("Loaded recipe (" + loadedid + ")");
        }

        [Test]
        public void GetListOfUsers()
        {
            int totalusers = SQLUtility.GetFirstColumFirstRowValue("select total = count(*) from Users");
            Assume.That(totalusers > 0, "No users in DB, can't test");
            TestContext.WriteLine("Number of Users in DB = " + totalusers);
            TestContext.WriteLine("Ensure that number of users = " + totalusers);

            DataTable dt = Recipe.GetUsersList();
            Assert.IsTrue(dt.Rows.Count == totalusers, "Number of users (" + dt.Rows.Count + ") <> " + totalusers);
            TestContext.WriteLine("Number of rows in Users = " + dt.Rows.Count);
        }

        private int GetExistingId(string tablename)
        {
            return SQLUtility.GetFirstColumFirstRowValue($"select top 1 {tablename}Id from {tablename}");
        }
    }
}