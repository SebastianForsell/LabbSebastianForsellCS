using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=localhost; Initial Catalog=AdventureWorks2012; User ID=DaBaws; Password=gnu; Integrated Security=True");
            string sqlQuery = "SELECT * FROM Production.ProductPhoto";
            SqlCommand cmd = new SqlCommand(sqlQuery, connection);
            SqlDataReader oreader;
            try
            {
                ListItem lista1 = new ListItem();
                lista1.Text = "Select";
                lista1.Value = "0";
                ListBox1.Items.Add(lista1);
                connection.Open();
                oreader = cmd.ExecuteReader();
                while (oreader.Read())
                {
                    ListItem lista2 = new ListItem();
                    lista2.Text = oreader["ThumbnailPhotoFileName"].ToString();
                    lista2.Value = oreader["ProductPhotoID"].ToString();
                    ListBox1.Items.Add(lista2);
                }
                oreader.Close();
                oreader.Dispose();
                cmd.Dispose();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
                Label1.Visible = true;
                throw;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=localhost; Initial Catalog=AdventureWorks2012; User ID=DaBaws; Password=gnu; Integrated Security=True");
            string sqlQuery = "SELECT * FROM Production.ProductCategory";
            SqlCommand cmd = new SqlCommand(sqlQuery, connection);
            SqlDataReader oreader;
            try
            {
                ListItem li = new ListItem();
                li.Text = "Select";
                li.Value = "0";
                DropDownList1.Items.Add(li);
                connection.Open();
                oreader = cmd.ExecuteReader();
                while (oreader.Read())
                {
                    ListItem lista2 = new ListItem();
                    lista2.Text = oreader["Name"].ToString();
                    lista2.Value = oreader["ProductCategoryID"].ToString();
                    DropDownList1.Items.Add(lista2);
                }
                oreader.Close();
                oreader.Dispose();
                cmd.Dispose();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
                Label1.Visible = true;
                throw;
            }
        }
    }
}