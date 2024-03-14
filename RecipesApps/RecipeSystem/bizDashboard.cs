using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class bizDashboard:bizObject<bizDashboard>
    {
        public bizDashboard() { }
        private string _category;
        private int _amount;
        public List<bizDashboard >GetTotalRecipesMealsCookbooks()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("TotalRecipesMealsCookbooksGet");
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }

        public string Category
        {
            get => _category;
            set
            {
                if (value != _category)
                {
                    _category = value;
                    InvokePropertyChanged();
                }
            }
        }
        public int Amount
        {
            get => _amount;
            set
            {
                if (value != _amount)
                {
                    _amount = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
