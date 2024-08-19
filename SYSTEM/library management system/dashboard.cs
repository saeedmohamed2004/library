using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_management_system
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Add_Books f = new Add_Books();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View_Books vb = new View_Books();
            vb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_Students ast = new Add_Students();
            ast.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            View_Students vs = new View_Students();
            vs.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Issue_Book ib = new Issue_Book();
            ib.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Return_Books rb = new Return_Books();
            rb.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Issue_Books_Reports ibr = new Issue_Books_Reports();
            ibr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Return_Books_Reports rbr = new Return_Books_Reports();
            rbr.Show();
        }
    }
 }
