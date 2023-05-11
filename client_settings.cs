using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GameClub
{
    public partial class client_settings : Form
    {

        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.mdb;";

        private OleDbConnection myConnection;
        public client_settings()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);

            myConnection.Open();
        }

        private void client_settings_Load(object sender, EventArgs e)
        {
            client_name.Text = "Аккаунт: " + DataBank.l_user;
            email_u.Text = DataBank.l_user;
            password_u.Text = DataBank.p_user;
        }

        private void send_change_Click(object sender, EventArgs e)
        {
            string sql_select = $"UPDATE [clients] SET login_user = @l_u, password = @p_u WHERE login_user = '{DataBank.l_user}'";
            OleDbCommand cmd = new OleDbCommand(sql_select, myConnection);

            cmd.Parameters.AddWithValue("l_u", email_u.Text);
            cmd.Parameters.AddWithValue("p_u", password_u.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Обновил данные");

        }

        private void email_u_MouseClick(object sender, MouseEventArgs e)
        {
            if(email_u.Text == DataBank.l_user)
            {
                email_u.Text = "";
            }
        }

        private void password_u_MouseClick(object sender, MouseEventArgs e)
        {
            if(password_u.Text == DataBank.p_user)
            {
                password_u.Text = "";
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            client_menu client_menu_form = new client_menu();
            this.Hide();
            client_menu_form.Show();
        }
    }
}
