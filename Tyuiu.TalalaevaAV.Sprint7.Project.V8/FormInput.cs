using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TalalaevaAV.Sprint7.Project.V8.Lib;
namespace Tyuiu.TalalaevaAV.Sprint7.Project.V8
{
    public partial class FormInput : Form
    {
        public Driver Driver { get; private set; }

        public FormInput(Driver driver = null)
        {
            InitializeComponent();
            Driver = driver ?? new Driver();

            if (driver != null)
            {
                textBoxTabNumber_TAV.Text = driver.TabNumber;
                textBoxLastName_TAV.Text = driver.LastName;
                textBoxFirstName_TAV.Text = driver.FirstName;
                textBoxMiddleName_TAV.Text = driver.MiddleName;
                dateTimePickerBirthDate_TAV.Value = driver.BirthDate;
                textBoxExperience_TAV.Text = driver.Experience.ToString();
                textBoxSalary_TAV.Text = driver.Salary.ToString();
            }
        }

        private void buttonSave_PII_Click(object sender, EventArgs e)
        {
            Driver.TabNumber = textBoxTabNumber_TAV.Text;
            Driver.LastName = textBoxLastName_TAV.Text;
            Driver.FirstName = textBoxFirstName_TAV.Text;
            Driver.MiddleName = textBoxMiddleName_TAV.Text;
            Driver.BirthDate = dateTimePickerBirthDate_TAV.Value;
            Driver.Experience = int.Parse(textBoxExperience_TAV.Text);
            Driver.Salary = decimal.Parse(textBoxSalary_TAV.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_TAV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_TAV_Click(object sender, EventArgs e)
        {
            Driver.TabNumber = textBoxTabNumber_TAV.Text;
            Driver.LastName = textBoxLastName_TAV.Text;
            Driver.FirstName = textBoxFirstName_TAV.Text;
            Driver.MiddleName = textBoxMiddleName_TAV.Text;
            Driver.BirthDate = dateTimePickerBirthDate_TAV.Value;
            Driver.Experience = int.Parse(textBoxExperience_TAV.Text);
            Driver.Salary = decimal.Parse(textBoxSalary_TAV.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

