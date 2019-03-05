using System;
using MailKit;
using MimeKit;
using MailKit.Net.Pop3;
using MailKit.Net.Imap;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MailClient
{
    public partial class Settings : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);
        int Letter = 0, LastIndex = 0, CountBack = 0;
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (smtp_adress.Text.Trim().Length == 0)
            {
                MessageBox.Show("Заполните smtp адрес!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (smtp_port.Text.Trim().Length == 0)
            {
                MessageBox.Show("Заполните smtp порт!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((pop3_adress.Text.Trim().Length == 0 & pop3_port.Text.Trim().Length == 0) | (imap_adress.Text.Trim().Length == 0 & imap_port.Text.Trim().Length == 0))
            {
                MessageBox.Show("Заполните imap или pop3 адрес!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (login.Text.Trim().Length == 0)
            {
                MessageBox.Show("Заполните логин!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (password.Text.Trim().Length == 0)
            {
                MessageBox.Show("Заполните пароль!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                CountBack = 0; LastIndex = 0; Letter = 0;
                if (pop3.Checked)
                {
                    GetMessageByPOP3();
                }
                else if (imap.Checked)
                {
                    GetMessageByIMAP();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:" + ex.Message);
            }
        }
        private void SendMessage_Click(object sender, EventArgs e)
        {
            new SendMessage(this).Show();
            WindowState = FormWindowState.Minimized;
        }
        void GetMessageByPOP3(int count = 20)
        {
            try
            {
                toolStripStatusLabel1.Text = "Идет загрузка...";
                using (var client = new Pop3Client())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    client.Connect(pop3_adress.Text, Convert.ToInt32(pop3_port.Text), true);
                    client.Authenticate(login.Text, password.Text);
                    listView1.Items.Clear(); if (Letter < 0) Letter = 0;

                    if (client.Count == 0 | Letter > client.Count)
                    {
                        toolStripStatusLabel1.Text = "Писем нет.";
                        return;

                    }
                    LastIndex = Letter;
                    if (Letter + count <= client.Count)
                    {
                        for (int i = Letter; i < count + Letter; i++)
                        {
                            var message = client.GetMessage(i);
                            if (message.Subject != "")
                                listView1.Items.Add(message.Subject);
                            else
                                listView1.Items.Add(message.From.ToString());

                        }
                        Letter = count + Letter;
                    }
                    else
                    {
                        for (int i = Letter; i < client.Count - Letter; i++)
                        {
                            var message = client.GetMessage(i);

                            if (message.Subject != "")
                                listView1.Items.Add(message.Subject);
                            else
                                listView1.Items.Add(message.From.ToString());
                        }
                        Letter = client.Count - Letter;

                    }
                    toolStripStatusLabel1.Text = "Готово!";

                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Ошибка: " + ex.Message;
                MessageBox.Show(ex.Message);
            }
        }
        void GetMessageByIMAP(int count = 20)
        {
            toolStripStatusLabel1.Text = "Идет загрузка...";
            try
            {
                using(var client = new ImapClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    client.Connect(imap_adress.Text, Convert.ToInt32(imap_port.Text), true);
                    client.Authenticate(login.Text, password.Text);
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);
                    listView1.Items.Clear();
                    if (inbox.Count == 0 | Letter > inbox.Count)
                    {
                        toolStripStatusLabel1.Text = "Писем нет.";
                        return;
                    }
                    if (Letter + count <= inbox.Count)
                    {
                        for (int i = Letter; i < count + Letter; i++)
                        {
                            var message = inbox.GetMessage(i);
                            if (message.Subject != "")
                                listView1.Items.Add(message.Subject);
                            else
                                listView1.Items.Add(message.From.ToString());
                        }
                        Letter = count + Letter;
                    }
                    else
                    {
                        for (int i = Letter; i < inbox.Count - Letter; i++)
                        {
                            var message = inbox.GetMessage(i);

                            if (message.Subject != "")
                                listView1.Items.Add(message.Subject);
                            else
                                listView1.Items.Add(message.From.ToString());
                        }
                        Letter = inbox.Count - Letter;
                    }
                    toolStripStatusLabel1.Text = "Готово!";
                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Ошибка: " + ex.Message;
                MessageBox.Show(ex.Message);
            }
        }
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0) return;
            var firstSelectedItem = listView1.SelectedItems[0];
            SendMessage send = new SendMessage(this);
            send.button1.Visible = false;
            try
            {
                if (imap.Checked)
                {
                    //imap
                    toolStripStatusLabel1.Text = "Идет загрузка...";
                    using (var client = new ImapClient())
                    {
                        client.ServerCertificateValidationCallback = (s, c, h, ex) => true;
                        client.Connect(imap_adress.Text, Convert.ToInt32(imap_port.Text), true);
                        client.Authenticate(login.Text, password.Text);
                        var inbox = client.Inbox;
                        inbox.Open(FolderAccess.ReadOnly);
                        if (LastIndex < 0) LastIndex = 0;
                        var message = inbox.GetMessage(LastIndex + firstSelectedItem.Index);
                        send.email_client.Text = message.From.ToString();
                        send.theme.Text = message.Subject;
                        send.TextLetter.Text = (message.TextBody == null || message.TextBody.Trim().Length == 0) ? message.HtmlBody : message.TextBody;
                        send.MimeMessage = message;
                        send.button3.Visible = true;
                        send.button2.Visible = false;
                        send.button3.Enabled = true;
                        toolStripStatusLabel1.Text = "Готово!";
                        client.Disconnect(true);
                        send.ShowDialog();
                    }
                }
                else if (pop3.Checked)
                {
                    ///pop3
                    toolStripStatusLabel1.Text = "Идет загрузка...";
                    using (var client = new Pop3Client())
                    {
                        client.ServerCertificateValidationCallback = (s, c, h, ex) => true;
                        client.Connect(pop3_adress.Text, Convert.ToInt32(pop3_port.Text), true);
                        client.Authenticate(login.Text, password.Text);
                        if (LastIndex < 0) LastIndex = 0;
                        if (client.Count == 0 | LastIndex + firstSelectedItem.Index > client.Count)
                        {
                            toolStripStatusLabel1.Text = "Письма нет.";
                            return;
                        }
                        var message = client.GetMessage(LastIndex + firstSelectedItem.Index);
                        send.email_client.Text = message.From.ToString();
                        send.theme.Text = message.Subject;
                        send.TextLetter.Text = (message.TextBody.Trim().Length == 0) ? message.HtmlBody : message.TextBody;
                        send.MimeMessage = message;
                        send.button3.Visible = true;
                        send.button2.Visible = false;
                        send.button3.Enabled = true;
                        client.Disconnect(true);
                        send.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:" + ex.Message);
            }
        }
        #region Design
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void smtp_port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void pop3_port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void imap_port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
        #endregion
    }
}