using System;
using System.IO;
using MimeKit;
using MailKit.Net.Smtp;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MailClient
{
    public partial class SendMessage : Form
    {
        Settings settings;
        string AttachmentFile = "";
        public MimeMessage MimeMessage;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage1(IntPtr hwnd, int wmsg, int wparam, int lparam);
        public SendMessage(Settings settings1)
        {
            InitializeComponent();
            settings = settings1;
        }
        #region Design
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage1(Handle, 0x112, 0xf012, 0);
        }
        #endregion
        private void button2_Click(object sender, EventArgs e)
        {
            if (!IsValidEmail(email_client.Text))
            {
                MessageBox.Show("Email неверный!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TextLetter.Text.Trim().Length == 0)
            {
                MessageBox.Show("Cодержимое письма пусто!", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(settings.login.Text));
            message.To.Add(new MailboxAddress(email_client.Text));
            message.Subject = theme.Text;
            var builder = new BodyBuilder();
            builder.TextBody = TextLetter.Text;
            if (AttachmentFile != "")
            {
                builder.Attachments.Add(AttachmentFile);
            }
            message.Body = builder.ToMessageBody();
            try
            {
                using (var client = new SmtpClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, ex) => true;
                    client.Connect(settings.smtp_adress.Text, Convert.ToInt32(settings.smtp_port.Text), true);
                    client.Authenticate(settings.login.Text, settings.password.Text);
                    client.Send(message);
                    client.Disconnect(true);
                    DialogResult dialogResult = MessageBox.Show("Письмо отправленно. Закрыть окно?", "Закрыть окно?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                settings.toolStripStatusLabel1.Text = "Ошибка: " + ex.Message;
                MessageBox.Show(ex.Message);
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var adress = new System.Net.Mail.MailAddress(email);
                return adress.Address == email;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog FD = new OpenFileDialog();
            if (FD.ShowDialog() == DialogResult.OK)
            {
                AttachmentFile = FD.FileName;
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() != DialogResult.OK)
            {
            }
            foreach (var attachment in MimeMessage.Attachments)
            {
                var fileName = attachment.ContentDisposition?.FileName ?? attachment.ContentType.Name;
                using (var stream = File.Create(Path.Combine(FBD.SelectedPath, fileName)))
                {
                    if (attachment is MessagePart)
                    {
                        var part = (MessagePart)attachment;
                        part.Message.WriteTo(stream);
                    }
                    else
                    {
                        var part = (MimePart)attachment;
                        part.Content.DecodeTo(stream);
                    }
                }
            }
        }
    }
}