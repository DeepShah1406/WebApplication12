using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication12
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            cmd = new SqlCommand();
                
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Deep\Documents\NewEmpDB.mdf;Integrated Security=True;Connect Timeout=30";
            
            cmd.Connection = con;
            cmd.CommandText = "NewEmpProcedure";

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@eid", txtEmpId.Text);
                cmd.Parameters.AddWithValue("@ename", txtEmpName.Text);
                cmd.Parameters.AddWithValue("@ecity", txtEmpCity.Text);
                cmd.Parameters.AddWithValue("@esal", txtEmpSal.Text);
                cmd.Parameters.AddWithValue("@op", 1);

                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (i > 0)
                {
                    Response.Write("Record Inserted.");
                }

                else
                {
                    Response.Write("Something Went Wrong.");
                }

                txtEmpId.Text = "";
                txtEmpName.Text = "";
                txtEmpCity.Text = "";
                txtEmpSal.Text = "";
            }


            catch (SqlException sqlex)
            {
                Response.Write(sqlex.Message);
            }


            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@eid", txtEmpId.Text);
                cmd.Parameters.AddWithValue("@ename", txtEmpName.Text);
                cmd.Parameters.AddWithValue("@ecity", txtEmpCity.Text);
                cmd.Parameters.AddWithValue("@esal", txtEmpSal.Text);
                cmd.Parameters.AddWithValue("@op", 2);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (i > 0)
                {
                    Response.Write("Record Updated.");
                }

                else
                {
                    Response.Write("Something Went Wrong.");
                }

                txtEmpId.Text = "";
                txtEmpName.Text = "";
                txtEmpCity.Text = "";
                txtEmpSal.Text = "";
            }

            catch (SqlException sqlex)
            {
                Response.Write(sqlex.Message);
            }


            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@eid", txtEmpId.Text);
                cmd.Parameters.AddWithValue("@op", 3);

                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (i > 0)
                {
                    Response.Write("Record Deleted.");
                }

                else
                {
                    Response.Write("Something Went Wrong.");
                }

                txtEmpId.Text = "";

            }
                
                catch (SqlException sqlex)
                {
                    Response.Write(sqlex.Message);
                }

                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader r;
                cmd.Parameters.AddWithValue("@op", 4);
                con.Open();
                r = cmd.ExecuteReader();

                gvEmp.DataSource = r;
                gvEmp.DataBind();
                con.Close();
            }
            catch (SqlException sqlex)
            {
                Response.Write(sqlex.Message);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}