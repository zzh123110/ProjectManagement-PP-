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
            clsStaffCollection AllCounties = new clsStaffCollection();
            //test to see that it exsits 
            Assert.IsNotNull(AllCounties);
        }

        //conut property 
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllCounties = new clsStaffCollection();
            //create some test data ti assign to the property 
            Int32 SomeCount = 2;
            //assign the data to the property 
            AllCounties.Count = SomeCount;
            //test to see that the two values are the same 
            Assert.AreEqual(AllCounties.Count, SomeCount);
        }

        //all counties ok
        [TestMethod]
        public void AllStaffsOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection Staffs = new clsStaffCollection();
            //create some test data ti assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsStaff> TestList = new List<clsStaff>();
            //addd an item to the list 
            //create the item of test data 
            clsStaff TestItem = new clsStaff();
            //set its prperties 
            TestItem.StaffNumber = "P1622604";
            TestItem.FirstName = "Zihao";
            //add the item to the test lift 
            TestList.Add(TestItem);
            //assign the data to the property 
            Staffs.AllStaffs = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(Staffs.AllStaffs, TestList);
        }
        /*
        //match list 
        [TestMethod]
        public void CountMatchesList()
        {
            //create an instance of the class we want to create 
            clsStaffCollection Staffs = new clsStaffCollection();
            //create some test data ti assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsStaff> TestList = new List<clsStaff>();
            //addd an item to the list 
            //create the item of test data 
            clsStaff TestItem = new clsStaff();
            //set its prperties 
            TestItem.StaffNumber = "P1622604";
            TestItem.FirstName = "Zihao";
            //add the item to the test lift 
            TestList.Add(TestItem);
            //assign the data to the property 
            Staffs.AllStaffs = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(Staffs.AllStaffs, TestList.Count);
        }
        */
        //two staffs present 
        [TestMethod]
        public void TwoStaffsPresent()
        {
            //create an instance of the class we want to create 
            clsStaffCollection Staffs = new clsStaffCollection();
            //test to see that the two values are the same 
            Assert.AreEqual(Staffs.Count, 2);
        }

    }
}
