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
    public partial class admin_panel : Form
    {

        public admin_panel()
        {
            InitializeComponent();
        }

        private void admin_panel_Load(object sender, EventArgs e)
        {
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Form1 Main_form = new Form1();
            this.Hide();
            Main_form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client_settings_admin client_settings_admin_form = new client_settings_admin();
            this.Hide();
            client_settings_admin_form.Show();
        }
    }
}
