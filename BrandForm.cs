using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class BrandForm : MetroForm
    {
        public string cid;
        private MySqlConnection connection;
        string ConnectionString = ConfigurationManager.AppSettings["connection"];

        public BrandForm()
        {
            InitializeComponent();
        }

        public int row = 0;

        private void BrandForm_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);

            using (MySqlDataAdapter adapter = new MySqlDataAdapter("Select bid AS ID, brand_name as Brand_Name from brand_info where cid = '"+ cid +"'  order by brand_name ASC", connection))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                brand_grid.DataSource = ds.Tables[0];
                brand_grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void brand_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            btn_brand.PerformClick();
        }       
    }
}
