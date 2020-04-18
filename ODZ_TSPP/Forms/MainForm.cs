﻿using System;
 using System.Collections.Generic;
 using System.Windows.Forms;
 using ODZ_TSPP.Entity;
 using ODZ_TSPP.Implementation;
 using ODZ_TSPP.Service.Interface;

 namespace ODZ_TSPP
{
    public partial class MainForm : Form
    {
        private IApplicantRepository _applicantRepository = new ApplicantRepository();
        public MainForm()
        {
            InitializeComponent();
        }

       private void create_user(object sender, EventArgs e)
        {
            new EditUserForm().ShowDialog();
            ReloadData();
        }

        void ReloadData()
        {
            if(txtSearch.Text.Trim().Length > 0)
            {
                PopulateData(new List<User>());
            }
            else
            {
                PopulateData(_applicantRepository.GetAllApplicants());
            }
        }

        void PopulateData(IEnumerable<User> applicants)
        {
            table.Rows.Clear();
            foreach (var applicant in applicants)
            {
                table.Rows.Add(new object[]{
                    applicant.Id,
                    applicant.SecondName,
                    applicant.YearOfConnection,
                    applicant.PhoneNumber,
                    null,
                    "Edit",
                    "Delete"
                });
                table.Rows[table.RowCount - 1].Tag = applicant;
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
            if(e.ColumnIndex == 5) //edit
            {
                new EditUserForm((User) table.CurrentRow.Tag).ShowDialog();
                ReloadData();
            }
            if (e.ColumnIndex == 6) //delete
            {
                User user = (User) table.CurrentRow.Tag;
                if (MessageBox.Show("Do you want to delete " + user.SecondName +"?","CONFIRM", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    _applicantRepository.RemoveApplicantById(user.Id);
                    ReloadData();
                }
            }
        }

       private void pnlHeader_Paint(object sender, PaintEventArgs e)
       {
           throw new System.NotImplementedException();
       }

       private void button2_Click(object sender, EventArgs e)
       {
           throw new System.NotImplementedException();
       }
    }
}
