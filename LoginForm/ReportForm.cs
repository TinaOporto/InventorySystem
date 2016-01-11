
using CrystalDecisions.CrystalReports.Engine;
using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoginForm
{
    public partial class ReportForm : MetroForm
    {
        public ReportForm()
        {
            InitializeComponent();
        }

       

        private void ReportForm_Load_1(object sender, EventArgs e)
        {

            this.crystalReportViewer1.RefreshReport();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            ReportDocument myReport = new ReportDocument();
            DataSet myData = new DataSet();
            MySqlConnection conn = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();
            
           
            conn.ConnectionString = "Server=192.168.0.24;Database=inventory_items;Uid=tina;Pwd=!ojt2015;";


            try
            {
                DataTable dt = new DataTable();
                dt.TableName = "inventory_info";
                //dt.TableName = "transaction";       

                cmd.CommandText = "SELECT inventory_info.iid, inventory_info.item_name, inventory_info.item_description, inventory_info.quantity, transaction.price FROM inventory_info Inner Join transaction ON transaction.iid = inventory_info.iid Where inventory_info.category = '" + cmb_search.Text + "' And date(trans_date) >='"+date_from.Value.ToString("yyyy-MM-dd") +"' And date(trans_date) <= '"+date_to.Value.ToString("yyyy-MM-dd")+"'";
                cmd.Connection = conn;

                myAdapter.SelectCommand = cmd;
                myAdapter.Fill(dt);

                myData.Tables.Add(dt);


                string reportPath = @"C:\Users\OJT\Desktop\MainProject\LoginForm\LoginForm\CrystalReport1.rpt";
                myReport.Load(reportPath);
                myReport.SetDataSource(myData);
                crystalReportViewer1.ReportSource = myReport;

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Report could not be created", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

    }
}
