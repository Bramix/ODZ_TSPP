using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ODZ_TSPP.Service.Implementation.DAO;
using ODZ_TSPP.Service.Interface;
using ODZ_TSPP.Service.Interface.FilerWorker;



using System.Threading;
using System.Windows.Forms;
using ODZ_TSPP.Entity;
using ODZ_TSPP.Forms;


namespace ODZ_TSPP.Forms
{
    public partial class Menu : Form
    {

        private IUserRepository _userRepository;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView table;

        public Menu()
        {
            InitializeComponent();
        }

        public Menu(IUserRepository _userRepository, System.Windows.Forms.TextBox txtSearch, System.Windows.Forms.DataGridView table)
        {
            this._userRepository = _userRepository;
            this.txtSearch = txtSearch;
            this.table = table;
            InitializeComponent();
        }

        private void create_user(object sender, EventArgs e)
        {
            new EditUserForm().ShowDialog();
            ReloadData();
        }

        public void ReloadData()
        {
            if (txtSearch.Text.Trim().Length > 0)
            {
                List<User> users = _userRepository.GetAllUsers();
                PopulateData(users.FindAll(user => user.ToString().ToUpper().Contains(txtSearch.Text.ToUpper())));
            }
            else
            {
                PopulateData(_userRepository.GetAllUsers());
            }
        }

        void PopulateData(IEnumerable<User> users)
        {
            table.Rows.Clear();
            foreach (User user in users)
            {
                table.Rows.Add(new object[]
                {
                     user.Id,
                     user.SecondName,
                     user.YearOfConnection,
                     user.PhoneNumber,
                     user.Address.ToString(),
                     "Edit",
                     "Delete"
                });
                table.Rows[table.RowCount - 1].Tag = user;
            }
        }



        private void ClickWordButton(object sender, EventArgs e)
        {
            new UploadOrDownLoadForm(new WordFileWorker(), (MainForm)Application.OpenForms["MainForm"]).ShowDialog();
        }

        private void ClickExcelButton(object sender, EventArgs e)
        {
            new UploadOrDownLoadForm(new ExcelFileWorker(), (MainForm)Application.OpenForms["MainForm"]).ShowDialog();
        }

        private void FilterByFields(object sender, EventArgs e)
        {
            new SearchForm((MainForm)Application.OpenForms["MainForm"]).Show();
        }

        private void ClickCongigure(object sender, EventArgs e)
        {
            new DbConfigurationForm().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClickCancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
