using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICSBEL.Models;

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
            if(isNotEmptyTextBoxes == true)
            {
                string name = employeeNameTextBox.Text;
                string surname = employeeSurnameTextBox.Text;
                string job = employeeJobTitleTextBox.Text;
                DateTime birthDate = employeeBirthDatePicker.Value.Date;
                double salary = double.Parse(employeeSalaryTextBox.Text);

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
