using System;
using System.Collections.Generic;
using System.IO;
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
        
        public List<User> ReadFile()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Word files (*.doc;*.docx;)|*.doc;*.docx)";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return null;
            var filename = openFileDialog.FileName;
            var users = File.ReadAllLines(filename)
                .Where(stringItem => !String.IsNullOrEmpty(stringItem))
                .Select(userText =>
                {
                    var properties = userText
                        .Replace(" ", string.Empty)
                        .Split(',')
                        .Select(item => item.Split(':')[1])
                        .ToList();
                    return new User(properties);
                })
                .ToList();

            return users;
        }

        //
        public void WriteUsersToFile()
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word files (*.doc;*.docx;)|*.doc;*.docx)";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string content = CurrentUserRepository.GetAllCurrentUsers()
                .Select(item => item.ToString())
                .Aggregate((first, second) => first + "\n\n" + second);

            string filename = saveFileDialog.FileName;
            File.WriteAllText(filename, content);
            MessageBox.Show("The file has been saved");
        }

        public void WriteUsersToFile(bool secondNameB, bool yearOfConnectionB, bool phoneNumberB, bool addressB, bool idB)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word files (*.doc;*.docx;)|*.doc;*.docx)";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string content = CurrentUserRepository.GetAllCurrentUsers()
                .Select(item => item.ToString(secondNameB, yearOfConnectionB, phoneNumberB, addressB, idB))
                .Aggregate((first, second) => first + "\n\n" + second);

            string filename = saveFileDialog.FileName;
            File.WriteAllText(filename, content);
            MessageBox.Show("The file has been saved");
        }
    }
}