using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
public partial class _Default : System.Web.UI.Page
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
        if (!IsPostBack) //used when page is loaded and then we directly show records
        {
            display();
        }
    }
    public void display()
    {
        connect();
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from user_tb", con);
        SqlDataAdapter sd = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sd.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        connect();
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_add", con); //here pass your procedure name 
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@nm", txnm.Text);
        cmd.Parameters.AddWithValue("@eml", txeml.Text);
        cmd.Parameters.AddWithValue("@pn", txpn.Text);

        int i = cmd.ExecuteNonQuery();

        if (i > 0)
        {
            Response.Write("add done");
            display();
        }
        else
        {
            Response.Write("error occur");
        }
    }

    protected void btnrmv_Click(object sender, EventArgs e)
    {
        connect();
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_delete", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@rid", rid.Text);

        int result = cmd.ExecuteNonQuery();
        if (result > 0)
        {
            con.Close();
            Response.Write("<script>alert('Remove done')</script>");
            rid.Text = "";
            display();
        }
        else
        {
            Response.Write("<script>alert('Error Occurs')</script>");
        }

       
    }
    protected void btnedit_Click(object sender, EventArgs e)
    {
        Response.Redirect("Edit.aspx?editid=" + eid.Text);

    }
}