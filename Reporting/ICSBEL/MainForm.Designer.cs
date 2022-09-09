
namespace ICSBEL
{
    partial class reportingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reportingForm));
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.connectToDBButton = new System.Windows.Forms.Button();
            this.insertEmployeeButton = new System.Windows.Forms.Button();
            this.deleteEmployeeButton = new System.Windows.Forms.Button();
            this.createReportButton = new System.Windows.Forms.Button();
            this.employeeJobTitleFilterLabel = new System.Windows.Forms.Label();
            this.employeeJobTitleFilterTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Location = new System.Drawing.Point(138, 276);
            this.employeesDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.ReadOnly = true;
            this.employeesDataGridView.RowHeadersWidth = 51;
            this.employeesDataGridView.RowTemplate.Height = 29;
            this.employeesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeesDataGridView.Size = new System.Drawing.Size(699, 207);
            this.employeesDataGridView.TabIndex = 0;
            // 
            // connectToDBButton
            // 
            this.connectToDBButton.BackColor = System.Drawing.Color.Tomato;
            this.connectToDBButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectToDBButton.Location = new System.Drawing.Point(679, 12);
            this.connectToDBButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.connectToDBButton.Name = "connectToDBButton";
            this.connectToDBButton.Size = new System.Drawing.Size(272, 32);
            this.connectToDBButton.TabIndex = 1;
            this.connectToDBButton.Text = "Подключиться";
            this.connectToDBButton.UseVisualStyleBackColor = false;
            this.connectToDBButton.Click += new System.EventHandler(this.connectToDBButton_Click);
            // 
            // insertEmployeeButton
            // 
            this.insertEmployeeButton.BackColor = System.Drawing.Color.Tomato;
            this.insertEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertEmployeeButton.Enabled = false;
            this.insertEmployeeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.insertEmployeeButton.Location = new System.Drawing.Point(679, 74);
            this.insertEmployeeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.insertEmployeeButton.Name = "insertEmployeeButton";
            this.insertEmployeeButton.Size = new System.Drawing.Size(272, 32);
            this.insertEmployeeButton.TabIndex = 2;
            this.insertEmployeeButton.Text = "Добавить сотрудника";
            this.insertEmployeeButton.UseVisualStyleBackColor = false;
            this.insertEmployeeButton.Click += new System.EventHandler(this.insertEmployeeButton_Click);
            // 
            // deleteEmployeeButton
            // 
            this.deleteEmployeeButton.BackColor = System.Drawing.Color.Tomato;
            this.deleteEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteEmployeeButton.Enabled = false;
            this.deleteEmployeeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteEmployeeButton.Location = new System.Drawing.Point(679, 112);
            this.deleteEmployeeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.Size = new System.Drawing.Size(272, 32);
            this.deleteEmployeeButton.TabIndex = 3;
            this.deleteEmployeeButton.Text = "Удалить сотрудника";
            this.deleteEmployeeButton.UseVisualStyleBackColor = false;
            // 
            // createReportButton
            // 
            this.createReportButton.BackColor = System.Drawing.Color.Tomato;
            this.createReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createReportButton.Enabled = false;
            this.createReportButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.createReportButton.Location = new System.Drawing.Point(679, 151);
            this.createReportButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(272, 32);
            this.createReportButton.TabIndex = 4;
            this.createReportButton.Text = "Составить отчет";
            this.createReportButton.UseVisualStyleBackColor = false;
            // 
            // employeeJobTitleFilterLabel
            // 
            this.employeeJobTitleFilterLabel.AutoSize = true;
            this.employeeJobTitleFilterLabel.Location = new System.Drawing.Point(16, 13);
            this.employeeJobTitleFilterLabel.Name = "employeeJobTitleFilterLabel";
            this.employeeJobTitleFilterLabel.Size = new System.Drawing.Size(183, 22);
            this.employeeJobTitleFilterLabel.TabIndex = 5;
            this.employeeJobTitleFilterLabel.Text = "Введите должность:";
            this.employeeJobTitleFilterLabel.Visible = false;
            // 
            // employeeJobTitleFilterTextBox
            // 
            this.employeeJobTitleFilterTextBox.Location = new System.Drawing.Point(227, 10);
            this.employeeJobTitleFilterTextBox.Name = "employeeJobTitleFilterTextBox";
            this.employeeJobTitleFilterTextBox.Size = new System.Drawing.Size(125, 30);
            this.employeeJobTitleFilterTextBox.TabIndex = 6;
            this.employeeJobTitleFilterTextBox.Visible = false;
            this.employeeJobTitleFilterTextBox.TextChanged += new System.EventHandler(this.employeeJobTitleFilterTextBox_TextChanged);
            // 
            // reportingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(965, 495);
            this.Controls.Add(this.employeeJobTitleFilterTextBox);
            this.Controls.Add(this.employeeJobTitleFilterLabel);
            this.Controls.Add(this.createReportButton);
            this.Controls.Add(this.deleteEmployeeButton);
            this.Controls.Add(this.insertEmployeeButton);
            this.Controls.Add(this.connectToDBButton);
            this.Controls.Add(this.employeesDataGridView);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "reportingForm";
            this.Text = "Reporting";
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.Button connectToDBButton;
        private System.Windows.Forms.Button insertEmployeeButton;
        private System.Windows.Forms.Button deleteEmployeeButton;
        private System.Windows.Forms.Button createReportButton;
        private System.Windows.Forms.Label employeeJobTitleFilterLabel;
        private System.Windows.Forms.TextBox employeeJobTitleFilterTextBox;
    }
}

