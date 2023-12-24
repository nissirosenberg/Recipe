namespace RecipeSystem
{
    public class bizIngredient : bizObject<bizIngredient>
    {
        private int _ingrdientid;
        private string _ingredientname;
        private string _ingredientpicture;

        public List<bizIngredient> Search(string ingredientnameval)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(this.GetSprocName);
            SQLUtility.SetParameterValue(cmd, "IngredientName", ingredientnameval);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }

        public int IngredientId
        {
            get => _ingrdientid;
            set
            {
                if (value != _ingrdientid)
                {
                    _ingrdientid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string IngredientName
        {
            get => _ingredientname;
            set
            {
                if (value != _ingredientname)
                {
                    _ingredientname = value;
                    InvokePropertyChanged();
                    InvokePropertyChanged("IngredientPicture");
                }
            }
        }

        public string IngredientPicture
        {
            get => _ingredientpicture;
        }
    }
}
