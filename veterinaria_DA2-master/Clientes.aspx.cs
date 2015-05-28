using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Clientes : System.Web.UI.Page
{
    string connectionString = "Data Source = UCSM1133;" +
       "Initial Catalog=veterinaria;Integrated Security=SSPI";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (!this.IsValid) return;
        string insertSQL = "INSERT INTO Cliente VALUES(" +
            TextBox1.Text + ", '" + TextBox2.Text + "', '" + TextBox3.Text + "', " + TextBox4.Text + ")";
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(insertSQL, con);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            Label6.Text = "Cliente registrado con éxito";
            con.Close();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }

        catch (Exception err)
        {
            Label6.Text = "Error al registrar el Cliente";
            Label6.Text += err.Message;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        if (!this.IsValid) return;
        string updateSQL = "UPDATE Cliente SET descripcion = 'NUEVO' WHERE DNI = @DNI";
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(updateSQL, con);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            Label6.Text = "Clientes actualizados con éxito";
            con.Close();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }

        catch (Exception err)
        {
            Label6.Text = "Error al actualizar el Cliente";
            Label6.Text += err.Message;
        }
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        string selectSQL = "SELECT * FROM Cliente";
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(selectSQL, con);
        SqlDataReader dr;
        try
        {
            con.Open();
            dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            con.Close();
        }

        catch (Exception err)
        {
            Label6.Text = "Error al registrar el cliente";
            Label6.Text += err.Message;
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Label6.Text = "";
        string selectSQL = " SELECT * FROM Cliente WHERE DNI=" + TextBox1.Text;
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(selectSQL, con);
        SqlDataReader dr;
        try
        {
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TextBox2.Text = dr[1].ToString();
                TextBox3.Text = dr["Nombre Mascota"].ToString();
                TextBox4.Text = dr[3].ToString();

            }
            con.Close();
            dr.Close();
        }

        catch (Exception err)
        {
            Label6.Text = "Error al registrar el cliente";
            Label6.Text += err.Message;
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (!this.IsValid) return;
        string insertSQL = "DELETE FROM Cliente WHERE DNI=" + TextBox1.Text;
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(insertSQL, con);
        SqlDataReader dr;
        try
        {
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TextBox2.Text = dr[1].ToString();
                TextBox3.Text = dr["Nombre Mascota"].ToString();
                TextBox4.Text = dr[3].ToString();

            }
            Label6.Text = " Cliente eliminado con éxito";
            con.Close();
            dr.Close();
        }

        catch (Exception err)
        {
            Label6.Text = "Error al eliminar el cliemte";
            Label6.Text += err.Message;
        }
    }
    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }
}