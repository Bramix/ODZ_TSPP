using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DocumentFormat.OpenXml.Wordprocessing;
using ODZ_TSPP.Service.Implementation.DAO;

namespace ODZ_TSPP
{
    public partial class SearchForm : Form
    {
        private UserRepository userRepository = new UserRepository();
        private Dictionary<string, Tuple<string, string>> dictionary = new Dictionary<string, Tuple<string, string>>();
        private MainForm mainForm;
        public SearchForm(MainForm form)
        {
            mainForm = form;
            InitializeComponent();

        }

        private void AddFilter(object sender, EventArgs e)
        {
            var typeOfOperaton = this.typeOfOperation.Text;
            var field = this.Fields.Text;
            var value = this.value.Text;
            var andOr = AndOr.Text;
            var resultText = textBox.Text;

            if ((field == Namings.YearOfConnection.ToString() || field == Namings.NumberOfFlat.ToString()) && !value.All(char.IsDigit) )
            {
                MessageBox.Show("field should have integer value for this case");
                return;
            }
            
            if (!resultText.Contains("where"))
            {
                textBox.Text = new StringBuilder(textBox.Text)
                    .Append(" where ")
                    .Append(field)
                    .Append(" ")
                    .Append(typeOfOperaton)
                    .Append(" ")
                    .Append(value)
                    .ToString();
            }
            else
            {
                if (String.IsNullOrEmpty(andOr))
                {
                    MessageBox.Show("Add or/add operation");
                }
                textBox.Text = new StringBuilder(textBox.Text)
                    .Append(" ")
                    .Append(andOr)
                    .Append(" ")
                    .Append(field)
                    .Append(" ")
                    .Append(typeOfOperaton)
                    .Append(" ")
                    .Append(value)
                    .ToString();;
            }
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Filter(object sender, EventArgs e)
        {
            try
            {
                var users = userRepository.GetUsersByQuery(textBox.Text);
               // new MainForm(users).Show();
               mainForm.ReloadData(users);
               this.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Some parameters of the sql query is invalid");
            }
          
            
        }
    }
}