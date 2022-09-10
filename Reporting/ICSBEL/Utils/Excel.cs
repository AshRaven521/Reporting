using ClosedXML.Excel;
using ICSBEL.DataAccessLayer;
using System;
using System.Threading.Tasks;

namespace ICSBEL.Utils
{
    public static class Excel
    {
        public static async Task<bool> CreateReport(string path)
        {
            var data = await DB.GetSalariesForReport();
            //DataSetHelper.CreateWorkbook(path, data);
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    workbook.Worksheets.Add(data);
                    workbook.SaveAs(path);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка при формировании excel файла! {ex.Message}");
                return false;
            }
        }
    }
}
