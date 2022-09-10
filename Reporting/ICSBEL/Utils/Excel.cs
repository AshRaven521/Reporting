using ClosedXML.Excel;
using ICSBEL.DataAccessLayer;
using System;
using System.Data;
using System.Threading.Tasks;

namespace ICSBEL.Utils
{
    public static class Excel
    {
        public static async Task<bool> CreateReport(string path)
        {
            var data = await DB.GetSalariesForReport();
            try
            {
                using (IXLWorkbook workbook = new XLWorkbook())
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

        public static DataTable LoadReport(string path)
        {
            try
            {
                DataTable table = new DataTable();

                using (IXLWorkbook workbook = new XLWorkbook(path))
                {
                    IXLWorksheet worksheet = workbook.Worksheet(1);

                    bool isFirstRow = true;

                    foreach (IXLRow row in worksheet.Rows())
                    {
                        if (isFirstRow == true)
                        {
                            foreach (IXLCell cell in row.Cells())
                            {
                                table.Columns.Add(cell.Value.ToString());
                            }
                            isFirstRow = false;
                        }
                        else
                        {
                            table.Rows.Add();
                            int i = 0;
                            foreach (IXLCell cell in row.Cells())
                            {
                                table.Rows[table.Rows.Count - 1][i] = cell.Value.ToString();
                                i++;
                            }
                        }
                    }
                }
                return table;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка при загрузке excel файла! {ex.Message}");
                return null;
            }
        }
    }
}
