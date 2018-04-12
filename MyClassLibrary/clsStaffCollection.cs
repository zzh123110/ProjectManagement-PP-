using System;
using System.Collections.Generic;

namespace Class_Library
{
    public class clsStaffCollection
    {
        //private data member fot the list 
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member  thisStaff
        clsStaff mThisStaff = new clsStaff();

        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data 
                mStaffList = value;
            }
        }

        //public proeprty for count
        public int Count
        {
            get
            {
                //return the count ofthe list 
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about later 
            }
        }

        //public property for ThisAddress
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the priavate data
                mThisStaff = value;
            }
        }

        //constructor for the class 
        public clsStaffCollection()
        {

            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);

        }

        

        //add method
        public int Add()
        {
            //add a new record to the database based on the values of mThisStaff
            //connnect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the sotred procudrue 
            DB.AddParameter("@StaffNumber", mThisStaff.StaffNumber);
            DB.AddParameter("@FirstName ", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@Gender", mThisStaff.Gender);
            DB.AddParameter("@PhoneNumber", mThisStaff.PhoneNumber);
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("@Position ", mThisStaff.Position);
            DB.AddParameter("@Attendence", mThisStaff.Attendence);
            DB.AddParameter("@Password ", mThisStaff.Password);
            //execute the query retuning the primary key value 
            return DB.Execute("sproc_tblStaff_Insert");
        }
        //update method 
        public void Update()
        {
            //update an existing record to the database based on the values of mThisStaff
            //connnect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the sotred procudrue
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@StaffNumber", mThisStaff.StaffNumber);
            DB.AddParameter("@FirstName ", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@Gender", mThisStaff.Gender);
            DB.AddParameter("@PhoneNumber", mThisStaff.PhoneNumber);
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("@Position ", mThisStaff.Position);
            DB.AddParameter("@Attendence", mThisStaff.Attendence);
            DB.AddParameter("@Password ", mThisStaff.Password);
            //execute the query retuning the primary key value 
            DB.Execute("sproc_tblStaff_Update");
        }

        public void FilterByStaffNo(string StaffNumber)
        {
            //filters the records based on a full or partial post code
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the staffno parameter to the database 
            DB.AddParameter("@StaffNumber", StaffNumber);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffNo");
            //poupulate the array list withe the data table 
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {

            //var for the index 
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to precess
            while (Index < RecordCount)
            {
                //create a blank address 
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record 
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.StaffNumber = Convert.ToString(DB.DataTable.Rows[Index]["StaffNumber"]);
                AStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AStaff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AStaff.Gender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);
                AStaff.Position = Convert.ToString(DB.DataTable.Rows[Index]["Position"]);
                AStaff.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                AStaff.Attendence = Convert.ToInt32(DB.DataTable.Rows[Index]["Attendence"]);
                AStaff.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AStaff.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                //add the record to the private data muber 
                mStaffList.Add(AStaff);
                //point at the next record 
                Index++;
            }
        }

    }
}
