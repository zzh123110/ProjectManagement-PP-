using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Staff_Information : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
            //update the list box
          //  DisplayStaffs();
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

    
}