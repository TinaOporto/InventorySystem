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
    public partial class CategoryName : MetroForm
    {
        private MySqlConnection connection;
        string ConnectionString = ConfigurationManager.AppSettings["connection"];

        public CategoryName()
        {
            InitializeComponent();
        }

        public int row = 0;

        private void CategoryName_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);

            using (MySqlDataAdapter adapter = new MySqlDataAdapter("Select cid AS ID, cat_name As Category_Name  from category_info order by cat_name Asc", connection))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                cat_grid.DataSource = ds.Tables[0];
                cat_grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
           
        }

        private void cat_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            mbtn_cat.PerformClick();
        }      
    }
}
