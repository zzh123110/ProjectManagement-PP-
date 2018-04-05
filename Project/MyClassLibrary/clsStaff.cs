using System;

namespace MyClassLibrary
{
    public class clsStaff
    {
        //private data member for the Staffnumber property 
        private Int32 mStaffID;     
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
        
        public bool Search(int StaffID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address on to search for 
            DB.AddParameter("@StaffID", StaffID);
            //excute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffNumber = Convert.ToString(DB.DataTable.Rows[0]["StaffNumber"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mGender = Convert.ToString(DB.DataTable.Rows[0]["Gender"]);
                mPosition = Convert.ToString(DB.DataTable.Rows[0]["Position"]);
                mAttendence = Convert.ToDouble(DB.DataTable.Rows[0]["Attendence"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
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
        //public property for the staff ID 
        public int StaffID
        {
            get
            {
                //return the private data 
                return mStaffID;
            }
            set
            {
                //set the value of the private data member 
                mStaffID = value;
            }
        }

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

        //Valid method
        public string Valid(string staffNumber, string firstName, string lastName, string gender, string position, string password, double attendence, string address, string phoneNumber)
        {
            //create a string variable to store the error 
            String Error = "";
            //if the Staff Number is blank
            if (staffNumber.Length == 0)
            {
                //record the error 
                Error = Error + "The StaffNumber may not be blank : ";
            }
            //if the length of the StaffNumber is less than 8
            if (staffNumber.Length < 8)
            {
                Error = Error + "The StaffNumber must be great than 8: ";
            }
            //if the length of the StaffNumber is great than 12
            if (staffNumber.Length > 12)
            {
                Error = Error + "The StaffNumber must be less than 12: ";
            }

            //if the First Name is blank
            if (firstName.Length == 0)
            {
                //record the error 
                Error = Error + "The firstName may not be blank : ";
            }
            //if the length of the firstName is great than 50
            if (firstName.Length > 50)
            {
                Error = Error + "The firstName must be less than 51: ";
            }

            //if the Last Name is blank
            if (lastName.Length == 0)
            {
                //record the error 
                Error = Error + "The lastName may not be blank : ";
            }
            //if the length of the lastName is less than 50
            if (lastName.Length > 50)
            {
                Error = Error + "The lastName must be less than 51: ";
            }

            //if the Gender is blank
            if (gender.Length == 0)
            {
                //record the error 
                Error = Error + "The gender may not be blank : ";
            }
            //if the length of the gender is less than 4
            if (gender.Length < 4)
            {
                Error = Error + "The gender must be great than 3: ";
            }
            //if the length of the gender is great than 10
            if (gender.Length > 10)
            {
                Error = Error + "The gender must be less than 11: ";
            }

            //if the Position is blank
            if (position.Length == 0)
            {
                //record the error 
                Error = Error + "The postion may not be blank : ";
            }
            //if the length of the postion is great than 50
            if (position.Length > 50)
            {
                Error = Error + "The positon must be less than 51: ";
            }

            //if the Password is blank
            if (password.Length == 0)
            {
                //record the error 
                Error = Error + "The gender no may not be blank : ";
            }
            //if the length of the password is less than 6
            if (password.Length < 6)
            {
                Error = Error + "The gender must be great than 5: ";
            }
            //if the length of the password is great than 12
            if (password.Length > 12)
            {
                Error = Error + "The gender must be less than 13 ";
            }

            //if the Attendence is less than 0
            if (attendence < 0)
            {
                //record the error 
                Error = Error + "The attendence must great than 0 : ";
            }
            //if  the attendence is great than 100
            if (attendence > 100)
            {
                Error = Error + "The positon must be less than 101: ";
            }

            //if the Address is blank
            if (address.Length == 0)
            {
                //record the error 
                Error = Error + "The address no may not be blank : ";
            }
            //if the length of the address is great than 100
            if (address.Length > 100)
            {
                Error = Error + "The address must be less than 101: ";
            }

            //if the PhoneNumber is blank
            if (phoneNumber.Length == 0)
            {
                //record the error 
                Error = Error + "The PhoneNumber no may not be blank : ";
            }
            //if the length of the phonenubmer is less than 5
            if (phoneNumber.Length < 5)
            {
                Error = Error + "The PhoneNumber must be great than 4: ";
            }
            //if the length of the phonenubmer is great than 11
            if (phoneNumber.Length > 11)
            {
                Error = Error + "The PhoneNumber must be less than 12: ";
            }

            return Error;
        }
        //end of the valid

    }
}