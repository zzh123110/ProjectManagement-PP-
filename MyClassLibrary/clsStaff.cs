using System;

namespace MyClassLibrary
{
    public class clsStaff
    {
        //private data member for the Staffnumber property      
        private string mStaffNumber;
        private string mFirstName;
        private string mLastName;
        private string mGender;
        private string mPosition;
        private string mPassword;
        private double mAttendence;
        private string mAddress;
        private string mPhoneNumber;
        



        public bool StaffNumberValid(string tstStaffNumber)
        {
            // boolean flag to indicate that all is ok
            Boolean OK = true;
            //if the length of the StaffNumber is less than 8
            if (tstStaffNumber.Length < 8)
            {
                OK = false;
            }
            //if the length of the StaffNumber is great than 12
            if (tstStaffNumber.Length > 12)
            {
                OK = false;
            }
            return OK;
        }

        public bool Search(string staffNumber)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address on to search for 
            DB.AddParameter("@StaffNumber", StaffNumber);
            //excute the stored procedure
            DB.Excute("sproc_tblStaff_FilterByStaffNumber");
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffNumber = Convert.ToString(DB.DataTable.Rows[0]["StaffNumber"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mGender = Convert.ToString(DB.DataTable.Rows[0]["Gender"]);
                mPosition = Convert.ToString(DB.DataTable.Rows[0]["Position"]);
                mAttendence = Convert.ToDouble(DB.DataTable.Rows[0]["Attendence"]);
                mAddress = Convert.ToDouble(DB.DataTable.Rows[0]["Address"]);
                //return that everthing worked OK
                return true;
            }
            //if no record was foud 
            else
            {
                //returnfalse indicating a problem 
                return false;
            }
            
        }

       //get and set all properties
       //public property for the staff number 
       public string StaffNumber
        {
            get
            {
                //return the private data 
                return mStaffNumber;
            }
            set
            {
                //set the value of the private data member 
                mStaffNumber = value;
            }
        }

        //public propert for the First Name 
        public string FirstName
        {
            get
            {
                //return the private data 
                return mFirstName;
            }
            set
            {
                //set the value of the private data member 
                mFirstName = value;
            }
        }

        //public propert for the Last Name 
        public string LastName
        {
            get
            {
                //return the private data 
                return mLastName;
            }
            set
            {
                //set the value of the private data member 
                mLastName = value;
            }
        }

        //public propert for the Gender
        public string Gender
        {
            get
            {
                //return the private data 
                return mGender;
            }
            set
            {
                //set the value of the private data member 
                mGender = value;
            }
        }
        
        //public propert for the Position
        public string Position
        {
            get
            {
                //return the private data 
                return mPosition;
            }
            set
            {
                //set the value of the private data member 
                mPosition = value;
            }
        }

        //public propert for the Password
        public string Password
        {
            get
            {
                //return the private data 
                return mPassword;
            }
            set
            {
                //set the value of the private data member 
                mPassword = value;
            }
        }

        //public propert for the Attendence 
        public double Attendence
        {
            get
            {
                //return the private data 
                return mAttendence;
            }
            set
            {
                //set the value of the private data member 
                mAttendence = value;
            }
        }

        //public propert for the Address
        public string Address
        {
            get
            {
                //return the private data 
                return mAddress;
            }
            set
            {
                //set the value of the private data member 
                mAddress = value;
            }
        }

        //public propert for the PhoneNumber
        public string PhoneNumber
        {
            get
            {
                //return the private data 
                return mPhoneNumber;
            }
            set
            {
                //set the value of the private data member 
                mPhoneNumber = value;
            }
        }
        //end of get and set

    }
}