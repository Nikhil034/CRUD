using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
public partial class Edit : System.Web.UI.Page

{
    private SqlConnection con;
    public void connect()
    {
        String newcon = WebConfigurationManager.ConnectionStrings["mycon"].ToString();
        con = new SqlConnection(newcon);
    }
    protected void Page_Load(object sender, EventArgs e)
    {

        connect();
        con.Open();
        String getid = Request.QueryString["editid"];
        editid.Text = getid;

        if (!IsPostBack)
        {
            SqlCommand cmd = new SqlCommand("select * from user_tb where id='" + getid + "'", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            editnm.Text = sdr["uname"].ToString();
            editeml.Text = sdr["uemail"].ToString();
            editpn.Text = sdr["uphone"].ToString();
            sdr.Close();
        }
    }
    protected void editnow_Click(object sender, EventArgs e)
    {
        connect();
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_edit", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@enm", editnm.Text);
        cmd.Parameters.AddWithValue("@eeml", editeml.Text);
        cmd.Parameters.AddWithValue("@epn",editpn.Text);
        cmd.Parameters.AddWithValue("@eid",editid.Text);

        int result = cmd.ExecuteNonQuery();
        if (result > 0)
        {
            con.Close();
            Response.Write("Edit done");
            
        }
        else
        {
            Response.Write("Not work");
        }
        
    }
}