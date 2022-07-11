using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace Test2
{
    public partial class Form1 : Form
    {
        private SqlConnection con = null;
        private SqlDataAdapter adapter = null;
        private DataSet ds=null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using(con=new SqlConnection(ConfigurationManager.ConnectionStrings["Test2"].ConnectionString))
            {
                using(adapter=new SqlDataAdapter("Select from Employee",con))
                {
                    ds=new DataSet();
                    adapter.Fill(ds, "Employee");
                    GridEmployee.DataSource=ds.Tables["Employee"];
                }
            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using(con=new SqlConnection(ConfigurationManager.ConnectionStrings["Test2"].ConnectionString))
            {
                using(adapter=new SqlDataAdapter("select *from Employee", con))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    ds=new DataSet();
                    adapter.Fill(ds, "Employee");
                    //create new row in the dataset
                    DataRow dr = ds.Tables["Employee"].NewRow();
                    dr["EmployeeCode"]=TxtEmpNo.Text;
                    dr["EmployeeName"]=TxtEmpName.Text;
                    dr["Salary"]=TxtSalary.Text;
                    ds.Tables["Employee"].Rows.Add(dr);
                    adapter.Update(ds, "Employee");

                }
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {

            TxtEmpNo.Text="";
            TxtEmpName.Text="";
            TxtSalary.Text="";
            TxtEmpNo.Focus();
        }

        private void GridEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
