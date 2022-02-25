using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeReport_Lab
{
    public partial class TimeReportForm : Form
    {
        public TimeReportForm()
        {
            InitializeComponent();

            DataBaseStuffAndSuch d = new DataBaseStuffAndSuch();
            HoursTextBox.Text = "";
            AllBoxesNotFilledErrorLabel.Visible = false;

            EmployeeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ProjectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            WeekComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            List<string> EmployeeList = d.GetAllEmployees();
            foreach(string item in EmployeeList)
            {
                EmployeeComboBox.Items.Add(item);
            }

            List<string> ProjectList = d.GetAllProjects();
            foreach (string item in ProjectList)
            {
                ProjectComboBox.Items.Add(item);
            }

            List<string> WeekList = AddWeeks();
            foreach (string item in WeekList)
            {
                WeekComboBox.Items.Add(item);
            }
        }

        //shows all items in listbox about employee
        public void ShowItems()
        {
            DataBaseStuffAndSuch dbsas = new DataBaseStuffAndSuch();
            int Index = EmployeeComboBox.SelectedIndex;

            List<string> infoList = new List<string>();
            infoList = dbsas.GetEmployeeInfo(Index);

            TimeReportListBox.Items.Clear();

            foreach (var item in infoList)
            {
                TimeReportListBox.Items.Add(item);
            }
        }

        private void EmployeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowItems();
        }

        //event for button adding time reports
        private void SubmitReportButton_Click(object sender, EventArgs e)
        {
            if(EmployeeComboBox.SelectedItem == null || ProjectComboBox.SelectedItem == null || WeekComboBox.SelectedItem == null || string.IsNullOrEmpty(HoursTextBox.Text))
            {
                AllBoxesNotFilledErrorLabel.Visible = true;
                ErrorLabelTimer.Start();
            }
            else
            {
                DataBaseStuffAndSuch.AddTimeReport(ProjectComboBox.SelectedIndex + 1, EmployeeComboBox.SelectedIndex + 1, Convert.ToInt32(WeekComboBox.SelectedItem), Convert.ToInt32(HoursTextBox.Text));

                TimeReportListBox.Items.Clear();
                ShowItems();
            }
        }

        private void HourTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //returns list containing 52 strings for each week
        private List<string> AddWeeks()
        {
            List<string> weeks = new List<string>();

            for(int i = 1; i < 53; i++)
            {
                weeks.Add($"{i}");
            }

            return weeks;
        }

        //errortimer tick, makes it so error messages shows for three seconds
        private void ErrorLabelTimer_Tick(object sender, EventArgs e)
        {
            AllBoxesNotFilledErrorLabel.Visible = false;
            ErrorLabelTimer.Stop();
        }
    }
}
