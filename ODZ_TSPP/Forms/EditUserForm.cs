using System;
using System.Windows.Forms;
using ODZ_TSPP.Entity;
using ODZ_TSPP.Implementation;
using ODZ_TSPP.Interface;

namespace ODZ_TSPP
{
    public partial class EditUserForm : Form
    {
        private IApplicantRepository _applicantRepository = new ApplicantRepository();

        Applicant applicant = null;
        
        public EditUserForm()
        {
            InitializeComponent();
            lblTitle.Text = "Add the user";
        }

        public EditUserForm(Applicant applicant)
        {
            InitializeComponent();
            btn1.Text = "Update";
            this.applicant = applicant;
            lblTitle.Text = "Update the user";
            //Validation
            //this.applicant.onValidationError += Contact_onValidationError;

            txtFirstName.Text = this.applicant.FirstName;
            txtLastName.Text = this.applicant.SecondName;
            txtMarks.Text = this.applicant.Marks.ToString();
            txtNumberOfSchool.Text = this.applicant.NumberOfSchool.ToString();
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
            if (applicant == null)
            {
                applicant = new Applicant(txtFirstName.Text,
                    txtLastName.Text,
                    Double.Parse(txtMarks.Text),
                    int.Parse(txtNumberOfSchool.Text));
                
                if (_applicantRepository.addApplicant(applicant) > 0)
                {
                    MessageBox.Show("User has been saved");
                }
            }
            else
            {
                applicant.FirstName = txtFirstName.Text;
                applicant.SecondName = txtLastName.Text;
                applicant.Marks = Double.Parse(txtMarks.Text);
                applicant.NumberOfSchool = int.Parse(txtNumberOfSchool.Text);
                if (_applicantRepository.EditApplicant(applicant) > 0) MessageBox.Show("User has been udated");
            }
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
