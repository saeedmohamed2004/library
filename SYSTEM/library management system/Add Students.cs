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
    public partial class Add_Students : Form
    {
        SqlConnection con = new SqlConnection("data source =DESKTOP-89JTB9U; initial catalog = library; integrated security = true ");
        public Add_Students()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_addstudents ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@student_name", SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@entrollment_num", SqlDbType.NVarChar).Value = textBox2.Text;
            cmd.Parameters.Add("@department_name", SqlDbType.NVarChar).Value = textBox3.Text;
            cmd.Parameters.Add("@cotact", SqlDbType.NVarChar).Value =textBox6.Text;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = textBox4.Text;
            cmd.Parameters.Add("@semester", SqlDbType.NVarChar).Value = textBox5.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("student details added");
            con.Close();
            /* الحته اللي تحت دهه بتخليك اما تعمل ادد الحجات تتمسح تلقائي وتدخل بيانات تانيه */
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }
    }
}
