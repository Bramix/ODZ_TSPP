using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODZ_TSPP.Forms
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private int timeLeft { get; set; }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
            }
            else {
                timer1.Stop();
                new MainForm().Show();
                this.Hide();
            }
        }

        private void frmSplashScreen_Load_1(object sender, EventArgs e)
        {
            timeLeft = 20;
            timer1.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
