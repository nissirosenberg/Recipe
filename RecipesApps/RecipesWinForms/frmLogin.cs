using RecipesWinForms.Properties;
using System.Configuration;

namespace RecipesWinForms
{
    public partial class frmLogin : Form
    {
        bool loginsuccess = false;
        public frmLogin()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        public bool ShowLogin()
        {
            txtUserName.Text = Settings.Default.UserId;
#if DEBUG
            this.Text += " - DEV";
#endif
            this.ShowDialog();
            return loginsuccess;
        }

        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            try
            {
                string connstringkey = "";
#if DEBUG
                connstringkey = "devconn";
#else
                connstringkey = "liveconn";
#endif
                string connstring = ConfigurationManager.ConnectionStrings[connstringkey].ConnectionString;
                DBManager.SetConnectionString(connstring, true, txtUserName.Text, txtPassword.Text);
                loginsuccess = true;
                Settings.Default.UserId = txtUserName.Text;
                Settings.Default.Save();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid login. Please try again.", Application.ProductName);
            }
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
