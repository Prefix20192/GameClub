
namespace GameClub
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.client_form = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.send_open_launch = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.uname = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.client_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // client_form
            // 
            this.client_form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.client_form.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("client_form.BackgroundImage")));
            this.client_form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.client_form.Controls.Add(this.exit);
            this.client_form.Controls.Add(this.pictureBox2);
            this.client_form.Controls.Add(this.pictureBox1);
            this.client_form.Controls.Add(this.send_open_launch);
            this.client_form.Controls.Add(this.password);
            this.client_form.Controls.Add(this.uname);
            this.client_form.Location = new System.Drawing.Point(-3, 0);
            this.client_form.Name = "client_form";
            this.client_form.Size = new System.Drawing.Size(1382, 817);
            this.client_form.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(959, 547);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 33);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(705, 548);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 32);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // send_open_launch
            // 
            this.send_open_launch.BackColor = System.Drawing.Color.Transparent;
            this.send_open_launch.Image = ((System.Drawing.Image)(resources.GetObject("send_open_launch.Image")));
            this.send_open_launch.Location = new System.Drawing.Point(1209, 543);
            this.send_open_launch.Name = "send_open_launch";
            this.send_open_launch.Size = new System.Drawing.Size(36, 37);
            this.send_open_launch.TabIndex = 2;
            this.send_open_launch.UseVisualStyleBackColor = false;
            this.send_open_launch.Click += new System.EventHandler(this.send_open_launch_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(1000, 552);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(184, 20);
            this.password.TabIndex = 1;
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(744, 552);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(189, 20);
            this.uname.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(917, 595);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(55, 27);
            this.exit.TabIndex = 5;
            this.exit.Text = "Выйти";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 815);
            this.Controls.Add(this.client_form);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Client_form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.client_form.ResumeLayout(false);
            this.client_form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel client_form;
        private System.Windows.Forms.Button send_open_launch;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exit;
    }
}

