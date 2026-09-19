using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class basicadm : Form
    {
        public basicadm()
        {
            InitializeComponent();
            string[,] table = Conv("Данные.txt", 8);
            DataTabel.Rows.Add(table.GetLength(0));
            Print(table);
            string[,] log_table = Conv("Аккаунты.txt", 3);
            DataLog.Rows.Add(log_table.GetLength(0));
            Print2(log_table);
        }
        
        void Print(string[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                    DataTabel[j, i].Value = table[i, j];
            }

        }
        void Print2(string[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                    DataLog[j, i].Value = table[i, j];
            }

        }
        static string[,] Conv(string data, int columns)
        {
            int Count = System.IO.File.ReadLines(data).Count();
            StreamReader read = new StreamReader(data);
            string newline;
            string[,] table = new string[Count, columns];
            int j = 0;
            while ((newline = read.ReadLine()) != null)
            {
                string[] line = newline.Split("_ ".ToCharArray());
                for (int i = 0; i < line.Length; i++)
                {
                    table[j, i] = line[i];
                }
                j++;
            }
            read.Close();
            return table;
        }
        void Saved1(string tabel)
        {
            try
            {
                System.IO.File.WriteAllText(tabel, string.Empty);
                for (int i = 0; i < DataTabel.RowCount - 1; i++)
                {
                    DataGridViewRow LineTabel = DataTabel.Rows[i];
                    string[] maening = new string[DataTabel.Columns.Count];
                    for (int j = 0; j < DataTabel.Columns.Count; j++)
                    {
                        maening[j] = LineTabel.Cells[j].Value?.ToString();
                    }
                    int num = int.Parse(maening[0]);
                    int plase = int.Parse(maening[4]);
                    int year = int.Parse(maening[7]);
                    string line = string.Join("_", maening);
                    System.IO.File.AppendAllText(tabel, line + Environment.NewLine);
                }
            }
            catch (Exception e) 
            {
                string backup = "РезервнаяКопия.txt";
                File.Copy(backup, tabel, true);
                DialogResult er = MessageBox.Show("Ошибка сохранения", "Не верный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
        void Saved2(string tabel)
        {
            System.IO.File.WriteAllText(tabel, string.Empty);
            for (int i = 0; i < DataLog.RowCount - 1; i++)
            {
                DataGridViewRow LineTabel = DataLog.Rows[i];
                string[] maening = new string[DataLog.Columns.Count];
                for (int j = 0; j < DataLog.Columns.Count; j++)
                {
                    maening[j] = LineTabel.Cells[j].Value?.ToString();
                }

                string line = string.Join("_", maening);
                System.IO.File.AppendAllText(tabel, line + Environment.NewLine);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Saved1("Данные.txt");
            Saved2("Аккаунты.txt");
            DialogResult LogEr = MessageBox.Show("Данные успешно сохранены", "Операция выполнена", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            log lg = new log();
            lg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddChange ad = new AddChange();
            ad.Show();
            this.Hide();
        }
    }
}
