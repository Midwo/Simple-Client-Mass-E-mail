using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace MassEmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void WyslijAsynchr(MailMessage wiadomosc)
        {
            try
            {
                SmtpClient klient = new SmtpClient(textBoxSmtp.Text);
                if (textBoxLogin.Text != String.Empty && maskedTextBoxPassword.Text != String.Empty)
                    klient.Credentials = new NetworkCredential(textBoxLogin.Text, maskedTextBoxPassword.Text);
                else
                {
                    MessageBox.Show("Proszę podać nazwę użytkownika i hasło");
                    return;
                }
                klient.EnableSsl = true;
                klient.SendCompleted += new SendCompletedEventHandler(Wyslane);
                klient.SendAsync(wiadomosc, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Wyslane(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled | e.Error != null)
            {
                MessageBox.Show("Błąd: Wysyłanie anulowane bądź wystąpił błąd serwera");
                
            }
            else
            {
                MessageBox.Show("Wiadomość wysłana", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void buttonDodajAdres_Click(object sender, EventArgs e)
        {
            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(textBoxAdres.Text);
                listBoxAdresy.Items.Add(textBoxAdres.Text);
                textBoxAdres.Clear();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // MessageBox.Show("Wprowdz poprawny adres e-mail", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          

        }

        private void listBoxAdresy_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxAdresy.SelectedIndex != -1)
                listBoxAdresy.Items.RemoveAt(listBoxAdresy.SelectedIndex);
        }

        private void textBoxAdres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonDodajAdres_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBoxZalaczniki.Items.Add(openFileDialog1.FileName);
            }
        }

        private void listBoxZalaczniki_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxZalaczniki.SelectedIndex != -1)
            {
                listBoxZalaczniki.Items.RemoveAt(listBoxZalaczniki.SelectedIndex);
            }
        }

        private void buttonWyslij_Click(object sender, EventArgs e)
        {
            MailAddress Od;
            MailAddress Do;
            MailMessage wiadomosc = new MailMessage();
            try
            {
                Od = new MailAddress(textBoxNadawca.Text);
            }
            catch
            {
                MessageBox.Show("Nieprawidłowy adres nadawcy");
                textBoxNadawca.Clear();
                return;
            }
            wiadomosc.From = Od;
            if (listBoxZalaczniki.Items.Count > 0)
                foreach (string plik in listBoxZalaczniki.Items)
                {
                    Attachment zalacznik = new Attachment(plik);
                    wiadomosc.Attachments.Add(zalacznik);
                }
            try
            {
                foreach (string adres in listBoxAdresy.Items)
                {
                    Do = new MailAddress(adres);
                    wiadomosc.To.Add(Do);
                }
                if (textBoxTemat.Text == String.Empty || textBoxTresc.Text == String.Empty)
                {
                    MessageBox.Show("Wprowadź treść wiadomości / temat","Błąd",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                wiadomosc.Subject = textBoxTemat.Text;
                wiadomosc.Body = textBoxTresc.Text;
                WyslijAsynchr(wiadomosc);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            textBoxNadawca.Text = textBoxLogin.Text;
        }
    }
}
