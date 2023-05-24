using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace GameClub
{
    public partial class Form1 : Form
    {

        public static string connectString = ConfigurationManager.ConnectionStrings["base_main"].ConnectionString;

        private SqlConnection myConnection;

        public Form1()
        {
            InitializeComponent();
            myConnection = new SqlConnection(connectString);

            myConnection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }

        private void send_open_launch_Click(object sender, EventArgs e)
        {

            if (uname.Text == "admin" && password.Text == "admin")
            {
                admin_panel admin_form = new admin_panel();
                this.Hide();
                admin_form.Show();

                MessageBox.Show("Добро пожаловать в админку");
            }
            else
            {
                if (string.IsNullOrEmpty(uname.Text) && string.IsNullOrEmpty(password.Text))
                {
                    MessageBox.Show("ERROR: Вы не ввели данные");
                }
                else
                {

                    string sql_select = $"SELECT * FROM clients WHERE login_user = '{uname.Text}'";
                    SqlCommand command = new SqlCommand(sql_select, myConnection);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show($"Добро пожаловать {uname.Text}");
                        DataBank.l_user = uname.Text;
                        DataBank.p_user = password.Text;
                        client_menu client_menu_form = new client_menu();
                        this.Hide();
                        client_menu_form.Show();
                        reader.Close();
                    }
                    else
                    {
                        myConnection.Close();
                        MessageBox.Show("ERROR: Я вас не нашел в базе данных :(\nПроверьте правильность ввода данных!");
                        reader.Close();
                    }
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
