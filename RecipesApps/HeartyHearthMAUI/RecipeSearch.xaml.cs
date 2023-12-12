using RecipeSystem;
using System.Data;

namespace HeartyHearthMAUI;

public partial class RecipeSearch : ContentPage
{
	public RecipeSearch()
	{
		InitializeComponent();
	}

	private void SearchRecipes()
	{
		DataTable dt = Recipe.SearchRecipes(RecipeNameTxt.Text);
		RecipeLst.ItemsSource = dt.Rows;
	}

    private void SearchBtn_Clicked(object sender, EventArgs e)
    {
		SearchRecipes();
    }
}