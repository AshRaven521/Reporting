
namespace ICSBEL
{
    partial class AddEmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.employeeSurnameLabel = new System.Windows.Forms.Label();
            this.employeeBirthDateLabel = new System.Windows.Forms.Label();
            this.employeeSalaryLabel = new System.Windows.Forms.Label();
            this.employeeJobTitleLabel = new System.Windows.Forms.Label();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeSurnameTextBox = new System.Windows.Forms.TextBox();
            this.employeeJobTitleTextBox = new System.Windows.Forms.TextBox();
            this.employeeSalaryTextBox = new System.Windows.Forms.TextBox();
            this.employeeBirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.employeeDataInsertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(36, 22);
            this.employeeNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(52, 22);
            this.employeeNameLabel.TabIndex = 0;
            this.employeeNameLabel.Text = "Имя:";
            // 
            // employeeSurnameLabel
            // 
            this.employeeSurnameLabel.AutoSize = true;
            this.employeeSurnameLabel.Location = new System.Drawing.Point(36, 69);
            this.employeeSurnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeSurnameLabel.Name = "employeeSurnameLabel";
            this.employeeSurnameLabel.Size = new System.Drawing.Size(95, 22);
            this.employeeSurnameLabel.TabIndex = 1;
            this.employeeSurnameLabel.Text = "Фамилия:";
            // 
            // employeeBirthDateLabel
            // 
            this.employeeBirthDateLabel.AutoSize = true;
            this.employeeBirthDateLabel.Location = new System.Drawing.Point(38, 157);
            this.employeeBirthDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeBirthDateLabel.Name = "employeeBirthDateLabel";
            this.employeeBirthDateLabel.Size = new System.Drawing.Size(145, 22);
            this.employeeBirthDateLabel.TabIndex = 2;
            this.employeeBirthDateLabel.Text = "Дата рождения:";
            // 
            // employeeSalaryLabel
            // 
            this.employeeSalaryLabel.AutoSize = true;
            this.employeeSalaryLabel.Location = new System.Drawing.Point(38, 202);
            this.employeeSalaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeSalaryLabel.Name = "employeeSalaryLabel";
            this.employeeSalaryLabel.Size = new System.Drawing.Size(92, 22);
            this.employeeSalaryLabel.TabIndex = 3;
            this.employeeSalaryLabel.Text = "Зарплата:";
            // 
            // employeeJobTitleLabel
            // 
            this.employeeJobTitleLabel.AutoSize = true;
            this.employeeJobTitleLabel.Location = new System.Drawing.Point(36, 114);
            this.employeeJobTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeJobTitleLabel.Name = "employeeJobTitleLabel";
            this.employeeJobTitleLabel.Size = new System.Drawing.Size(112, 22);
            this.employeeJobTitleLabel.TabIndex = 4;
            this.employeeJobTitleLabel.Text = "Должность:";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(115, 14);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(125, 30);
            this.employeeNameTextBox.TabIndex = 5;
            // 
            // employeeSurnameTextBox
            // 
            this.employeeSurnameTextBox.Location = new System.Drawing.Point(148, 61);
            this.employeeSurnameTextBox.Name = "employeeSurnameTextBox";
            this.employeeSurnameTextBox.Size = new System.Drawing.Size(125, 30);
            this.employeeSurnameTextBox.TabIndex = 6;
            // 
            // employeeJobTitleTextBox
            // 
            this.employeeJobTitleTextBox.Location = new System.Drawing.Point(172, 106);
            this.employeeJobTitleTextBox.Name = "employeeJobTitleTextBox";
            this.employeeJobTitleTextBox.Size = new System.Drawing.Size(125, 30);
            this.employeeJobTitleTextBox.TabIndex = 7;
            // 
            // employeeSalaryTextBox
            // 
            this.employeeSalaryTextBox.Location = new System.Drawing.Point(148, 194);
            this.employeeSalaryTextBox.Name = "employeeSalaryTextBox";
            this.employeeSalaryTextBox.Size = new System.Drawing.Size(125, 30);
            this.employeeSalaryTextBox.TabIndex = 8;
            // 
            // employeeBirthDatePicker
            // 
            this.employeeBirthDatePicker.Location = new System.Drawing.Point(210, 149);
            this.employeeBirthDatePicker.Name = "employeeBirthDatePicker";
            this.employeeBirthDatePicker.Size = new System.Drawing.Size(250, 30);
            this.employeeBirthDatePicker.TabIndex = 9;
            // 
            // employeeDataInsertButton
            // 
            this.employeeDataInsertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeeDataInsertButton.Location = new System.Drawing.Point(38, 253);
            this.employeeDataInsertButton.Name = "employeeDataInsertButton";
            this.employeeDataInsertButton.Size = new System.Drawing.Size(235, 29);
            this.employeeDataInsertButton.TabIndex = 10;
            this.employeeDataInsertButton.Text = "Добавить";
            this.employeeDataInsertButton.UseVisualStyleBackColor = true;
            this.employeeDataInsertButton.Click += new System.EventHandler(this.employeeDataInsertButton_Click);
            // 
            // AddEmployeeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 316);
            this.Controls.Add(this.employeeDataInsertButton);
            this.Controls.Add(this.employeeBirthDatePicker);
            this.Controls.Add(this.employeeSalaryTextBox);
            this.Controls.Add(this.employeeJobTitleTextBox);
            this.Controls.Add(this.employeeSurnameTextBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.employeeJobTitleLabel);
            this.Controls.Add(this.employeeSalaryLabel);
            this.Controls.Add(this.employeeBirthDateLabel);
            this.Controls.Add(this.employeeSurnameLabel);
            this.Controls.Add(this.employeeNameLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddEmployeeWindow";
            this.Text = "AddEmployeeWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label employeeSurnameLabel;
        private System.Windows.Forms.Label employeeBirthDateLabel;
        private System.Windows.Forms.Label employeeSalaryLabel;
        private System.Windows.Forms.Label employeeJobTitleLabel;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.TextBox employeeSurnameTextBox;
        private System.Windows.Forms.TextBox employeeJobTitleTextBox;
        private System.Windows.Forms.TextBox employeeSalaryTextBox;
        private System.Windows.Forms.DateTimePicker employeeBirthDatePicker;
        private System.Windows.Forms.Button employeeDataInsertButton;
    }
}