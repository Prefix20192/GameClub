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
    public partial class client_menu : Form
    {

        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.mdb;";

        private OleDbConnection myConnection;
        public client_menu()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);

            myConnection.Open();
            listcollection.Clear();
            foreach(string str in list_game.Items)
            {
                listcollection.Add(str);
                //search.CharacterCasing = CharacterCasing.Lower;
            }
        }


        private void client_menu_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            Timer MyTimer = new Timer();

            user_name.Text = DataBank.l_user;
            string sql_select = $"SELECT * FROM clients WHERE login_user = '{DataBank.l_user}'";
            OleDbCommand command = new OleDbCommand(sql_select, myConnection);

            OleDbDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                time.Text = reader["time"].ToString();
                int tm = Convert.ToInt32(reader["time"].ToString());
                MyTimer.Interval = (tm * 60 * 1000); 
                MyTimer.Tick += new EventHandler(timer1_Tick);
                MyTimer.Start();
                balance.Text = reader["balance"].ToString();
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main_form = new Form1();
            this.Hide();
            main_form.Show();
        }


        List<string> listcollection = new List<string>();
        private void search_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(search.Text) == false)
            {
                list_game.Items.Clear();
                foreach(string str in listcollection)
                {
                    if (str.StartsWith(search.Text))
                    {
                        list_game.Items.Add(str);
                    }
                }
            }
            else if(search.Text == "")
            {
                list_game.Items.Clear();
                foreach (string str in listcollection)
                {
                    list_game.Items.Add(str);
                }
            }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Cursor = Cursors.Hand;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            client_settings client_settings_form = new client_settings();
            this.Hide();
            client_settings_form.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Ваше время закончилось\nВыключаю компьютер!", "Время закончилось");
            //Выключение компьютера
            //Process.Start("shutdown","/s /t 0");
            this.Close();
        }
    }
}
