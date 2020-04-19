using System;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ODZ_TSPP
{
    public static class Program
    {
        
        [STAThread]
        public static void Main()
        {
            var script = File.ReadAllText( "..\\..\\Start.sql");
            using (MySqlConnection conn = new MySqlConnection(ConfigStrings.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(script, conn))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}