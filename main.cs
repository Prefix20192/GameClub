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
    public partial class main : Form
    {
        public static string connectString = ConfigurationManager.ConnectionStrings["base_main"].ConnectionString;

        private SqlConnection myConnection;
        public main()
        {
            InitializeComponent();
            myConnection = new SqlConnection(connectString);

            myConnection.Open();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text == string.Empty || txtPassword.Text == string.Empty || txtPasswordRetry.Text == string.Empty)
            {
                txtEmail.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtPasswordRetry.Text = string.Empty;
                MessageBox.Show("Вы не заполнили все данные!");
            }
            if(txtPassword.Text == txtPasswordRetry.Text)
            {
                string sql_select = $"SELECT * FROM clients WHERE login_user = '{txtEmail.Text}'";
                SqlCommand command = new SqlCommand(sql_select, myConnection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    client_menu client_menu_form = new client_menu();
                    this.Hide();
                    client_menu_form.Show();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand($"INSERT INTO [clients] (login_user, password, time, balance) VALUES(@login, @pass, @time, @balance)", myConnection);

                    cmd.Parameters.AddWithValue("login", txtEmail.Text);
                    cmd.Parameters.AddWithValue("pass", txtPassword.Text);
                    cmd.Parameters.AddWithValue("time", 20);
                    cmd.Parameters.AddWithValue("balance", 100);
                    reader.Close();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Добро пожаловать {txtEmail.Text}");
                        DataBank.l_user = txtEmail.Text;
                        DataBank.p_user = txtPassword.Text;
                        client_menu client_menu_form = new client_menu();
                        this.Hide();
                        client_menu_form.Show();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        myConnection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают!");
            }
        }

        private void btnSing_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            this.Hide();
            Form1.Show();
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Отправил обращение администратору");
            //TODO
        }
    }
}
