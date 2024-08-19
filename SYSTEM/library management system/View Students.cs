using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_management_system
{
    public partial class View_Students : Form
    {
        SqlConnection con = new SqlConnection("data source =DESKTOP-89JTB9U; initial catalog = library; integrated security = true ");

        public View_Students()
        {
            InitializeComponent();
        }

        private void View_Students_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("viewstudentss", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@entrollmentno", SqlDbType.NVarChar).Value = "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("viewstudentss", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@entrollmentno", SqlDbType.NVarChar).Value = textBox3.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
