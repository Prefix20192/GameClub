using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameClub
{
    public partial class client_settings_admin_update : Form
    {

        private readonly client_settings_admin _parent;
        public client_settings_admin_update(client_settings_admin parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void Clear()
        {
            client_email.Text = client_password.Text = client_balance.Text = client_time.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Сохранить")
            {
                Clients cl = new Clients(client_email.Text.Trim(), client_password.Text.Trim(), client_balance.Text.Trim(), client_time.Text.Trim());
                DbClients.AddClient(cl);
                Clear();
            }
            _parent.Display();
        }
    }
}
