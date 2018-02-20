using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the allStaffs list 
        private List<clsStaff> mAllStaffs = new List<clsStaff>();
        //publict property for Count
        public int Count
        {
            get
            {
                //return the count property of the private list 
                return mAllStaffs.Count;
            }
            set
            {
                //
            }
        }

        //public property for allStaffs 
        public List<clsStaff> AllStaffs
        {
            //getter sends data to requesting code 
            get
            {
                //return the private data member
                return mAllStaffs;
            }
           //setter accepts data from other objects 
           set
            {
                //assign the incoming value to the private data member 
                mAllStaffs = value;
            }
        }

        //public constructor for the class 
        public clsStaffCollection()
        {
            //create an istance of the county class to store a staff
            clsStaff AStaff = new clsStaff();
            //set the staff number to .....
            AStaff.StaffNumber = "P1622604";
            //add the staff to the private list of staffs 
            mAllStaffs.Add(AStaff);
            //re initialise the AStaff object to accpet a new item
            AStaff = new clsStaff();
            //set the staff number to ....
            AStaff.StaffNumber = "P1622605";
            //add the second staff to the private list of stasffs
            mAllStaffs.Add(AStaff);
            //the private list now contains two staff numbers
        }

    }
}