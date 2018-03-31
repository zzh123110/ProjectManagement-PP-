using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

namespace MyTest
{
    [TestClass]
    public class tstStaffCollection
    {
        //instance 
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //test to see that it exsits 
            Assert.IsNotNull(AllStaffs);
        }


        //compex coolection class 
        [TestMethod]
        public void StaffsListOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data ti assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsStaff> TestList = new List<clsStaff>();
            //addd an item to the list 
            //create the item of test data 
            clsStaff TestItem = new clsStaff();
            //set its prperties 
            TestItem.StaffNumber = "P1622604";
            TestItem.FirstName = "Zihao";
            TestItem.LastName = "Zhang";
            TestItem.Gender = "Male";
            TestItem.Position = "Cleaner";
            TestItem.Password = "asdfgasdfgh";
            TestItem.Attendence = 98.6;
            TestItem.Address = "Leicester";
            TestItem.PhoneNumber = "+12345678";
            //add the item to the test lift 
            TestList.Add(TestItem);
            //assign the data to the property 
            AllStaffs.StaffList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaffs.StaffList, TestList);
        }
      /*  [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data ti assign to the property 
            List<clsStaff> TestStaff = new List<clsStaff>();
            //set its prperties 
            TestStaff.StaffNumber = "P1622604";
            TestStaff.FirstName = "Zihao";
            TestStaff.LastName = "Zhang";
            TestStaff.Gender = "Male";
            TestStaff.Position = "Cleaner";
            TestStaff.Password = "asdfgasdfgh";
            TestStaff.Attendence = 98.6;
            TestStaff.Address = "Leicester";
            TestStaff.PhoneNumber = "+12345678";
            //assign the data to the property 
            AllStaffs.ThisStaff = TestStaff;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaffs.ThisStaff, TestStaff);
        }*/
        // Add method
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of test data 
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its prperties 
            TestItem.StaffNumber = "P1622604";
            TestItem.FirstName = "Zihao";
            TestItem.LastName = "Zhang";
            TestItem.Gender = "Male";
            TestItem.Position = "Cleaner";
            TestItem.Password = "asdfgasdfgh";
            TestItem.Attendence = 98.6;
            TestItem.Address = "Leicester";
            TestItem.PhoneNumber = "+12345678";
            //set ThisStaff  to the test data 
            AllStaffs.ThisStaff = TestItem;
            //add the record 
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data 
            TestItem.StaffID = PrimaryKey;
            //find the record 
            AllStaffs.ThisStaff.Search(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);
        }
        //Update method
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of test data 
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its prperties 
            TestItem.StaffNumber = "P1622604";
            TestItem.FirstName = "Zihao";
            TestItem.LastName = "Zhang";
            TestItem.Gender = "Male";
            TestItem.Position = "Cleaner";
            TestItem.Password = "asdfgasdfgh";
            TestItem.Attendence = 98.6;
            TestItem.Address = "Leicester";
            TestItem.PhoneNumber = "+12345678";
            //set ThisStaff  to the test data 
            AllStaffs.ThisStaff = TestItem;
            //add the record 
            PrimaryKey = AllStaffs.Add();
            //modify the test data 
            TestItem.StaffNumber = "P1622605";
            TestItem.FirstName = "YiFan";
            TestItem.LastName = "Wu";
            TestItem.Gender = "Male";
            TestItem.Position = "Officer";
            TestItem.Password = "asdfgasdffh";
            TestItem.Attendence = 99.6;
            TestItem.Address = "London";
            TestItem.PhoneNumber = "+12345679";
            //set the crecod based on the new test data  
            AllStaffs.ThisStaff = TestItem;
            //update the record 
            AllStaffs.Update();
            //find the record 
            AllStaffs.ThisStaff.Search(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);
        }
    }
}
