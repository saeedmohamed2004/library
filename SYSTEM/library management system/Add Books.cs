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
    public partial class Add_Books : Form
    {
        public Add_Books()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("data source =DESKTOP-89JTB9U; initial catalog = library; integrated security = true ");

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_add_books ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@bookname",SqlDbType.NVarChar).Value=textBox1.Text ;
            cmd.Parameters.Add("@authorname", SqlDbType.NVarChar).Value = textBox2.Text;
            cmd.Parameters.Add("@publication", SqlDbType.NVarChar).Value = textBox3.Text;
            cmd.Parameters.Add("@purchasedate", SqlDbType.NVarChar).Value = dateTimePicker1.Value;
            cmd.Parameters.Add("@bookprice", SqlDbType.NVarChar).Value = textBox4.Text;
            cmd.Parameters.Add("@quantity", SqlDbType.NVarChar).Value = textBox5.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("book added");
            con.Close();
            /* الحته اللي تحت دهه بتخليك اما تعمل ادد الحجات تتمسح تلقائي وتدخل بيانات تانيه */
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
         

        }
    }
}
