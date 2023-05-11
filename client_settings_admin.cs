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
    public partial class client_settings_admin : Form
    {
        public client_settings_admin()
        {
            InitializeComponent();
        }

        public void Display()
        {
            DbClients.DisplayAndSearch("SELECT * FROM [clients]", dataGridView);
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            client_settings_admin_update client_settings_admin_update_form = new client_settings_admin_update(this);
            //this.Hide();
            client_settings_admin_update_form.Show();
        }

        private void client_settings_admin_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DbClients.DisplayAndSearch("SELECT * FROM [clients] WHERE Email LIKE'%"+ txtSearch .Text+ "%'", dataGridView);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                return;
            }
            if(e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Вы уверены что хотите удалить?", "information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbClients.DeleteClient(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
               
            }
        }
    }
}
