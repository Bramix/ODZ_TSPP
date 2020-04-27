using System;
using System.IO;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;

namespace ODZ_TSPP
{
    public partial class DbConfigurationForm : Form
    {
        public DbConfigurationForm()
        {
            InitializeComponent();
        }

        private void Complete_Click(object sender, EventArgs e)
        {
            var host = this.textBox1.Text;
            var port = this.textBox2.Text;
            var database = this.textBox3.Text;
            var user = this.textBox4.Text;
            var password = this.textBox5.Text;
            var connectionString = $"Server={host};Port={port};Database={database};Uid={user};Pwd={password};";
            
            File.WriteAllText("..\\..\\Connection.txt",connectionString );
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            Application.Exit();
        }
    }
}