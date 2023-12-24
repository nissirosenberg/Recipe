namespace RecipeSystem
{
    public class bizRecipe : bizObject<bizRecipe>
    {
        public bizRecipe() 
        {
        
        }
        private int _recipeid;
        private string _recipename;
        private int _cuisinetypeid;
        private int _calories;
        private string _recipepicture;
        private int _userid;
        private DateTime _datedrafted;
        private DateTime? _datepublished;
        private DateTime? _datearchived;
        private string _currentstatus;

        public List<bizRecipe> Search(string recipenameval)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(this.GetSprocName);
            SQLUtility.SetParameterValue(cmd, "RecipeName", recipenameval);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }

        public int RecipeId
        {
            get => _recipeid;
            set
            {
                if (value != _recipeid)
                {
                    _recipeid = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string RecipeName
        {
            get => _recipename;
            set
            {
                if (value != _recipename)
                {
                    _recipename = value;
                    InvokePropertyChanged();
                    InvokePropertyChanged("RecipePicture");
                }
            }
        }
        public int CuisineTypeId
        {
            get => _cuisinetypeid;
            set
            {
                if (value != _cuisinetypeid)
                {
                    _cuisinetypeid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int Calories
        {
            get => _calories;
            set
            {
                if (value != _calories)
                {
                    _calories = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string RecipePicture
        {
            get => _recipepicture;
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

        public DateTime DateDrafted
        {
            get => _datedrafted;
            set
            {
                if (value != _datedrafted)
                {
                    _datedrafted = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime? DatePublished
        {
            get => _datepublished;
            set
            {
                if (value != _datepublished)
                {
                    _datepublished = value;
                    InvokePropertyChanged();
                    InvokePropertyChanged("CurrentStatus");
                }
            }
        }

        public DateTime? DateArchived
        {
            get => _datearchived;
            set
            {
                if (value != _datearchived)
                {
                   _datearchived = value;
                    InvokePropertyChanged();
                    InvokePropertyChanged("CurrentStatus");
                }
            }
        }
        public string CurrentStatus
        {
            get => _currentstatus;
        }
    }
}
