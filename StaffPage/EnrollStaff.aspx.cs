using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EnrollStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        //add the new record 
        Add();

    }
    
    void Add()
    {
        //create an instance of the Staff
        Class_Library.clsStaffCollection Astaff = new Class_Library.clsStaffCollection();
        //validate the data on the web form
        String Error = Astaff.ThisStaff.Valid(TextBoxStaffNubmer.Text, TextBoxFirstName.Text, TextBoxLastName.Text, TextBoxGender.Text, TextBoxPosition.Text, TextBoxPassword.Text, Convert.ToDecimal(TextBoxAttendence.Text), TextBoxAddress.Text, TextBoxPhoneNumber.Text);
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
            Astaff.ThisStaff.Attendence = Convert.ToDecimal(TextBoxAttendence.Text);
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
            lblError.Text = "There were problems with the data entered: " + Error;
        }
    }
}