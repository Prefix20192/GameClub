using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;


namespace GameClub
{
    class DbClients
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.mdb;";
        public static OleDbConnection GetConnection()
        {

            OleDbConnection con = new OleDbConnection(connectString);
            try
            {
                con.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error connection SQL");
            }
            return con;
        }


        public static void AddClient(Clients cl)
        {
            string sql = "INSERT INTO [clients] (login_user, password, time, balance) VALUES (@log_u, @pass_u, @time_u, @balance_u)";

            OleDbConnection con = GetConnection();
            OleDbCommand cmd = new OleDbCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("log_u", SqlDbType.VarChar).Value = cl.Email;
            cmd.Parameters.Add("pass_u", SqlDbType.VarChar).Value = cl.password;
            cmd.Parameters.Add("time_u", SqlDbType.VarChar).Value = cl.time;
            cmd.Parameters.Add("balance_u", SqlDbType.VarChar).Value = cl.balance;


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
        
        public static void UpdateClient(Clients cl)
        {
            string sql = "UPDATE [clients] SET login_user = @log_u, password = @pass_u, time = @time_u, balance = @balance_u WHERE id = @client_id";

            OleDbConnection con = GetConnection();
            OleDbCommand cmd = new OleDbCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("log_u", SqlDbType.VarChar).Value = cl.Email;
            cmd.Parameters.Add("pass_u", SqlDbType.VarChar).Value = cl.password;
            cmd.Parameters.Add("time_u", SqlDbType.VarChar).Value = cl.time;
            cmd.Parameters.Add("balance_u", SqlDbType.VarChar).Value = cl.balance;


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

            OleDbConnection con = GetConnection();
            OleDbCommand cmd = new OleDbCommand(sql, con);
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
            OleDbConnection con = GetConnection();
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adp.Fill(tbl);
            dvg.DataSource = tbl;
            con.Close();

        }

    }
}
