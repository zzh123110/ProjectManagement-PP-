using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // update the list box
            DisplayStaffs();
        }
    }

    void DisplayStaffs()
    {
        //create an instance of the County Collection
        MyClassLibrary.clsStaffCollection Staffs = new MyClassLibrary.clsStaffCollection();
        //set the data source to the list of counties in the collection
        lstStaffs.DataSource = Staffs.StaffList;
        //set the name of the primary key
        lstStaffs.DataValueField = "StaffID";
        //set the data field to display
        lstStaffs.DataTextField = "StaffNumber";
        //bind the data to the list
        lstStaffs.DataBind();
    }



    protected void ButtonUpdate_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 StaffID;
        //if a record has been selected from the list
        if (lstStaffs.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StaffID = Convert.ToInt32(lstStaffs.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the edit page
            Response.Redirect("UpdateStaff.aspx");
        }
        else//if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}