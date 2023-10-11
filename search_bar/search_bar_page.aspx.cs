using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



// CONSTRAINT [fk_ads_ToTable0] FOREIGN KEY ([acategoryid]) REFERENCES [dbo].[category] ([catid]),
// CONSTRAINT[fk_ads_ToTable1] FOREIGN KEY([asubcatid]) REFERENCES[dbo].[subcategory]([subcatid])

namespace search_bar
{
    public partial class search_bar_page : System.Web.UI.Page

    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB1.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)

        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }


        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)



        {
            if (TextBox1.Text != "")
            {
                if ((TextBox1.Text == "tshirt") || (TextBox1.Text == "Tshirt"))
                {
                    Response.Redirect("Menus/Tshirt.aspx");
                }
                else if ((TextBox1.Text == "tshirt") || (TextBox1.Text == "Jeans"))
                {
                    Response.Redirect("Menus/Jeans.aspx");

                }
                else if ((TextBox1.Text == "shoes") || (TextBox1.Text == "Shoes"))
                {
                    Response.Redirect("Menus/Shoes.aspx");

                }

            }
        }
    }
}