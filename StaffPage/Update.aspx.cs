using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Update : System.Web.UI.Page
{
    Int32 StaffID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StaffID != -1)
            {
                //display the current data for the record
                DisplayStaffsDetial();
            }
        }
    }
    void DisplayStaffsDetial()
    {
        //create an instance of the address book
        MyClassLibrary.clsStaffCollection Astaff = new MyClassLibrary.clsStaffCollection();
        //find the record to update
        Astaff.ThisStaff.Search(StaffID);
        //display the data for this record
        TextBoxStaffNubmer.Text = Astaff.ThisStaff.StaffNumber;
        TextBoxFirstName.Text = Astaff.ThisStaff.FirstName;
        TextBoxLastName.Text = Astaff.ThisStaff.LastName;
        TextBoxGender.Text = Astaff.ThisStaff.Gender;
        TextBoxPosition.Text = Astaff.ThisStaff.Position;
        TextBoxPassword.Text = Astaff.ThisStaff.Password;
        TextBoxAttendence.Text = Astaff.ThisStaff.Attendence.ToString();
        TextBoxAddress.Text = Astaff.ThisStaff.Address;
        TextBoxPhoneNumber.Text = Astaff.ThisStaff.PhoneNumber;
    }
    protected void ButtonUpdate_Click(object sender, EventArgs e)
    {

        //add the new record 
        UpdateMethod();
        //all done soredirect back to the main page
        //Response.Redirect("Staff%20Information.aspx");
        //if (StaffID == -1)
        //{
        //    //add the new record 
        //    AddMethod();
        //}
        //else
        //{
        //    //update the record 
        //    UpdateMethod();
        //}

    }
    void UpdateMethod()
    {
        //create an instance of the Staff
        MyClassLibrary.clsStaffCollection Astaff = new MyClassLibrary.clsStaffCollection();
        //validate the data on the web form
        String Error = Astaff.ThisStaff.Valid(TextBoxStaffNubmer.Text, TextBoxFirstName.Text, TextBoxLastName.Text, TextBoxGender.Text, TextBoxPosition.Text, TextBoxPassword.Text, Convert.ToInt32(TextBoxAttendence.Text), TextBoxAddress.Text, TextBoxPhoneNumber.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update 
            Astaff.ThisStaff.Search(StaffID);
            //get the data entered by the user
            Astaff.ThisStaff.StaffNumber = TextBoxStaffNubmer.Text;
            Astaff.ThisStaff.FirstName = TextBoxFirstName.Text;
            Astaff.ThisStaff.LastName = TextBoxLastName.Text;
            Astaff.ThisStaff.Gender = TextBoxGender.Text;
            Astaff.ThisStaff.Position = TextBoxPosition.Text;
            Astaff.ThisStaff.Password = TextBoxPassword.Text;
            Astaff.ThisStaff.Attendence = Convert.ToInt32(TextBoxAttendence.Text);
            Astaff.ThisStaff.Address = TextBoxAddress.Text;
            Astaff.ThisStaff.PhoneNumber = TextBoxPhoneNumber.Text;
            //add the record
            Astaff.Update();
            //all done so redirect back to the main page
            Response.Redirect("Staff%20Information.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }

    }

    /*
    void AddMethod()
    {
        //create an instance of the Staff
        MyClassLibrary.clsStaffCollection Astaff = new MyClassLibrary.clsStaffCollection();
        //validate the data on the web form
        String Error = Astaff.ThisStaff.Valid(TextBoxStaffNubmer.Text, TextBoxFirstName.Text, TextBoxLastName.Text, TextBoxGender.Text, TextBoxPosition.Text, TextBoxPassword.Text, Convert.ToInt32(TextBoxAttendence.Text), TextBoxAddress.Text, TextBoxPhoneNumber.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            Astaff.ThisStaff.StaffNumber = TextBoxStaffNubmer.Text;
            Astaff.ThisStaff.FirstName = TextBoxFirstName.Text;
            Astaff.ThisStaff.LastName = TextBoxLastName.Text;
            Astaff.ThisStaff.Gender = TextBoxGender.Text;
            Astaff.ThisStaff.Position = TextBoxPosition.Text;
            Astaff.ThisStaff.Password = TextBoxPassword.Text;
            Astaff.ThisStaff.Attendence = Convert.ToInt32(TextBoxAttendence.Text);
            Astaff.ThisStaff.Address = TextBoxAddress.Text;
            Astaff.ThisStaff.PhoneNumber = TextBoxPhoneNumber.Text;
            //add the record
            Astaff.Add();
            //all done so redirect back to the main page
            Response.Redirect("Staff%20Information.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }
    */

 
}