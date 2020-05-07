using System;
using System.Windows.Forms;
using ODZ_TSPP.Service.Implementation;
using ODZ_TSPP.Service.Interface;

namespace ODZ_TSPP
{
    public partial class LoginForm : Form
    {
        public IAccessWorker accessWorker = new AccessWorker()
;        public LoginForm()
        {
            InitializeComponent();
        }

        private void TryLogin(object sender, EventArgs e)
        {
            bool isValid = accessWorker.CheckUserRole(this.Login.Text, this.Password.Text);
            if (isValid)
            {
                ConfigStrings.currentUserRole = this.Login.Text;
                //this.Close();
            }
            else
            {
                MessageBox.Show("Inputed role or password is incorrect");
            }
        }
    }
}