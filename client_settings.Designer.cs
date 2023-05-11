
namespace GameClub
{
    partial class client_settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(client_settings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.send_change = new System.Windows.Forms.Button();
            this.confirm_password = new System.Windows.Forms.TextBox();
            this.password_u = new System.Windows.Forms.TextBox();
            this.email_u = new System.Windows.Forms.TextBox();
            this.client_name = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.send_change);
            this.panel1.Controls.Add(this.confirm_password);
            this.panel1.Controls.Add(this.password_u);
            this.panel1.Controls.Add(this.email_u);
            this.panel1.Controls.Add(this.client_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 222);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(97, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(97, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // send_change
            // 
            this.send_change.Location = new System.Drawing.Point(191, 165);
            this.send_change.Name = "send_change";
            this.send_change.Size = new System.Drawing.Size(93, 32);
            this.send_change.TabIndex = 4;
            this.send_change.Text = "Сохранить";
            this.send_change.UseVisualStyleBackColor = true;
            this.send_change.Click += new System.EventHandler(this.send_change_Click);
            // 
            // confirm_password
            // 
            this.confirm_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirm_password.Location = new System.Drawing.Point(128, 132);
            this.confirm_password.Name = "confirm_password";
            this.confirm_password.Size = new System.Drawing.Size(212, 23);
            this.confirm_password.TabIndex = 3;
            // 
            // password_u
            // 
            this.password_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_u.Location = new System.Drawing.Point(128, 92);
            this.password_u.Name = "password_u";
            this.password_u.Size = new System.Drawing.Size(212, 23);
            this.password_u.TabIndex = 2;
            this.password_u.MouseClick += new System.Windows.Forms.MouseEventHandler(this.password_u_MouseClick);
            // 
            // email_u
            // 
            this.email_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_u.Location = new System.Drawing.Point(128, 52);
            this.email_u.Name = "email_u";
            this.email_u.Size = new System.Drawing.Size(212, 23);
            this.email_u.TabIndex = 1;
            this.email_u.MouseClick += new System.Windows.Forms.MouseEventHandler(this.email_u_MouseClick);
            // 
            // client_name
            // 
            this.client_name.AutoSize = true;
            this.client_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.client_name.Location = new System.Drawing.Point(192, 9);
            this.client_name.Name = "client_name";
            this.client_name.Size = new System.Drawing.Size(86, 31);
            this.client_name.TabIndex = 0;
            this.client_name.Text = "label1";
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(455, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(22, 27);
            this.exit.TabIndex = 7;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // client_settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(489, 222);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "client_settings";
            this.Text = "Настройки профиля";
            this.Load += new System.EventHandler(this.client_settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label client_name;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button send_change;
        private System.Windows.Forms.TextBox confirm_password;
        private System.Windows.Forms.TextBox password_u;
        private System.Windows.Forms.TextBox email_u;
        private System.Windows.Forms.Button exit;
    }
}