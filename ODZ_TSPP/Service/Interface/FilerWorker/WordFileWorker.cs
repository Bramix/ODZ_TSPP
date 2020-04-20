using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ODZ_TSPP.Entity;
using ODZ_TSPP.Service.Implementation;
using ODZ_TSPP.Service.Implementation.DAO;

namespace ODZ_TSPP.Service.Interface.FilerWorker
{
    public class WordFileWorker: IFileWorker
    {
        private UserRepository _userRepository = new UserRepository();
        
        public List<User> ReadFile(string filePath)
        {
            throw new System.NotImplementedException();
        }

        public void WriteUsersToFile()
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word files (*.doc;*.docx;)|*.doc;*.docx)";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string content = _userRepository.GetAllUsers()
                .Select(item => item.ToString())
                .Aggregate((first, second) => first + "\n\n" + second);
            
            string filename = saveFileDialog.FileName;
            System.IO.File.WriteAllText(filename, content);
            MessageBox.Show("The file has been saved");
        }
    }
}