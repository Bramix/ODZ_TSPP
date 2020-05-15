using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ODZ_TSPP.Entity;
using ODZ_TSPP.Service.Implementation;
using ODZ_TSPP.Service.Implementation.DAO;
using ODZ_TSPP.Service.Interface;
using ODZ_TSPP.Service.Interface.FilerWorker;

namespace ODZ_TSPP.Forms
{
    public partial class WordFilterDownloadForm : Form
    {
        private WordFileWorker _fileWorker;

        public WordFilterDownloadForm(WordFileWorker fileWorker)
        {
            _fileWorker = fileWorker;
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            _fileWorker.WriteUsersToFile(checkBoxes.GetItemChecked(0), checkBoxes.GetItemChecked(1), checkBoxes.GetItemChecked(2), checkBoxes.GetItemChecked(3), checkBoxes.GetItemChecked(4));//
            this.Close();
        }

        private void WordFilterDownloadForm_Load(object sender, EventArgs e)
        {
            for(int i=0;i!=checkBoxes.Items.Count;i++)
                checkBoxes.SetItemChecked(i,true);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}