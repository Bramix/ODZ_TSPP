using System;
using System.Collections.Generic;
using System.Linq;
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
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files(.xls)|*.xls| Excel Files(.xlsx)|*.xlsx| Excel Files(*.xlsm)|*.xlsm";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return null;
            var filename = openFileDialog.FileName;
            WorkBook xlsWorkbook = WorkBook.Load(filename);
            WorkSheet sheet = xlsWorkbook.WorkSheets.First();
            List <User> users = sheet.Rows
                .Skip(1)
                .Select(row =>
                {
                    var columns = row.Columns;
                    var properties = new List<string>();
                    
                    properties.Add(columns[0].Value.ToString());
                    properties.Add(columns[1].Value.ToString());
                    properties.Add(columns[2].Value.ToString());
                    
                    var subProperties = columns[3].Value.ToString()
                        .Replace(" ", string.Empty)
                        .Split(',')
                        .Select(item => item.Split(':')[1])
                        .ToArray();
                    
                    properties.AddRange(subProperties);
                    return new User(properties);
                })
                .ToList();

            return users;

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

            xlsSheet["A1"].Value = "Last Name";
            xlsSheet["B1"].Value = "Year of Connection";
            xlsSheet["C1"].Value = "Phone Number";
            xlsSheet["D1"].Value = "Address";
            for (int i = 2; i <= users.Count + 1; i++)
            {
                xlsSheet[$"A{i}"].Value = users[i - 2].SecondName;
                xlsSheet[$"B{i}"].Value = users[i - 2].YearOfConnection;
                xlsSheet[$"C{i}"].Value = users[i - 2].PhoneNumber;
                xlsSheet[$"D{i}"].Value = users[i - 2].Address.ToString();
            }
            xlsSheet["A2"].Style.BottomBorder.SetColor("#ff6600");
            xlsSheet["A2"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Double;
            xlsWorkbook.SaveAs(saveFileDialog.FileName);

        }
    }
}