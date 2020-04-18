using System;
using System.Windows.Forms;
using ODZ_TSPP.Entity;
using ODZ_TSPP.Implementation;
using ODZ_TSPP.Service.Interface;

namespace ODZ_TSPP
{
    public partial class EditUserForm : Form
    {
        private IApplicantRepository _applicantRepository = new ApplicantRepository();

        User user = null;
        
        public EditUserForm()
        {
            InitializeComponent();
            lblTitle.Text = "Add the user";
        }

        public EditUserForm(User user)
        {
            InitializeComponent();
            btn1.Text = "Update";
            this.user = user;
            lblTitle.Text = "Update the user";
            //Validation
            //this.applicant.onValidationError += Contact_onValidationError;

            txtLastName.Text = this.user.SecondName;
            txtYearOfConnection.Text = this.user.YearOfConnection.ToString();
            txtPhoneNumber.Text = this.user.PhoneNumber;
            //txtNumberOfSchool.Text = this._user.NumberOfSchool.ToString();
        }
        void ShowError(string Text)
        {
            lblError.Text = Text;
            pnlError.Visible = true;
            tmrError.Start();
        }
        
        private void tmrError_Tick(object sender, EventArgs e)
        {
            tmrError.Stop();
            pnlError.Visible = false;

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                user = new User(
                    txtLastName.Text, 
                    int.Parse(txtYearOfConnection.Text),
                    txtPhoneNumber.Text,
                    null);
                
                if (_applicantRepository.addApplicant(user) > 0)
                {
                    MessageBox.Show("User has been saved");
                }
            }
            else
            {
                user.SecondName = txtLastName.Text;
                user.YearOfConnection = int.Parse(txtYearOfConnection.Text);
                user.PhoneNumber = txtPhoneNumber.Text;
                //addAdress
                if (_applicantRepository.EditApplicant(user) > 0) MessageBox.Show("User has been udated");
            }
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
