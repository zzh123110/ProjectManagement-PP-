using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class LogIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonLogin_Click(object sender, EventArgs e)
    {
        //connect database 
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["testDataBaseConnectionString"].ConnectionString);
        //check email from Administrator table//
        conn.Open();
        string checkuser = "select count(*) from tblAdministrator where UserName ='" + TextBoxUserName.Text + "'";
        SqlCommand com = new SqlCommand(checkuser, conn);
        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        conn.Close();
        //check password when email exist//
        if (temp == 1)
        {
            //check password//
            conn.Open();
            string checkPasswordQuery = "select Password from tblAdministrator where UserName ='" + TextBoxUserName.Text + "'";
            SqlCommand passComM = new SqlCommand(checkPasswordQuery, conn);
            //It is not allowed "blank"//
            string password = passComM.ExecuteScalar().ToString().Replace(" ", "");
            //If password is correct, webpage turn to homepage//
            if (password == TextBoxPassword.Text)
            {
                Session["New"] = TextBoxUserName.Text;
                Response.Write("<script type='text/javascript'>alert('Password is Correct and try again');</script>");
                Response.Redirect("Staff%20Information.aspx");
            }
            //if password is incorrect, webpage gives response write//
            else
            {
                Response.Write("<script type='text/javascript'>alert('Password is not Correct and try again');</script>");
            }
        }
        //If username is not exist or incorrect, give response write//
        else
        {
            Response.Write("<script type='text/javascript'>alert('Username is not Correct and try again');</script>");
        }
    }
}