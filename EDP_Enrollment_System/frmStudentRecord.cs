using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDP_Enrollment_System
{
    public partial class frmStudentRecord : Form
    {
        //variable path
        string path;
        public frmStudentRecord()
        {
            InitializeComponent();
        }

        //Register button
        private void btnRegister_Click(object sender, EventArgs e)
        {
            //object for frmRegistration
            frmRegistration backToRegis = new frmRegistration();
            //hides this form
            this.Hide();
            //opens the frmRegistration
            backToRegis.ShowDialog();
        }

        //Find button
        private void btnFind_Click(object sender, EventArgs e)
        {
            //clears the list view
            lvViewRecord.Items.Clear();
            //Displays the text to the listview
            DisplayToList();


        }
        //method for display
        public void DisplayToList()
        {
            //Path
            openFileDialog1.InitialDirectory = @"C:\";
            //Title
            openFileDialog1.Title = "Browse Text Files";
            //file type/s
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //Opens the Directory
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            //Stream reader
            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    lvViewRecord.Items.Add(_getText);

                }

            }
        }

        //clears the listview and releases a successfull message
        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (lvViewRecord.Items.Count > 0)
            {
                lvViewRecord.Items.Clear();
                MessageBox.Show("Successfully Uploaded!");
            }
            else { MessageBox.Show("Invalid"); }
            
        }
    }
}
