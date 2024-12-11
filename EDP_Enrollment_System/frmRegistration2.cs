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
using MongoDB.Bson;
using MongoDB.Driver;

namespace EDP_Enrollment_System
{
    public partial class frmRegistration2 : Form
    {
        frmRegistration fr1 = new frmRegistration();
        ValidationClass validate = new ValidationClass();



        public frmRegistration2()
        {
            InitializeComponent();
        }

        public bool ValidateParentInfo()
        {
            if (
               txtFLastName == null || txtFFirstName == null || txtFMiddleName == null ||
               txtMLastName == null || txtMFirstName == null || txtMMiddleName == null
              )
            {
                MessageBox.Show("Please fill in all required fields.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Stop execution
                return false;
            }
            return true;
        }

        public bool ParentInfo()
        {
           
            // Validate and set student information
            if (!validate.ValidateFatherName(txtFLastName.Text, txtFFirstName.Text, txtFMiddleName.Text + "."))
            {
                MessageBox.Show("Invalid FatherName");
                return false;
            }


            if (!validate.ValidateContactNo(txtFContactNo.Text))
            {
                MessageBox.Show("Invalid Contact of Father");
                return false;
            }

            if (!validate.ValidateMotherName(txtMLastName.Text, txtMFirstName.Text, txtMMiddleName.Text + "."))
            {
                MessageBox.Show("Invalid MotherName");
                return false;
            }


            if (!validate.ValidateContactNo(txtMContactNo.Text))
            {
                MessageBox.Show("Invalid Contact of Mother");
                return false;
            }

            return true;
        }

        public BsonDocument GetParentInfo()
        {
            if (ValidateParentInfo())
            {
                if (!ParentInfo()) { return null; }
            } 
            var parentInfo = new BsonDocument {

            {"Father_Info", new BsonDocument
                {
                    { "FatherFullName", validate.FatherName },
                    { "FatherContactNo", validate.ContactNo },
                    { "FatherEmail", txtFEmail.Text },
                    { "FatherAddress", txtFAddress.Text },
                 }
            },
            {"Mother_Info", new BsonDocument
                { 
                    { "MotherFullName", validate.MotherName },
                    { "MotherContactNo", validate.ContactNo },
                    { "MotherEmail", txtMEmail.Text },
                    { "MotherAddress", txtMAddress.Text } 
                } 
            }

        };
            return parentInfo;

        }
        public void ClearFields()
        {
            //Father ClearFields
            txtFLastName.Clear();
            txtFFirstName.Clear();
            txtFMiddleName.Clear();
            txtFContactNo.Clear();
            txtFEmail.Clear();
            txtFAddress.Clear();

            //Mother ClearFields
            txtMLastName.Clear();
            txtMFirstName.Clear();
            txtMMiddleName.Clear();
            txtMContactNo.Clear();
            txtMEmail.Clear();
            txtMAddress.Clear();
        }
    }
}

