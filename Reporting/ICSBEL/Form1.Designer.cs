
namespace ICSBEL
{
    partial class Reporting
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
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.connectToDBButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Location = new System.Drawing.Point(12, 250);
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.RowHeadersWidth = 51;
            this.employeesDataGridView.RowTemplate.Height = 29;
            this.employeesDataGridView.Size = new System.Drawing.Size(776, 188);
            this.employeesDataGridView.TabIndex = 0;
            // 
            // connectToDBButton
            // 
            this.connectToDBButton.Location = new System.Drawing.Point(8, 12);
            this.connectToDBButton.Name = "connectToDBButton";
            this.connectToDBButton.Size = new System.Drawing.Size(94, 29);
            this.connectToDBButton.TabIndex = 1;
            this.connectToDBButton.Text = "Connect";
            this.connectToDBButton.UseVisualStyleBackColor = true;
            this.connectToDBButton.Click += new System.EventHandler(this.connectToDBButton_Click);
            // 
            // Reporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.connectToDBButton);
            this.Controls.Add(this.employeesDataGridView);
            this.Name = "Reporting";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.Button connectToDBButton;
    }
}

