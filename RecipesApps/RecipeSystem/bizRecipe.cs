using CPUFramework;

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
        private string _username;
        private DateTime _datedrafted;
        private DateTime? _datepublished;
        private DateTime? _datearchived;
        private string _currentstatus;
        private int _numingredients;
        private bool _vegan;
        //private List<bizUser> _lstuser;

        public List<bizRecipe> Search(string recipenameval)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(this.GetSprocName);
            SQLUtility.SetParameterValue(cmd, "RecipeName", recipenameval);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }

        public List<bizRecipe> LoadByRecipeId(int recipeid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(this.GetSprocName);
            cmd.Parameters["@RecipeId"].Value = recipeid;
            var dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }
        public List<bizRecipe> LoadByCookbookId(string uniquecookbookid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookRecipeGet");
            cmd.Parameters["@UniqueCookbookId"].Value = uniquecookbookid;
            dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }

        //public bizUser? UserName
        //{
        //    get => _lstuser?.FirstOrDefault(p => p.UserId == this.UserId);
        //    set
        //    {
        //        this.UserId = value == null ? 0 : value.UserId;
        //        InvokePropertyChanged();
        //    }
        //}

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
            set
            {
                if (value != _recipepicture)
                {
                    _recipepicture = value;
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
            set
            {
                if (value != _currentstatus)
                {
                    _currentstatus = value;
                    InvokePropertyChanged();
                }
            }
        }
        public int NumIngredients
        {
            get => _numingredients;
            set
            {
                if (value != _numingredients)
                {
                    _numingredients = value;
                    InvokePropertyChanged();
                }
            }
        }

        public bool Vegan
        {
            get => _vegan;
            set
            {
                if (value != _vegan)
                {
                    _vegan = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
