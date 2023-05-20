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

        client_settings_admin_update form_update;

        public client_settings_admin()
        {
            InitializeComponent();
            form_update = new client_settings_admin_update(this);
        }

        public void Display()
        {
            DbClients.DisplayAndSearch("SELECT id,login_user,balance,time FROM clients", dataGridView);
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            form_update.Clear();
            form_update.Show();
        }

        private void client_settings_admin_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DbClients.DisplayAndSearch("SELECT * FROM clients WHERE login_user LIKE'%"+ txtSearch .Text+ "%'", dataGridView);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1)
            {
                form_update.Clear();
                form_update.id = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                form_update.Email = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                form_update.password = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                form_update.balance = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                form_update.time = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                form_update.UpdateInfo();
                form_update.ShowDialog();
            }
            if(e.ColumnIndex == 2)
            {
                if (MessageBox.Show("Вы уверены что хотите удалить?", "information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbClients.DeleteClient(dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
