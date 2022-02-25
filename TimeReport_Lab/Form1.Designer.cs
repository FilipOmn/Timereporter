
namespace TimeReport_Lab
{
    partial class TimeReportForm
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
            this.components = new System.ComponentModel.Container();
            this.TimeReportGroupBox = new System.Windows.Forms.GroupBox();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.HoursTextBox = new System.Windows.Forms.TextBox();
            this.WeekLabel = new System.Windows.Forms.Label();
            this.ProjectLabel = new System.Windows.Forms.Label();
            this.WeekComboBox = new System.Windows.Forms.ComboBox();
            this.ProjectComboBox = new System.Windows.Forms.ComboBox();
            this.SubmitReportButton = new System.Windows.Forms.Button();
            this.TimeReportListBox = new System.Windows.Forms.ListBox();
            this.TimeReportLabel = new System.Windows.Forms.Label();
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.EmployeeComboBox = new System.Windows.Forms.ComboBox();
            this.AllBoxesNotFilledErrorLabel = new System.Windows.Forms.Label();
            this.ErrorLabelTimer = new System.Windows.Forms.Timer(this.components);
            this.TimeReportGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimeReportGroupBox
            // 
            this.TimeReportGroupBox.Controls.Add(this.AllBoxesNotFilledErrorLabel);
            this.TimeReportGroupBox.Controls.Add(this.HoursLabel);
            this.TimeReportGroupBox.Controls.Add(this.HoursTextBox);
            this.TimeReportGroupBox.Controls.Add(this.WeekLabel);
            this.TimeReportGroupBox.Controls.Add(this.ProjectLabel);
            this.TimeReportGroupBox.Controls.Add(this.WeekComboBox);
            this.TimeReportGroupBox.Controls.Add(this.ProjectComboBox);
            this.TimeReportGroupBox.Controls.Add(this.SubmitReportButton);
            this.TimeReportGroupBox.Controls.Add(this.TimeReportListBox);
            this.TimeReportGroupBox.Controls.Add(this.TimeReportLabel);
            this.TimeReportGroupBox.Controls.Add(this.EmployeeLabel);
            this.TimeReportGroupBox.Controls.Add(this.EmployeeComboBox);
            this.TimeReportGroupBox.Location = new System.Drawing.Point(12, 12);
            this.TimeReportGroupBox.Name = "TimeReportGroupBox";
            this.TimeReportGroupBox.Size = new System.Drawing.Size(472, 364);
            this.TimeReportGroupBox.TabIndex = 0;
            this.TimeReportGroupBox.TabStop = false;
            this.TimeReportGroupBox.Text = "Timereport";
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(6, 91);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(74, 13);
            this.HoursLabel.TabIndex = 10;
            this.HoursLabel.Text = "Worked hours";
            // 
            // HoursTextBox
            // 
            this.HoursTextBox.Location = new System.Drawing.Point(6, 107);
            this.HoursTextBox.Name = "HoursTextBox";
            this.HoursTextBox.Size = new System.Drawing.Size(100, 20);
            this.HoursTextBox.TabIndex = 9;
            this.HoursTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HourTextBox_KeyPress);
            // 
            // WeekLabel
            // 
            this.WeekLabel.AutoSize = true;
            this.WeekLabel.Location = new System.Drawing.Point(345, 20);
            this.WeekLabel.Name = "WeekLabel";
            this.WeekLabel.Size = new System.Drawing.Size(36, 13);
            this.WeekLabel.TabIndex = 8;
            this.WeekLabel.Text = "Week";
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.AutoSize = true;
            this.ProjectLabel.Location = new System.Drawing.Point(170, 20);
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(40, 13);
            this.ProjectLabel.TabIndex = 7;
            this.ProjectLabel.Text = "Project";
            // 
            // WeekComboBox
            // 
            this.WeekComboBox.FormattingEnabled = true;
            this.WeekComboBox.Location = new System.Drawing.Point(345, 40);
            this.WeekComboBox.Name = "WeekComboBox";
            this.WeekComboBox.Size = new System.Drawing.Size(121, 21);
            this.WeekComboBox.TabIndex = 6;
            // 
            // ProjectComboBox
            // 
            this.ProjectComboBox.FormattingEnabled = true;
            this.ProjectComboBox.Location = new System.Drawing.Point(173, 40);
            this.ProjectComboBox.Name = "ProjectComboBox";
            this.ProjectComboBox.Size = new System.Drawing.Size(121, 21);
            this.ProjectComboBox.TabIndex = 5;
            // 
            // SubmitReportButton
            // 
            this.SubmitReportButton.Location = new System.Drawing.Point(355, 335);
            this.SubmitReportButton.Name = "SubmitReportButton";
            this.SubmitReportButton.Size = new System.Drawing.Size(111, 23);
            this.SubmitReportButton.TabIndex = 4;
            this.SubmitReportButton.Text = "Submit report";
            this.SubmitReportButton.UseVisualStyleBackColor = true;
            this.SubmitReportButton.Click += new System.EventHandler(this.SubmitReportButton_Click);
            // 
            // TimeReportListBox
            // 
            this.TimeReportListBox.FormattingEnabled = true;
            this.TimeReportListBox.Location = new System.Drawing.Point(6, 165);
            this.TimeReportListBox.Name = "TimeReportListBox";
            this.TimeReportListBox.Size = new System.Drawing.Size(460, 147);
            this.TimeReportListBox.TabIndex = 3;
            // 
            // TimeReportLabel
            // 
            this.TimeReportLabel.AutoSize = true;
            this.TimeReportLabel.Location = new System.Drawing.Point(6, 149);
            this.TimeReportLabel.Name = "TimeReportLabel";
            this.TimeReportLabel.Size = new System.Drawing.Size(170, 13);
            this.TimeReportLabel.TabIndex = 2;
            this.TimeReportLabel.Text = "Worked hours for current selection";
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Location = new System.Drawing.Point(17, 24);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(53, 13);
            this.EmployeeLabel.TabIndex = 1;
            this.EmployeeLabel.Text = "Employee";
            // 
            // EmployeeComboBox
            // 
            this.EmployeeComboBox.FormattingEnabled = true;
            this.EmployeeComboBox.Location = new System.Drawing.Point(6, 40);
            this.EmployeeComboBox.Name = "EmployeeComboBox";
            this.EmployeeComboBox.Size = new System.Drawing.Size(121, 21);
            this.EmployeeComboBox.TabIndex = 0;
            this.EmployeeComboBox.SelectedIndexChanged += new System.EventHandler(this.EmployeeComboBox_SelectedIndexChanged);
            // 
            // AllBoxesNotFilledErrorLabel
            // 
            this.AllBoxesNotFilledErrorLabel.AutoSize = true;
            this.AllBoxesNotFilledErrorLabel.Location = new System.Drawing.Point(265, 149);
            this.AllBoxesNotFilledErrorLabel.Name = "AllBoxesNotFilledErrorLabel";
            this.AllBoxesNotFilledErrorLabel.Size = new System.Drawing.Size(201, 13);
            this.AllBoxesNotFilledErrorLabel.TabIndex = 11;
            this.AllBoxesNotFilledErrorLabel.Text = "All boxes must be filled to add time report!";
            // 
            // ErrorLabelTimer
            // 
            this.ErrorLabelTimer.Interval = 3000;
            this.ErrorLabelTimer.Tick += new System.EventHandler(this.ErrorLabelTimer_Tick);
            // 
            // TimeReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 388);
            this.Controls.Add(this.TimeReportGroupBox);
            this.Name = "TimeReportForm";
            this.Text = "Time Reporter";
            this.TimeReportGroupBox.ResumeLayout(false);
            this.TimeReportGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TimeReportGroupBox;
        private System.Windows.Forms.ListBox TimeReportListBox;
        private System.Windows.Forms.Label TimeReportLabel;
        private System.Windows.Forms.Label EmployeeLabel;
        private System.Windows.Forms.ComboBox EmployeeComboBox;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.TextBox HoursTextBox;
        private System.Windows.Forms.Label WeekLabel;
        private System.Windows.Forms.Label ProjectLabel;
        private System.Windows.Forms.ComboBox WeekComboBox;
        private System.Windows.Forms.ComboBox ProjectComboBox;
        private System.Windows.Forms.Button SubmitReportButton;
        private System.Windows.Forms.Label AllBoxesNotFilledErrorLabel;
        private System.Windows.Forms.Timer ErrorLabelTimer;
    }
}

