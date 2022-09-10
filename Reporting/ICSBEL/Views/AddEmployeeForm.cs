using ICSBEL.Models;
using System;
using System.Windows.Forms;

namespace ICSBEL
{
    public partial class AddEmployeeForm : Form
    {
        internal Employee emp;
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void employeeDataInsertButton_Click(object sender, EventArgs e)
        {
            bool isNotEmptyTextBoxes = CheckTextBoxes();
            if (isNotEmptyTextBoxes == true)
            {
                string name = employeeNameTextBox.Text;
                string surname = employeeSurnameTextBox.Text;
                string job = employeeJobTitleTextBox.Text;
                DateTime birthDate = employeeBirthDatePicker.Value.Date;
                double salary = 0.0;
                bool isConvertable = Double.TryParse(employeeSalaryTextBox.Text, out salary);
                if (isConvertable == false)
                {
                    MessageBox.Show("Значение поля 'Зарплата' должно быть числом!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                emp = new Employee(name, surname, job, birthDate, salary);

                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private bool CheckTextBoxes()
        {
            int notEmptyTextBoxCount = 0;
            int textBoxCount = 0;
            foreach (var item in Controls)
            {
                if (item is TextBox textBox)
                {
                    textBoxCount++;
                    if (!String.IsNullOrEmpty(textBox.Text))
                    {
                        notEmptyTextBoxCount++;
                    }
                }
            }
            if (textBoxCount == notEmptyTextBoxCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
