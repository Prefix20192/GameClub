using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace GameClub
{
    class DbClients
    {   
        public static SqlConnection GetConnection()
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["base_main"].ConnectionString);
            try
            {
                con.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error connection SQL\n Error: " + ex.Message);
            }
            return con;
        }


        public static void AddClient(Clients cl)
        {
            string sql = "INSERT INTO clients (login_user, password, time, balance) VALUES (@log_u, @pass_u, @time_u, @balance_u)";

            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add("log_u", SqlDbType.VarChar).Value = cl.Email;
            cmd.Parameters.Add("pass_u", SqlDbType.VarChar).Value = cl.password;
            cmd.Parameters.Add("time_u", SqlDbType.Int).Value = cl.time;
            cmd.Parameters.Add("balance_u", SqlDbType.Int).Value = cl.balance;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Создан новый пользователь");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка: \n" + ex.Message);
            }
            con.Close();
        }  
        
        public static void UpdateClient(Clients cl, string id)
        {
            string sql = "UPDATE [clients] SET login_user = @log_u, password = @pass_u, time = @time_u, balance = @balance_u WHERE id = @client_id";

            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@client_id", id);
            cmd.Parameters.AddWithValue("@log_u", cl.Email);
            cmd.Parameters.AddWithValue("@pass_u", cl.password);
            cmd.Parameters.AddWithValue("@time_u", cl.time);
            cmd.Parameters.AddWithValue("@balance_u", cl.balance);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Обновил пользователя");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка: \n" + ex.Message);
            }
            con.Close();
        }
        public static void DeleteClient(string id)
        {
            string sql = "DELETE FROM [clients] WHERE id = @client_id";

            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("client_id", SqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Удалил пользователя");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: \n" + ex.Message);
            }
            con.Close();

        }

        public static void DisplayAndSearch(string query, DataGridView dvg)
        {
            string sql = query;
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adp.Fill(tbl);
            dvg.DataSource = tbl;
            con.Close();
        }

    }
}
