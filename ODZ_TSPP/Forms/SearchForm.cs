using System;
using System.Windows.Forms;

namespace ODZ_TSPP
{
    public partial class SearchForm : Form
    {
        public SearchForm(string text)
        {
            InitializeComponent();
            this.textBox1.Text = text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}