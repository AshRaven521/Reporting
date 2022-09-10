using ICSBEL.DataAccessLayer;
using ICSBEL.Utils;
using ICSBEL.Views;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ICSBEL
{
    public partial class reportingForm : Form
    {

        public reportingForm()
        {
            InitializeComponent();
        }

        private async void insertEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployeeForm employeeWindow = new AddEmployeeForm();

            try
            {
                employeeWindow.ShowDialog();
                var newEmployee = employeeWindow.emp;
                if (newEmployee is null)
                {
                    MessageBox.Show("Объект созданного работника был null!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int employeeCount = await DB.InsertEmployeeIntoDB(newEmployee);
                    if (employeeCount != 0)
                    {
                        MessageBox.Show("Работник был добавлен успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var data = await DB.GetEmployeesFromDB();
                        employeesDataGridView.DataSource = data;
                    }
                    //employeesDataGridView.Refresh();
                    //employeesDataGridView.Update();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Произошла ошибка! {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void employeeJobTitleFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            (employeesDataGridView.DataSource as DataTable).DefaultView.RowFilter
                = String.Format("JobTitle like '{0}%'", employeeJobTitleFilterTextBox.Text);
            employeesDataGridView.Refresh();
        }

        private async void reportingForm_Load(object sender, EventArgs e)
        {
            try
            {
                var data = await DB.GetEmployeesFromDB();
                employeesDataGridView.DataSource = data;

                MessageBox.Show("Подключение произошло успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Произошла ошибка! {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void deleteEmployeeButton_Click(object sender, EventArgs e)
        {

            if (employeesDataGridView.SelectedRows.Count > 0)
            {
                int index = employeesDataGridView.SelectedRows[0].Index;
                int id = 0;
                bool isConvertable = Int32.TryParse(employeesDataGridView[0, index].Value.ToString(), out id);
                if (isConvertable == false)
                {
                    return;
                }

                int deletedEmployee = await DB.DeleteEmployeeFromDB(id);
                if (deletedEmployee != 0)
                {
                    MessageBox.Show("Работник был удален успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var data = await DB.GetEmployeesFromDB();
                    employeesDataGridView.DataSource = data;
                    //employeesDataGridView.Refresh();
                    //employeesDataGridView.Update();
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void createReportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog()
            {
                Filter = "Excel Workbook|*.xlsx|CSV files|*.csv",
                DefaultExt = ".xlsx",
                Title = "Выберите файл для сохранения отчета"
            };
            
            if (save.ShowDialog() == DialogResult.OK)
            {
                bool isSuccessfull = await Excel.CreateReport(save.FileName);
                if (isSuccessfull == true)
                {
                    MessageBox.Show($"Отчет создан успешно\nФайл расположен: {save.FileName}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowReportForm showReport = new ShowReportForm(save.FileName);
                    showReport.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Произошла ошибка при создании отчета!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
