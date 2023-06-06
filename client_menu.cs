using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace GameClub
{
    public partial class client_menu : Form
    {

        public static string connectString = ConfigurationManager.ConnectionStrings["base_main"].ConnectionString;

        private SqlConnection myConnection;
        public client_menu()
        {
            InitializeComponent();
            myConnection = new SqlConnection(connectString);

            myConnection.Open();
            listcollection.Clear();
            foreach(string str in list_game.Items)
            {
                listcollection.Add(str);
         
            }
        }


        private void client_menu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            Timer MyTimer = new Timer();

            user_name.Text = DataBank.l_user;
            string sql_select = $"SELECT * FROM clients WHERE login_user = '{DataBank.l_user}'";
            SqlCommand command = new SqlCommand(sql_select, myConnection);

            SqlDataReader reader = command.ExecuteReader();
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
            client_settings_form.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("Ваше время закончилось\nВыключаю компьютер!", "Время закончилось");
            //Выключение компьютера
            //Process.Start("shutdown","/s /t 0");
            //this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Тут приложение .exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://yandex.com/");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Тут приложение .exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Тут приложение .exe");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Тут приложение .exe");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Тут приложение .exe");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Тут приложение .exe");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Тут приложение .exe");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Тут приложение .exe");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Тут приложение .exe");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Тут приложение .exe");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Тут приложение .exe");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Тут приложение .exe");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Тут приложение .exe");
        }
    }
}
