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
    public partial class Return_Books : Form
    {
        SqlConnection con = new SqlConnection("data source =DESKTOP-89JTB9U; initial catalog = library; integrated security = true ");

        public Return_Books()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("viewissuebook", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@entrollmentno", SqlDbType.NVarChar).Value = textBox5.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox3.Text = row.Cells[0].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update_issuebook", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = textBox5.Text;
            cmd.Parameters.Add("@return_date", SqlDbType.NVarChar).Value = dateTimePicker1.Value.ToShortDateString();
            cmd.ExecuteNonQuery();
            MessageBox.Show("book returned");
            con.Close();
        }
    }
}
