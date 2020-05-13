﻿using System;
 using System.Collections.Generic;
 using System.Linq;
using System.Threading;
using System.Windows.Forms;
 using ODZ_TSPP.Entity;
using ODZ_TSPP.Forms;
using ODZ_TSPP.Service.Implementation.DAO;
 using ODZ_TSPP.Service.Interface;
 using ODZ_TSPP.Service.Interface.FilerWorker;

 namespace ODZ_TSPP
 {
     public partial class MainForm : Form
     {
         private IUserRepository _userRepository = new UserRepository();

         public MainForm()
         {
 
            InitializeComponent();
         }

        

        public MainForm(List <User> users)
         {
             InitializeComponent();
         }

         private void create_user(object sender, EventArgs e)
         {
             new EditUserForm().ShowDialog();
             ReloadData();
         }

         public void ReloadData(List<User> users)
         {
             PopulateData(users);
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

         private void frmContactList_Shown(object sender, EventArgs e)
         {
             ReloadData();
         }

         private void txtSearch_TextChanged(object sender, EventArgs e)
         {
             ReloadData();
         }

         private void table_CellClick(object sender, DataGridViewCellEventArgs e)
         {
             if (e.ColumnIndex == 5) //edit
             {
                 new EditUserForm((User) table.CurrentRow.Tag).ShowDialog();
                 ReloadData();
             }

             if (e.ColumnIndex == 6) //delete
             {
                 User user = (User) table.CurrentRow.Tag;
                 if (MessageBox.Show("Do you want to delete " + user.SecondName + "?", "CONFIRM",
                     MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                 {
                     _userRepository.RemoveUser(user);
                     ReloadData();
                 }
             }
         }

         private void ClickWordButton(object sender, EventArgs e)
         {
             new UploadOrDownLoadForm(new WordFileWorker(), this).ShowDialog();
         }

         private void ClickExcelButton(object sender, EventArgs e)
         {
             new UploadOrDownLoadForm(new ExcelFileWorker(), this).ShowDialog();
         }

         private void FilterByFields(object sender, EventArgs e)
         {
             new SearchForm(this).Show();
         }

         private void ClickCongigure(object sender, EventArgs e)
         {
             new DbConfigurationForm().Show();
         }


        private void ClickMenu(object sender, EventArgs e)
        {
            new Forms.Menu( _userRepository, txtSearch, table).ShowDialog();//
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
    
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            Form ifrm = Application.OpenForms[0];
            ifrm.Close();
        }
    }
 }
