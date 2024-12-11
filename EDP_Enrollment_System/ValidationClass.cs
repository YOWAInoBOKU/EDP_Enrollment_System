using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EDP_Enrollment_System
{
    public class ValidationClass
    {
        //Private fields to store user information
        private long _StudentNo;
        private string _FullName;
        private string _Nationality;
        private int _Age;

        private long _ContactNo;
        private string _Email;

        private string _Address;
        private string _City;
        private string _Province;

        private string _SchoolName;
        private long _SchoolID;
        private int _CompletedLevel;

        private string _FatherName;
        private string _MotherName;

        public string FullName => _FullName;
        public string FatherName => _FatherName;
        public string MotherName => _MotherName;
        public int Age => _Age;
        public long ContactNo => _ContactNo;


        //Method to set and return the contact number
        public bool ValidateContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
                return true;
            }
            
            return false;
        }

        //Method to set and return the full name
        public bool ValidateFullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") 
                || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") 
                || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
                return true;
            }
            
            return false;
        }

        //Method to set and return the Father Name
        public bool ValidateFatherName(string fLastName, string fFirstName, string fMiddleInitial)
        {
            if (Regex.IsMatch(fLastName, @"^[a-zA-Z]+$")
                || Regex.IsMatch(fFirstName, @"^[a-zA-Z]+$")
                || Regex.IsMatch(fMiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FatherName = fLastName + ", " + fFirstName + ", " + fMiddleInitial;
                return true;
            }

            return false;
        }

        //Method to set and return the Mother Name
        public bool ValidateMotherName(string mLastName, string mFirstName, string mMiddleInitial)
        {
            if (Regex.IsMatch(mLastName, @"^[a-zA-Z]+$")
                || Regex.IsMatch(mFirstName, @"^[a-zA-Z]+$")
                || Regex.IsMatch(mMiddleInitial, @"^[a-zA-Z]+$"))
            {
                _MotherName = mLastName + ", " + mFirstName + ", " + mMiddleInitial;
                return true;
            }

            return false;
        }

        // Method to set and return the age
        public bool ValidateAge(string age)
        {

            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
                return true;
            }
            return false;
        }

       
    }
}
