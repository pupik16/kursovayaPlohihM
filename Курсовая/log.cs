using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class log : Form
    {
        public log()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            string name = this.names.Text;
            string pass = this.Pass.Text;
            StreamReader log = new StreamReader("Аккаунты.txt");
            string str;
            bool login = true;
            while ((str = log.ReadLine()) != null)
            {
                string[]  text = str.Split("_".ToCharArray());
                if (text[0] == "user" && text[1] == name  && text[2] == pass)
                {
                    basicuser user = new basicuser();
                    user.Show();
                    this.Hide();
                    login = false;
                }
                else if (text[0] == "admin" && text[1] == name && text[2] == pass)
                {
                    basicadm adm = new basicadm();
                    adm.Show();
                    this.Hide();
                    login = false;
                }
            }
            log.Close();
            if (login)
            { 
                DialogResult LogEr = MessageBox.Show("Проверьте введённые данные", "Invalid password or name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
