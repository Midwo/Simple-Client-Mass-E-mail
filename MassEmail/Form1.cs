using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassEmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
