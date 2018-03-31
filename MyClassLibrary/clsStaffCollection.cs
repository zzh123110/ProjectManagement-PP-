using System;
using System.Collections.Generic;

namespace MyClassLibrary
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
            return DB.Execute("sprpc_tblStaff_Insert");
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
            DB.Execute("sprpc_tblStaff_Update");
        }
    }
}