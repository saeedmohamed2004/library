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
    public partial class Return_Books_Reports : Form
    {
        SqlConnection con = new SqlConnection("data source =DESKTOP-89JTB9U; initial catalog = library; integrated security = true ");

        public Return_Books_Reports()
        {
            InitializeComponent();
        }

        private void Return_Books_Reports_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("reports", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@report", SqlDbType.NVarChar).Value = "return";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
