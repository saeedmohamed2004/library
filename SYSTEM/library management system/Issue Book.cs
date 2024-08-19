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
    public partial class Issue_Book : Form
    {
        SqlConnection con = new SqlConnection("data source =DESKTOP-89JTB9U; initial catalog = library; integrated security = true ");

        public Issue_Book()
        {
            InitializeComponent();
        }

        private void Issue_Book_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_getbooks", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("viewstudentss", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@entrollmentno", SqlDbType.NVarChar).Value = textBox5.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
                textBox6.Text = dr[3].ToString();
                textBox4.Text = dr[4].ToString();
            }
            dr.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_addissuebook ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@student_name", SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@enrollment_no", SqlDbType.NVarChar).Value = textBox2.Text;
            cmd.Parameters.Add("@department", SqlDbType.NVarChar).Value = textBox3.Text;
            cmd.Parameters.Add("@contact", SqlDbType.NVarChar).Value = textBox6.Text;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = textBox4.Text;
            cmd.Parameters.Add("@bookname", SqlDbType.NVarChar).Value = comboBox1.Text;
            cmd.Parameters.Add("@issue_date", SqlDbType.NVarChar).Value = dateTimePicker1.Value.ToShortDateString();
            cmd.Parameters.Add("@return_date", SqlDbType.NVarChar).Value = "";
            cmd.ExecuteNonQuery();
            MessageBox.Show(" issued book added");
            con.Close();
            /* الحته اللي تحت دهه بتخليك اما تعمل ادد الحجات تتمسح تلقائي وتدخل بيانات تانيه */
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
        }
    }
}
