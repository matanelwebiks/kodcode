using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Employees
{
    public partial class frmEmployees : Form
    {

        Employee[] employees;
        public frmEmployees()
        {
            InitializeComponent();
            dtpDateOfBirth.Value = DateTime.Now.AddYears(-25);
            if (employees == null)
            {
                txtCode.Text = "1";

            }
            else
                txtCode.Text = (employees[employees.Length-1].Code+1).ToString();
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
        }
        private void ClearFields(Control control)
        {
            foreach (Control ctr in control.Controls)
            {
                if (ctr is TextBox) ctr.Text = "";
                else if (ctr is DateTimePicker)
                    ((DateTimePicker)ctr).Value = DateTime.Now.AddYears(-25);
                else if (ctr is RadioButton) ((RadioButton) ctr).Checked = false;
                else if (ctr is Panel)
                    ClearFields(ctr);


            }
        }
        private string status
        {

            get {
            foreach(Control ctr in pStatus.Controls)
                {
                    if(ctr is RadioButton)
                        if(((RadioButton)ctr).Checked)
                            return ctr.Text;
                }
                return "";
            }
                set{
                foreach (Control ctr in pStatus.Controls)
                {
                    if (ctr is RadioButton && ctr.Text == value)
                        ((RadioButton)ctr).Checked = true;
                }
            }
        }
        private void btAddWorker_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(int.Parse(txtCode.Text),
                txtID.Text,
                txtFirstName.Text,
                txtLastName.Text,
                dtpDateOfBirth.Value,
                rdbMale.Checked,
                status,
                txtCelphone.Text,
                txtCity.Text,

                txtStreet.Text,
                txtNumber.Text);
            
            AddEmployeeToArray(employee);
        }

        private void AddEmployeeToArray(Employee employee)
        {
            if (employees == null)
                employees = new Employee[1];
            else
            {
                Employee[] temp = new Employee[employees.Length + 1];
                for (int i = 0; i < employees.Length; i++)
                {
                    temp[i] = employees[i];
                }
                employees = temp;
            }
            employees[employees.Length - 1] = employee;
        }
        private void ShowEmployye(Employee employee)
        {
            if (employee == null) return;
            txtCode.Text = employee.Code.ToString();
            txtFirstName.Text = employee.FirstName;
            txtLastName.Text = employee.LastName;
            txtID.Text = employee.Id;
            txtCelphone.Text = employee.PhoneNumber;
            txtCity.Text = employee.City;
            txtStreet.Text = employee.Street;
            txtNumber.Text = employee.Number;
            if (employee.IsMale)
                rdbMale.Checked = true;
            else
                rdbFemale.Checked = true;
            status = employee.Status;

        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMale.Checked)
            {
                rdbMarride.Text = "נשוי";
                rdbDivorce.Text="גרוש";
                rdbSingle.Text="רווק";
                rdbWidow.Text = "אלמן";
            }
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFemale.Checked)
            {
                rdbMarride.Text = "נשואה";
                rdbDivorce.Text = "גרושה";
                rdbSingle.Text = "רווקה";
                rdbWidow.Text = "אלמנה";
            }
        }

        private void btNewWorker_Click(object sender, EventArgs e)
        {
            ClearFields(this);
            if (employees == null)
            {
                txtCode.Text = "1";

            }
            else
                txtCode.Text = (employees[employees.Length - 1].Code + 1).ToString();
        }

        private Employee searchEmployeeByCode(int code)
        {
            return employees.FirstOrDefault(e => e.Code == code);
        }

        private Employee searchEmployeeByIndex(int index)
        {
            if(index < 0|| index>employees.Length-1) return null;
            return employees[index];
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Employee employee = searchEmployeeByIndex(int.Parse(txtCode.Text)-2);
           
                ShowEmployye(employee);
        }

        private void btForward_Click(object sender, EventArgs e)
        {
            Employee employee = searchEmployeeByIndex(int.Parse(txtCode.Text));
                ShowEmployye(employee);
        }

        private void btSearchWorkerByCode_Click(object sender, EventArgs e) { 
            string res = Microsoft.VisualBasic.Interaction.InputBox("הכנס קוד עובד");
            int resultCode;
            bool isNumber = int.TryParse(res, out resultCode);
                while (!isNumber)
                {
                    res = Microsoft.VisualBasic.Interaction.InputBox("קוד לא תקין הכנס שוב");
                isNumber = int.TryParse(res, out resultCode);
            }
            ShowEmployye(searchEmployeeByCode(resultCode));

        }
    }
}