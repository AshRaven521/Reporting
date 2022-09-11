
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
            this.employeesDataGridView.Location = new System.Drawing.Point(13, 72);
            this.employeesDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.ReadOnly = true;
            this.employeesDataGridView.RowHeadersWidth = 51;
            this.employeesDataGridView.RowTemplate.Height = 29;
            this.employeesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeesDataGridView.Size = new System.Drawing.Size(825, 281);
            this.employeesDataGridView.TabIndex = 0;
            // 
            // insertEmployeeButton
            // 
            this.insertEmployeeButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.insertEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertEmployeeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.insertEmployeeButton.Location = new System.Drawing.Point(887, 72);
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
            this.deleteEmployeeButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.deleteEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteEmployeeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteEmployeeButton.Location = new System.Drawing.Point(887, 110);
            this.deleteEmployeeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.Size = new System.Drawing.Size(272, 32);
            this.deleteEmployeeButton.TabIndex = 3;
            this.deleteEmployeeButton.Text = "Удалить сотрудника";
            this.deleteEmployeeButton.UseVisualStyleBackColor = false;
            this.deleteEmployeeButton.Click += new System.EventHandler(this.deleteEmployeeButton_Click);
            // 
            // createReportButton
            // 
            this.createReportButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.createReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createReportButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createReportButton.Location = new System.Drawing.Point(887, 149);
            this.createReportButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(272, 32);
            this.createReportButton.TabIndex = 4;
            this.createReportButton.Text = "Составить отчет";
            this.createReportButton.UseVisualStyleBackColor = false;
            this.createReportButton.Click += new System.EventHandler(this.createReportButton_Click);
            // 
            // employeeJobTitleFilterLabel
            // 
            this.employeeJobTitleFilterLabel.AutoSize = true;
            this.employeeJobTitleFilterLabel.Location = new System.Drawing.Point(13, 21);
            this.employeeJobTitleFilterLabel.Name = "employeeJobTitleFilterLabel";
            this.employeeJobTitleFilterLabel.Size = new System.Drawing.Size(325, 22);
            this.employeeJobTitleFilterLabel.TabIndex = 5;
            this.employeeJobTitleFilterLabel.Text = "Введите должность для фильтрации:";
            // 
            // employeeJobTitleFilterTextBox
            // 
            this.employeeJobTitleFilterTextBox.Location = new System.Drawing.Point(344, 18);
            this.employeeJobTitleFilterTextBox.Name = "employeeJobTitleFilterTextBox";
            this.employeeJobTitleFilterTextBox.Size = new System.Drawing.Size(246, 30);
            this.employeeJobTitleFilterTextBox.TabIndex = 6;
            this.employeeJobTitleFilterTextBox.TextChanged += new System.EventHandler(this.employeeJobTitleFilterTextBox_TextChanged);
            // 
            // reportingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1163, 392);
            this.Controls.Add(this.employeeJobTitleFilterTextBox);
            this.Controls.Add(this.employeeJobTitleFilterLabel);
            this.Controls.Add(this.createReportButton);
            this.Controls.Add(this.deleteEmployeeButton);
            this.Controls.Add(this.insertEmployeeButton);
            this.Controls.Add(this.employeesDataGridView);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "reportingForm";
            this.Text = "Reporting";
            this.Load += new System.EventHandler(this.reportingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.Button insertEmployeeButton;
        private System.Windows.Forms.Button deleteEmployeeButton;
        private System.Windows.Forms.Button createReportButton;
        private System.Windows.Forms.Label employeeJobTitleFilterLabel;
        private System.Windows.Forms.TextBox employeeJobTitleFilterTextBox;
    }
}

