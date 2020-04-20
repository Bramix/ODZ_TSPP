using System.Collections.Generic;
using System.Windows.Forms;
using IronXL;
using ODZ_TSPP.Entity;
using ODZ_TSPP.Service.Implementation;
using ODZ_TSPP.Service.Implementation.DAO;

namespace ODZ_TSPP.Service.Interface.FilerWorker
{
    public class ExcelFileWorker: IFileWorker
    {
        UserRepository _userRepository = new UserRepository();
        public List<User> ReadFile()
        {
            MessageBox.Show("Not implemented yet");
            return null;
        }

        public void WriteUsersToFile()
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter =  "Excel|*.xls|Excel 2010|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            WorkBook xlsWorkbook = WorkBook.Create(ExcelFileFormat.XLS);
            xlsWorkbook.Metadata.Author = "KLB";
            WorkSheet xlsSheet = xlsWorkbook.CreateWorkSheet("new_sheet");
            
            var users = _userRepository.GetAllUsers();

            xlsSheet["A1"].Value = "ID";
            xlsSheet["B1"].Value = "Last Name";
            xlsSheet["C1"].Value = "Phone Number";
            xlsSheet["D1"].Value = "Address";
            for (int i = 2; i <= users.Count + 1; i++)
            {
                xlsSheet[$"A{i}"].Value = users[i - 2].Id;
                xlsSheet[$"B{i}"].Value = users[i - 2].SecondName;
                xlsSheet[$"C{i}"].Value = users[i - 2].PhoneNumber;
                xlsSheet[$"D{i}"].Value = users[i - 2].Address.ToString();
            }
            xlsSheet["A2"].Style.BottomBorder.SetColor("#ff6600");
            xlsSheet["A2"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Double;
            xlsWorkbook.SaveAs(saveFileDialog.FileName);

        }
    }
}