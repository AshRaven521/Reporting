
namespace ICSBEL.Views
{
    partial class ShowReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowReportForm));
            this.reportGridView = new System.Windows.Forms.DataGridView();
            this.reportLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reportGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reportGridView
            // 
            this.reportGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.reportGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportGridView.Location = new System.Drawing.Point(60, 63);
            this.reportGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.reportGridView.Name = "reportGridView";
            this.reportGridView.RowHeadersWidth = 51;
            this.reportGridView.RowTemplate.Height = 29;
            this.reportGridView.Size = new System.Drawing.Size(325, 280);
            this.reportGridView.TabIndex = 0;
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Location = new System.Drawing.Point(28, 21);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(414, 22);
            this.reportLabel.TabIndex = 1;
            this.reportLabel.Text = "Отчет(средняя зарплата для каждой должноти)";
            // 
            // ShowReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(454, 375);
            this.Controls.Add(this.reportLabel);
            this.Controls.Add(this.reportGridView);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowReportForm";
            this.Text = "ShowReportForm";
            this.Load += new System.EventHandler(this.showReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reportGridView;
        private System.Windows.Forms.Label reportLabel;
    }
}