namespace RecipeSystem
{
    public class bizMeal: bizObject<bizMeal>
    {
        public bizMeal() { }
        private int _mealid;
        private int _userid;
        private string _username;
        private string _mealname;
        private bool _active;
        private DateTime _datecreated;
        private string _mealdesc;

        public List<bizMeal> GetMealList()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("MealListGet");
            return this.GetListFromDataTable(SQLUtility.GetDataTable(cmd));
        }

        public int MealId
        {
            get => _mealid;
            set
            {
                if (value != _mealid)
                {
                    _mealid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int UserId
        {
            get => _userid;
            set
            {
                if (value != _userid)
                {
                    _userid = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string UserName
        {
            get => _username;
            set
            {
                if (value != _username)
                {
                    _username = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string Mealname
        {
            get => _mealname;
            set
            {
                if (value != _mealname)
                {
                    _mealname = value;
                    InvokePropertyChanged();
                }
            }
        }
        public bool Active
        {
            get => _active;
            set
            {
                if (value != _active)
                {
                    _active = value;
                    InvokePropertyChanged();
                }
            }
        }
        public DateTime DateCreated
        {
            get => _datecreated;
            set
            {
                if (value != _datecreated)
                {
                    _datecreated = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string Mealdesc
        {
            get => _mealdesc;
            set
            {
                if (value != _mealdesc)
                {
                    _mealdesc = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
