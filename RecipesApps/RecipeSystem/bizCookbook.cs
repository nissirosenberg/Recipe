namespace RecipeSystem
{
    public class bizCookbook : bizObject<bizCookbook>
    {
        public bizCookbook() { }
        private int _cookbookid;
        private string _uniquecookbookid;
        private int _userid;
        private string _username;
        private string _cookbookname;
        private decimal _price;
        private bool _active;
        private DateTime _datecreated;
        private string _cookbookpicture;
        private int _cookbookskill;
        private string _cookbookskilldesc;



        public List<bizCookbook> LoadByCookbookId(int cookbookid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(this.GetSprocName);
            cmd.Parameters["@CookbookId"].Value = cookbookid;
            var dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }

        public int CookbookId
        {
            get => _cookbookid;
            set
            {
                if (value != _cookbookid)
                {
                    _cookbookid = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string UniqueCookbookId
        {
            get => _uniquecookbookid;
            set
            {
                if (value != _uniquecookbookid)
                {
                    _uniquecookbookid = value;
                    InvokePropertyChanged();
                }
            }
        }
        public int Userid
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
        public string CookbookName
        {
            get => _cookbookname;
            set
            {
                if (value != _cookbookname)
                {
                    _cookbookname = value;
                    InvokePropertyChanged();
                    InvokePropertyChanged("CookbookPicture");
                }
            }
        }

        public decimal Price
        {
            get => _price;
            set
            {
                if (value != _price)
                {
                    _price = value;
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
        public string CookbookPicture
        {
            get => _cookbookpicture;
            set
            {
                if (value != _cookbookpicture)
                {
                    _cookbookpicture = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int CookbookSkill
        {
            get => _cookbookskill;
            set
            {
                if (value != _cookbookskill)
                {
                    _cookbookskill = value;
                    InvokePropertyChanged();
                    InvokePropertyChanged("CookbookSkillDesc");
                }
            }
        }

        public string CookbookSkillDesc
        {
            get => _cookbookskilldesc;
            set
            {
                if (value != _cookbookskilldesc)
                {
                    _cookbookskilldesc = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
