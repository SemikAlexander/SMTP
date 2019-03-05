namespace MailClient
{
    partial class Settings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.imap_port = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imap_adress = new System.Windows.Forms.TextBox();
            this.pop3_port = new System.Windows.Forms.TextBox();
            this.pop3_adress = new System.Windows.Forms.TextBox();
            this.smtp_port = new System.Windows.Forms.TextBox();
            this.smtp_adress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imap = new System.Windows.Forms.RadioButton();
            this.pop3 = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SendMail = new System.Windows.Forms.Button();
            this.GetMail = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 48);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(705, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(751, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.imap_port);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.imap_adress);
            this.groupBox1.Controls.Add(this.pop3_port);
            this.groupBox1.Controls.Add(this.pop3_adress);
            this.groupBox1.Controls.Add(this.smtp_port);
            this.groupBox1.Controls.Add(this.smtp_adress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 269);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры подключения";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(17, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 21);
            this.label9.TabIndex = 57;
            this.label9.Text = "Пароль";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(96, 233);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(192, 23);
            this.password.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(30, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 21);
            this.label8.TabIndex = 55;
            this.label8.Text = "Логин";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(96, 204);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(192, 23);
            this.login.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(0, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 21);
            this.label7.TabIndex = 53;
            this.label7.Text = "Port IMAP";
            // 
            // imap_port
            // 
            this.imap_port.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imap_port.Location = new System.Drawing.Point(96, 175);
            this.imap_port.Name = "imap_port";
            this.imap_port.Size = new System.Drawing.Size(192, 23);
            this.imap_port.TabIndex = 52;
            this.imap_port.Text = "993";
            this.imap_port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.imap_port_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 21);
            this.label6.TabIndex = 51;
            this.label6.Text = "Port POP3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(2, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 50;
            this.label5.Text = "Port SMTP";
            // 
            // imap_adress
            // 
            this.imap_adress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imap_adress.Location = new System.Drawing.Point(96, 146);
            this.imap_adress.Name = "imap_adress";
            this.imap_adress.Size = new System.Drawing.Size(192, 23);
            this.imap_adress.TabIndex = 49;
            this.imap_adress.Text = "imap.yandex.ru";
            // 
            // pop3_port
            // 
            this.pop3_port.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pop3_port.Location = new System.Drawing.Point(96, 117);
            this.pop3_port.Name = "pop3_port";
            this.pop3_port.Size = new System.Drawing.Size(192, 23);
            this.pop3_port.TabIndex = 48;
            this.pop3_port.Text = "995";
            this.pop3_port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pop3_port_KeyPress);
            // 
            // pop3_adress
            // 
            this.pop3_adress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pop3_adress.Location = new System.Drawing.Point(96, 88);
            this.pop3_adress.Name = "pop3_adress";
            this.pop3_adress.Size = new System.Drawing.Size(192, 23);
            this.pop3_adress.TabIndex = 47;
            this.pop3_adress.Text = "pop.yandex.ru";
            // 
            // smtp_port
            // 
            this.smtp_port.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smtp_port.Location = new System.Drawing.Point(96, 59);
            this.smtp_port.Name = "smtp_port";
            this.smtp_port.Size = new System.Drawing.Size(192, 23);
            this.smtp_port.TabIndex = 46;
            this.smtp_port.Text = "465";
            this.smtp_port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.smtp_port_KeyPress);
            // 
            // smtp_adress
            // 
            this.smtp_adress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smtp_adress.Location = new System.Drawing.Point(96, 30);
            this.smtp_adress.Name = "smtp_adress";
            this.smtp_adress.Size = new System.Drawing.Size(192, 23);
            this.smtp_adress.TabIndex = 45;
            this.smtp_adress.Text = "smtp.yandex.ru";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(35, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 44;
            this.label3.Text = "IMAP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(36, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 43;
            this.label2.Text = "POP3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 42;
            this.label1.Text = "SMTP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imap);
            this.groupBox2.Controls.Add(this.pop3);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 83);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тип приёма почты";
            // 
            // imap
            // 
            this.imap.AutoSize = true;
            this.imap.Location = new System.Drawing.Point(21, 53);
            this.imap.Name = "imap";
            this.imap.Size = new System.Drawing.Size(67, 24);
            this.imap.TabIndex = 4;
            this.imap.TabStop = true;
            this.imap.Text = "IMAP";
            this.imap.UseVisualStyleBackColor = true;
            // 
            // pop3
            // 
            this.pop3.AutoSize = true;
            this.pop3.Location = new System.Drawing.Point(21, 25);
            this.pop3.Name = "pop3";
            this.pop3.Size = new System.Drawing.Size(66, 24);
            this.pop3.TabIndex = 3;
            this.pop3.TabStop = true;
            this.pop3.Text = "POP3";
            this.pop3.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 421);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // SendMessage
            // 
            this.SendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendMail.Image = ((System.Drawing.Image)(resources.GetObject("SendMessage.Image")));
            this.SendMail.Location = new System.Drawing.Point(721, 363);
            this.SendMail.Name = "SendMessage";
            this.SendMail.Size = new System.Drawing.Size(70, 49);
            this.SendMail.TabIndex = 4;
            this.toolTip1.SetToolTip(this.SendMail, "Отправить письмо");
            this.SendMail.UseVisualStyleBackColor = true;
            this.SendMail.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // GetMail
            // 
            this.GetMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetMail.Image = ((System.Drawing.Image)(resources.GetObject("GetMail.Image")));
            this.GetMail.Location = new System.Drawing.Point(632, 363);
            this.GetMail.Name = "GetMail";
            this.GetMail.Size = new System.Drawing.Size(70, 49);
            this.GetMail.TabIndex = 5;
            this.toolTip1.SetToolTip(this.GetMail, "Получить письмо");
            this.GetMail.UseVisualStyleBackColor = true;
            this.GetMail.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(480, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(308, 303);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.GetMail);
            this.Controls.Add(this.SendMail);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox imap_port;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox imap_adress;
        public System.Windows.Forms.TextBox pop3_port;
        public System.Windows.Forms.TextBox pop3_adress;
        public System.Windows.Forms.TextBox smtp_port;
        public System.Windows.Forms.TextBox smtp_adress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton imap;
        private System.Windows.Forms.RadioButton pop3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button SendMail;
        private System.Windows.Forms.Button GetMail;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListView listView1;
    }
}

