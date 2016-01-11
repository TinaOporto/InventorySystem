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
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        private MySqlConnection connection;
        String ConnectionString = "Server=192.168.0.24;Database=inventory_items;Uid=tina;Pwd=!ojt2015;";
        DataTable table = new DataTable();

        public LoginForm()
        {
            InitializeComponent();
  
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);

            if (txt_uname.Text == "" || txt_pword.Text == "")
            {
                MessageBox.Show("Invalid Username or Password");
            }
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT uname, pword  From users Where uname = '" + txt_uname.Text + "' And pword ='" + txt_pword.Text + "'", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                cmd.ExecuteNonQuery();
                connection.Close();

                int count = ds.Tables[0].Rows.Count;
         
              
                if (count == 1)
                {
                    //MessageBox.Show("Login Successfully!");

                    MainForm main = new MainForm();
                    main.FormClosed += new FormClosedEventHandler(mainformclosed);
                    main.Show();

                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mainformclosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_uname.Text = "";
            txt_pword.Text = "";
        }

        
    }
}
