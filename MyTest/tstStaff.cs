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
            string StaffNumber = "P16225612";
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
        //end the last name 
    }
}
