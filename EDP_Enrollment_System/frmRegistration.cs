using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic;
using MongoDB.Bson;
using MongoDB.Driver;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EDP_Enrollment_System
{

    public partial class frmRegistration : Form
    {
        frmStudentRecord studentRecord = new frmStudentRecord();
        ValidationClass validate = new ValidationClass();

        public string _FullName;

        public frmRegistration()
        {
            InitializeComponent();
        }

        public bool ValidateRegistration()
        {

            if (

            string.IsNullOrEmpty(txtLastName.Text) ||
            string.IsNullOrEmpty(txtFirstName.Text) ||

            string.IsNullOrEmpty(txtMiddle.Text) ||
            string.IsNullOrEmpty(txtNationality.Text) ||
            string.IsNullOrEmpty(txtContactNo.Text) ||
            string.IsNullOrEmpty(txtAge.Text) ||
            string.IsNullOrEmpty(txtEmail.Text) ||
            string.IsNullOrEmpty(txtPAddress.Text) ||
            string.IsNullOrEmpty(txtSchoolName.Text) ||
            string.IsNullOrEmpty(txtSchoolID.Text) ||
            string.IsNullOrEmpty(txtCompletedLevel.Text) ||

            cbPrograms.SelectedIndex == -1 ||
            cbGender.SelectedIndex == -1 ||
            cbCities.SelectedIndex == -1 ||
            cbProvinces.SelectedIndex == -1
                )
            {
                MessageBox.Show("Please fill in all required fields.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }

            return true;
        }

        public bool RegisterInfo()
        {

            // Validate and set student information
            if (!validate.ValidateFullName(txtLastName.Text, txtFirstName.Text, txtMiddle.Text + "."))
            {
                return false;
            }
            if (!validate.ValidateAge(txtAge.Text))
            {
                return false;
            }
            if (!validate.ValidateContactNo(txtContactNo.Text))
            {
                return false;
            }
            return true;
        }

        public BsonDocument GetStudentInfo()
        {
            if (ValidateRegistration())
            {
                if (!RegisterInfo())
                {
                    return null;
                }
            }
                var studentinfo = new BsonDocument()
                {

                {"Student_Number", frmMain.NewStudentNo.ToString("D11")},
                {"Program", cbPrograms.Text},
                {"FullName", validate.FullName},
                {"Gender", cbGender.Text},
                {"Age", validate.Age},
                {"BirthDate", datePickerBirthday.Value.ToString("yyyy-MM-dd")},
                {"Nationality", txtNationality.Text},
                {"Contacts", new BsonDocument

                    {
                         {"ContactNo", validate.ContactNo },
                         {"Email", txtEmail.Text}
                    }
                },
                {"Address", txtPAddress.Text},
                {"City", cbCities.Text},
                {"Province", cbProvinces.Text},
                {"School", txtSchoolName.Text},
                {"CompletedLevel", Convert.ToInt32(txtCompletedLevel.Text)}

                };

                return studentinfo;


        }
            


        private void frmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]
            {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };
            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }

            // List of genders to populate the combo box
            string[] ListOfGender = new string[]
            {
            "Male",
            "Female"
            };
            for (int i = 0; i < 2; i++)
            {
                cbGender.Items.Add(ListOfGender[i].ToString());
            }


            string[] CityList = new string[]
            {
                "Metro Manila", "Quezon City", "Makati", "Cebu City",
                "Davao City", "Baguio", "Iloilo City", "Bacolod",
                "Cagayan de Oro", "Zamboanga City", "Taguig", "Pasig",
                "Mandaluyong", "Marikina", "Caloocan", "Las Piñas",
                "Muntinlupa", "Parañaque", "San Juan","Tarlac City", "Valenzuela"
            };
            for (int i = 0; i < CityList.Length; i++)
            {
                cbCities.Items.Add(CityList[i].ToString());
            }
            string[] Provinces = new string[]
            {
              
                    "Abra", "Agusan del Norte", "Agusan del Sur", "Aklan", "Albay", "Antique",
                    "Apayao", "Aurora", "Basilan", "Bataan", "Batanes", "Batangas", "Benguet",
                    "Biliran", "Bohol", "Bukidnon", "Bulacan", "Cagayan", "Camarines Norte",
                    "Camarines Sur", "Camiguin", "Capiz", "Catanduanes", "Cavite", "Cebu",
                    "Cotabato", "Davao de Oro", "Davao del Norte", "Davao del Sur", "Davao Occidental",
                    "Davao Oriental", "Dinagat Islands", "Eastern Samar", "Guimaras", "Ifugao",
                    "Ilocos Norte", "Ilocos Sur", "Iloilo", "Isabela", "Kalinga", "La Union", "Laguna",
                    "Lanao del Norte", "Lanao del Sur", "Leyte", "Maguindanao", "Marinduque", "Masbate",
                    "Misamis Occidental", "Misamis Oriental", "Mountain Province", "Negros Occidental",
                    "Negros Oriental", "Northern Samar", "Nueva Ecija", "Nueva Vizcaya", "Occidental Mindoro",
                    "Oriental Mindoro", "Palawan", "Pampanga", "Pangasinan", "Quezon", "Quirino", "Rizal",
                    "Romblon", "Samar", "Sarangani", "Siquijor", "Sorsogon", "South Cotabato", "Southern Leyte",
                    "Sultan Kudarat", "Sulu", "Surigao del Norte", "Surigao del Sur", "Tarlac", "Tawi-Tawi", 
                    "Zambales", "Zamboanga del Norte", "Zamboanga del Sur", "Zamboanga Sibugay" 
            };
            for (int i = 0; Provinces.Length > i; i++)
            {
                cbProvinces.Items.Add(Provinces[i].ToString());
            }
        }
      
        private void btnToRegister_Click_1(object sender, EventArgs e)
        {
            frmRegistration2 r2 = new frmRegistration2();
            this.Hide();
            r2.ShowDialog();
        }

        public void ClearFields()
        {
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddle.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
            txtAge.Clear();
            txtNationality.Clear();
            cbPrograms.SelectedIndex = -1;
            cbGender.SelectedIndex = -1;
            datePickerBirthday.Value = DateTime.Now;

            txtPAddress.Clear();
            cbCities.SelectedIndex = -1;
            cbProvinces.SelectedIndex = -1;
            txtSchoolName.Clear();
            txtSchoolID.Clear();
            txtCompletedLevel.Clear();
        }
    }
    

}
