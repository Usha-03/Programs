using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WinFormsAppCreate
{
    public partial class StoreProcedureMulParam : Form
    {
        SqlConnection con = new SqlConnection("Server=USHA\\USHA;Database=EmpDB;User Id=sa;Password=user123;");
        SqlCommand cmd;
        SqlParameter p1;
       // SqlDataReader dr;
        public StoreProcedureMulParam()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SPEmp_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            p1 = new SqlParameter("@Pempid", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtEmpId.Text);
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempname", SqlDbType.VarChar);
            p1.Value = txtEmpName.Text;
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempdesig", SqlDbType.VarChar);
            p1.Value = txtEmpDesig.Text;
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempdoj", SqlDbType.DateTime);
            p1.Value = Convert.ToDateTime(txtEmpDOJ.Text);
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempsal", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtEmpSal.Text);
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@PempDept", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtEmpDept.Text);
            cmd.Parameters.Add(p1);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + "record(s) Updated");
        }

        //private void lblEmployeeId_Click(object sender, EventArgs e)
        //{

        //}

        //private void txtEmployeeId_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void btnInsert_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SPEmp_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            p1 = new SqlParameter("@Pempid", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtEmpId.Text);
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempname", SqlDbType.VarChar);
            p1.Value = txtEmpName.Text;
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempdesig", SqlDbType.VarChar);
            p1.Value = txtEmpDesig.Text;
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempdoj", SqlDbType.DateTime);
            p1.Value = Convert.ToDateTime(txtEmpDOJ.Text);
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempsal", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtEmpSal.Text);
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempdept", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtEmpDept.Text);
            cmd.Parameters.Add(p1);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + "record(s) Inserted");



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SPEmp_Del", con);
            cmd.CommandType = CommandType.StoredProcedure;
            p1 = new SqlParameter("@Pempid", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtEmpId.Text);
            cmd.Parameters.Add(p1);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + "record(S) deleted");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            /*cmd = new SqlCommand("select * from EmployeeTB where EmpId = " + txtEmpId.Text, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                txtEmpId.Text = dr[0].ToString();
                txtEmpName.Text = dr[1].ToString();
                txtEmpDesig.Text = dr[2].ToString();
                txtEmpDOJ.Text = dr[3].ToString();
                txtEmpSal.Text = dr[4].ToString();
                txtEmpDept.Text = dr[5].ToString();
            }
            else
            {
                MessageBox.Show("record(s) not found");
                dr.Close();
            }
            con.Close();*/
            SqlCommand cmd = new SqlCommand("SPEmp_Find", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@Pempid", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtEmpId.Text);
            cmd.Parameters.Add(p1);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtEmpId.Text = reader[0].ToString();
                txtEmpName.Text = reader[1].ToString();
                txtEmpDesig.Text = reader[2].ToString();
                txtEmpDOJ.Text = reader[3].ToString();
                txtEmpSal.Text = reader[4].ToString();
                txtEmpDept.Text = reader[5].ToString();
            }
            else
            {
                MessageBox.Show("record(s) not found");
            }
            con.Close();

        }
    }
}
