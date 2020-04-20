using System;
using System.Windows.Forms;
using ODZ_TSPP.Service.Implementation;
using Org.BouncyCastle.Crypto.Tls;

namespace ODZ_TSPP
{
    public partial class UploadOrDownLoadForm : Form
    {
        private IFileWorker _fileWorker;
        public UploadOrDownLoadForm(IFileWorker fileWorker)
        {
            _fileWorker = fileWorker;
            InitializeComponent();
        }

        private void download_Click(object sender, EventArgs e)
        {
            _fileWorker.WriteUsersToFile();
            this.Close();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            _fileWorker.ReadFile();
            this.Close();
        }
    }
}