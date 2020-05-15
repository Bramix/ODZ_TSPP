using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ODZ_TSPP.Entity;
using ODZ_TSPP.Service.Implementation;
using ODZ_TSPP.Service.Implementation.DAO;
using ODZ_TSPP.Service.Interface;
using ODZ_TSPP.Service.Interface.FilerWorker;
using ODZ_TSPP.Forms;

namespace ODZ_TSPP
{
    public partial class UploadOrDownLoadForm : Form
    {
        private IFileWorker _fileWorker;
        private MainForm mainForm;
        private IUserRepository _userRepository = new UserRepository();
        public UploadOrDownLoadForm(IFileWorker fileWorker, MainForm form)
        {
            _fileWorker = fileWorker;
            mainForm = form;
            InitializeComponent();
        }

        private void download_Click(object sender, EventArgs e)
        {
            if (_fileWorker is WordFileWorker)
            {
                new WordFilterDownloadForm(new WordFileWorker()).ShowDialog();
                this.Close();
            }
            else
            {
                _fileWorker.WriteUsersToFile();
                this.Close();
            }
        }

        private void upload_Click(object sender, EventArgs e)
        {
            try
            {
                List<User> users = _fileWorker.ReadFile();
                if (users != null) users.ForEach(user => _userRepository.addUser(user));

                mainForm.ReloadData();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("The file for import is not correct");
            }
            catch (IOException)
            {
                MessageBox.Show("the file is already in use or was left open by another application");
            }
            this.Close();
        }
    }
}