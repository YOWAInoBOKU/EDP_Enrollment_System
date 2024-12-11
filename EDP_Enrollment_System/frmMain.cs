using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace EDP_Enrollment_System
{
    public partial class frmMain : Form
    {
        frmRegistration f = new frmRegistration() { TopLevel = false, TopMost = true };
        frmRegistration2 f2 = new frmRegistration2() { TopLevel = false, TopMost = true };

       // ValidatorClass valid = new ValidatorClass();
        

        static long currentStudentNo;
        public static long NewStudentNo;

        public frmMain()
        {
            InitializeComponent();
            //retrieves the Student Number and adds 1
            GetStudentNo();

            //transfers teh amount from currentStudentNo to NewStudentNo
            NewStudentNo = currentStudentNo;
            //Displays the new Student Number
            CurrentStudentNo.Text = NewStudentNo.ToString("D11");

            //Panel Commands
            f.FormBorderStyle = FormBorderStyle.None;
            MainPanel.Controls.Add(f);
            f.Show();

        }

        public static void GetStudentNo()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Enrollees");
            var collection = database.GetCollection<BsonDocument>("Students");

            // Sort by student number in descending order and limit to one document
            var filter = Builders<BsonDocument>.Filter.Empty;
            var sort = Builders<BsonDocument>.Sort.Descending("StudentInfo.Student_Number");
            var lastStudent = collection.Find(filter).Sort(sort).Limit(1).FirstOrDefault();

            if (lastStudent != null && lastStudent["StudentInfo"].AsBsonDocument.Contains("Student_Number"))
            {
                // Convert the student number from string to long
                currentStudentNo = long.Parse(lastStudent["StudentInfo"]["Student_Number"].AsString) + 1;
            }
            else
            { currentStudentNo = 1; } // Start from 1 if no student numbers are found
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
          
                f2.FormBorderStyle = FormBorderStyle.None;
                MainPanel.Controls.Add(f2);
                f.Hide();
                f2.Show();

        }

        private void Previous_Click(object sender, EventArgs e)
        {
            f2.Hide();
            f.Show();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            try
            {

                var studentInfo = f.GetStudentInfo();
                var parentInfo = f2.GetParentInfo();

                if (studentInfo == null && parentInfo == null)
                {
                    return;
                }

                    var combinedInfo = new BsonDocument
                    {
                        {"StudentInfo", studentInfo},
                        {"ParentInfo", parentInfo}
                    };

                    var client = new MongoClient("mongodb://localhost:27017");
                    var database = client.GetDatabase("Enrollees");
                    var collection = database.GetCollection<BsonDocument>("Students");
                    // Clear fields after successful registration

                    collection.InsertOne(combinedInfo);
                    //f.ClearFields();
                    f2.ClearFields();

                    MessageBox.Show("Information registered and fields cleared successfully.");

                    ResetForm();

                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ResetForm()
        {
            //frmFinish finish = new frmFinish();
            //finish.Show();
            Thread.Sleep(5000);
            // Clear all controls
            this.Controls.Clear();
            // Reinitialize the form controls
            InitializeComponent();

            //retrieves the Student Number and adds 1
            GetStudentNo();

            //transfers teh amount from currentStudentNo to NewStudentNo
            NewStudentNo = currentStudentNo;
            //Displays the new Student Number
            CurrentStudentNo.Text = NewStudentNo.ToString("D11");

            // Re-add the registration forms to the panel
            f = new frmRegistration() { TopLevel = false, TopMost = true };
            f2 = new frmRegistration2() { TopLevel = false, TopMost = true };
            f.FormBorderStyle = FormBorderStyle.None; MainPanel.Controls.Add(f);
            f.Show();

        }
    }
}


