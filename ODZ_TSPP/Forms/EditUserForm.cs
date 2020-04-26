using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ODZ_TSPP.Entity;
using ODZ_TSPP.Service.Implementation.DAO;
using ODZ_TSPP.Service.Interface;

namespace ODZ_TSPP
{
    public partial class EditUserForm : Form
    {
        private IUserRepository _userRepository = new UserRepository();

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

            txtLastName.Text = this.user.SecondName;
            txtYearOfConnection.Text = this.user.YearOfConnection.ToString();
            txtPhoneNumber.Text = this.user.PhoneNumber;
            txtCity.Text = this.user.Address.City;
            txtStreet.Text = this.user.Address.Street;
            txtNumberOfTheHouse.Text = this.user.Address.NumberOfHouse;
            txtNumberOfFlat.Text = this.user.Address.NumberOfFlat.ToString();
        }
        
        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                if (user == null)
                {
                    user = new User(
                        txtLastName.Text,
                        int.Parse(txtYearOfConnection.Text),
                        txtPhoneNumber.Text,
                        new Address(txtCity.Text, txtStreet.Text, txtNumberOfTheHouse.Text,
                            int.Parse(txtNumberOfFlat.Text))
                    );

                    if (_userRepository.addUser(user) > 0)
                    {
                        MessageBox.Show("The user has been saved");
                    }
                }
                else
                {
                    user.SecondName = txtLastName.Text;
                    user.YearOfConnection = int.Parse(txtYearOfConnection.Text);
                    user.PhoneNumber = txtPhoneNumber.Text;
                    user.Address = new Address(user.Address.Id, txtCity.Text, txtStreet.Text, txtNumberOfTheHouse.Text,
                        int.Parse(txtNumberOfFlat.Text), user.Address.UserId);
                    if (_userRepository.EditUser(user) > 0) MessageBox.Show("The user has been updated");
                }

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("NOT CORRECT DATA");
            }
        }
    }
}
