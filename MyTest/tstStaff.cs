using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTest
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        //staff id
        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 tstStaffID = 1;
            //Assign the data to the property
            AStaff.StaffID = tstStaffID;
            //test to see that the two values are the same
            Assert.IsNotNull(tstStaffID);
        }

        //staff number
        [TestMethod]
        public void StaffNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test daata to assign to the property
            string tstStaffNumber = "P1622604";
            //Assign the data to the property
            AStaff.StaffNumber = tstStaffNumber;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffNumber, tstStaffNumber);
        }

        [TestMethod]
        public void ValidStaffNumber()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string tstStaffNumber = "P1622604";
            OK = AStaff.StaffNumberValid(tstStaffNumber);
            //test to see that the result is corresct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string tstStaffNumber = "P162260";
            OK = AStaff.StaffNumberValid(tstStaffNumber);
            //test to see that the result is corresct 
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffNumberMinBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string tstStaffNumber = "P1622604";
            OK = AStaff.StaffNumberValid(tstStaffNumber);
            //test to see that the result is corresct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string tstStaffNumber = "P16226044";
            OK = AStaff.StaffNumberValid(tstStaffNumber);
            //test to see that the result is corresct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string tstStaffNumber = "P1622561291";
            OK = AStaff.StaffNumberValid(tstStaffNumber);
            //test to see that the result is corresct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffNumberMaxBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string tstStaffNumber = "P16225612912";
            OK = AStaff.StaffNumberValid(tstStaffNumber);
            //test to see that the result is corresct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string tstStaffNumber = "P162256129121";
            OK = AStaff.StaffNumberValid(tstStaffNumber);
            //test to see that the result is corresct 
            Assert.IsFalse(OK);
        }

        //first name 
        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string tstFirstName = "Zihao";
            //Assign the data to the property
            AStaff.FirstName = tstFirstName;
            //test to see that the two values are the same
            Assert.IsNotNull(tstFirstName);
        }

        //last name
        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string tstLastName = "Zhang";
            //Assign the data to the property
            AStaff.LastName = tstLastName;
            //test to see that the two values are the same
            Assert.IsNotNull(tstLastName);
        }
        //gender
        [TestMethod]
        public void GenderPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string tstGender = "Male";
            //Assign the data to the property
            AStaff.Gender = tstGender;
            //test to see that the two values are the same
            Assert.IsNotNull(tstGender);
        }
        //position
        [TestMethod]
        public void PositionPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string tstPosition = "Cleaner";
            //Assign the data to the property
            AStaff.Position = tstPosition;
            //test to see that the two values are the same
            Assert.IsNotNull(tstPosition);
        }
        //password
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string tstPassword = "asdfgasdfgh";
            //Assign the data to the property
            AStaff.Password = tstPassword;
            //test to see that the two values are the same
            Assert.IsNotNull(tstPassword);
        }
        //attendence
        [TestMethod]
        public void AttendencePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            double tstAttendence = 98.6;
            //Assign the data to the property
            AStaff.Attendence = tstAttendence;
            //test to see that the two values are the same
            Assert.IsNotNull(tstAttendence);
        }
        //address
        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string tstAddress = "Leicester";
            //Assign the data to the property
            AStaff.Address = tstAddress;
            //test to see that the two values are the same
            Assert.IsNotNull(tstAddress);
        }
        //phone number 
        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string tstPhoneNumber = "+12345678";
            //Assign the data to the property
            AStaff.PhoneNumber = tstPhoneNumber;
            //test to see that the two values are the same
            Assert.IsNotNull(tstPhoneNumber);
        }
        //search method 
        [TestMethod]
        public void SearchMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the balidation 
            Boolean Search = false;
            //create some test data to use with the moethod 
            Int32 StaffID = 1;
            //invoke the moethod 
            Search = AStaff.Search(StaffID);
            //test to se that the result is correct
            Assert.IsTrue(Search);
        }

        //test search mothod
        //staff number search
        [TestMethod]
        public void TestStuffNumberSearch()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the balidation 
            Boolean Search = false;
            //boolean variable t oreord if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the moethod 
            Int32 StaffID = 1;
            //invoke the moethod 
            Search = AStaff.Search(StaffID);
            //check the Stuffnumber
            if (AStaff.StaffNumber != "P1622604")
            {
                OK = false;
            }
            //test to se that the result is correct
            Assert.IsTrue(OK);
        }

        //first name search 
        [TestMethod]
        public void TestFirstNameSearch()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the balidation 
            Boolean Search = false;
            //boolean variable t oreord if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the moethod 
            Int32 StaffID = 1;
            //invoke the moethod 
            Search = AStaff.Search(StaffID);
            //check the property
            if (AStaff.FirstName != "Zihao")
            {
                OK = false;
            }
            //test to se that the result is correct
            Assert.IsTrue(OK);
        }

        //last name search 
        [TestMethod]
        public void TestLastNameSearch()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the balidation 
            Boolean Search = false;
            //boolean variable t oreord if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the moethod 
            Int32 StaffID = 1;
            //invoke the moethod 
            Search = AStaff.Search(StaffID);
            //check the property
            if (AStaff.LastName != "Zhang")
            {
                OK = false;
            }
            //test to se that the result is correct
            Assert.IsTrue(OK);
        }

        //gender search 
        [TestMethod]
        public void TestGenderSearch()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the balidation 
            Boolean Search = false;
            //boolean variable t oreord if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the moethod 
            Int32 StaffID = 1;
            //invoke the moethod 
            Search = AStaff.Search(StaffID);
            //check the property
            if (AStaff.Gender != "Male")
            {
                OK = false;
            }
            //test to se that the result is correct
            Assert.IsTrue(OK);
        }

        //position search 
        [TestMethod]
        public void TestPositionSearch()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the balidation 
            Boolean Search = false;
            //boolean variable t oreord if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the moethod 
            Int32 StaffID = 1;
            //invoke the moethod 
            Search = AStaff.Search(StaffID);
            //check the property
            if (AStaff.Position != "Cleaner")
            {
                OK = false;
            }
            //test to se that the result is correct
            Assert.IsTrue(OK);
        }

        //attendence search 
        [TestMethod]
        public void TestAttendenceSearch()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the balidation 
            Boolean Search = false;
            //boolean variable t oreord if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the moethod 
            Int32 StaffID = 1;
            //invoke the moethod 
            Search = AStaff.Search(StaffID);
            //check the property
            if (AStaff.Attendence != 98.6)
            {
                OK = false;
            }
            //test to se that the result is correct
            Assert.IsTrue(OK);
        }

        //address search 
        [TestMethod]
        public void TestAddressSearch()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the balidation 
            Boolean Search = false;
            //boolean variable t oreord if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the moethod 
            Int32 StaffID = 1;
            //invoke the moethod 
            Search = AStaff.Search(StaffID);
            //check the property
            if (AStaff.Address != "Leicester")
            {
                OK = false;
            }
            //test to se that the result is correct
            Assert.IsTrue(OK);
        }
        //end of test search method

        //valid method 
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        //valid staff number
        [TestMethod]
        public void StaffNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P162260";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffNoMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P16226044";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622561291";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNoMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P16225612912";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P162256129121";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }      
        [TestMethod]
        public void StaffNoMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P162256121";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        //valid staff number

        //vaild first name 
        [TestMethod]
        public void FirtNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirtNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "a";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirtNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "ab";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirtNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            string FirstName = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            FirstName = FirstName.PadRight(49,'a');
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirtNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            string FirstName = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            FirstName = FirstName.PadRight(50, 'a');
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirtNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            string FirstName = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            FirstName = FirstName.PadRight(51, 'a');
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirtNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            string FirstName = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            FirstName = FirstName.PadRight(25, 'a');
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        //end of the firstname

        //vaildl last name 
        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "a";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "ab";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            string LastName = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            LastName = LastName.PadRight(49, 'a');
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            string LastName = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            LastName = LastName.PadRight(50, 'a');
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            string LastName = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            LastName = LastName.PadRight(51, 'a');
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            string LastName = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            LastName = LastName.PadRight(50, 'a');
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        //end the last name 

        //vaild gender
        [TestMethod]
        public void GenderMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Mal";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void GenderMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenderMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Malea";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenderMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Maleaaaaa";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenderMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Maleaaaaaa";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenderMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Maleaaaaaaa";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void GenderMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        //end of gender

        //vaild Position
        [TestMethod]
        public void PositionMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PositionMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "aa";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PositionPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "aa";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PositionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            string Position = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            Position = Position.PadRight(49, 'a');
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PositionMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            string Position = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            Position = Position.PadRight(50, 'a');
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PositionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            string Position = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            Position = Position.PadRight(51, 'a');
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        public void PositionMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            string Position = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            Position = Position.PadRight(25, 'a');
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        //end of postion

        //vaild password
        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfg";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "cleaner";
            string Password = "asdfga";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "aa";
            string Password = "asdfgas";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            string Password = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            Password = Password.PadRight(11, 'a');
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            string Password = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            Password = Password.PadRight(12, 'a');
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            string Password = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            Password = Password.PadRight(13, 'a');
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            string Password = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            Password = Password.PadRight(9, 'a');
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        //end of password

        //vaild gender
        [TestMethod]
        public void AttendenceMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = -0.1;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AttendenceMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 0;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AttendenceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 1.1;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AttendenceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 99.9;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AttendenceMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Maleaaaaaa";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 100;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AttendenceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 100.1;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AttendenceExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = -300;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AttendenceExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 300;
            string Address = "Leicester";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        //end of attendence

        //vaild address
        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfg";
            double Attendence = 98.6;
            string Address = "";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "cleaner";
            string Password = "asdfga";
            double Attendence = 98.6;
            string Address = "L";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "aa";
            string Password = "asdfgas";
            double Attendence = 98.6;
            string Address = "Le";
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            string Address = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            Address = Address.PadRight(99, 'a');
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            string Address = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh"; ;
            double Attendence = 98.6;
            Address = Address.PadRight(100, 'a');
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            string Address = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh"; ;
            double Attendence = 98.6;
            Address = Address.PadRight(101, 'a');
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            string Address = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh"; ;
            double Attendence = 98.6;
            Address = Address.PadRight(50, 'a');
            string PhoneNumber = "+12345678";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        //end of address

        //vaild Phone nubmer
        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Mal";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+123";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Male";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+1234";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Malea";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberrMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Maleaaaaa";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+123456789";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNubmerMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Maleaaaaaa";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+1234567890";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNubmerMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Maleaaaaaaa";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+12345678901";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNubmerMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messge 
            String Error = "";
            //create some test data to pass to the method 
            string StaffNumber = "P1622604";
            string FirstName = "Zihao";
            string LastName = "Zhang";
            string Gender = "Maleaaaaaa";
            string Position = "Cleaner";
            string Password = "asdfgasdfgh";
            double Attendence = 98.6;
            string Address = "Leicester";
            string PhoneNumber = "+1234567";
            //invoke the method 
            Error = AStaff.Valid(StaffNumber, FirstName, LastName, Gender, Position, Password, Attendence, Address, PhoneNumber);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        //end of phone nubmer

    }
}
