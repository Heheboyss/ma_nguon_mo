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
namespace trangchugv
{
    public partial class frmqlsvgv : Form
    {
        public frmqlsvgv()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NVIUQTM\\SQLEXPRESS;Initial Catalog=Demo_QLD;Integrated Security=True");
        private void frmqlsvgv_Load(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt = new DataTable();
            string query = "select * from Sinhvien";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dgvmain.DataSource = dt;
            conn.Close();
        }

        private void btntk_Click(object sender, EventArgs e)
        {
          
        }

        private void btnthoatqlsv_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
