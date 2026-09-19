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
    public partial class basicuser : Form
    {
        public basicuser()
        {
            InitializeComponent();
            string[,] table = Conv("Данные.txt");
            DataTabel.Rows.Add(table.GetLength(0));
            Print(table);
        }
        void Print(string[,] table)
        {
            try
            {
                for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                        DataTabel[j, i].Value = table[i, j];
                }
            }
            catch (Exception ex)
            {
                DataTabel.Rows.Clear();
                DataTabel.Rows.Add(table.GetLength(0));
                Print(table);
            }

        }
        static string[,] Conv(string data)
        {
            int Count = System.IO.File.ReadLines(data).Count();
            StreamReader read = new StreamReader(data);
            string newline;
            string[,] table = new string[Count, 8];
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

        static string[,] AgeSort(string[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
                for (int j = 0; j < table.GetLength(0) - 1; j++)
                    if (int.Parse(table[j, 4]) < int.Parse(table[j + 1, 4]))
                    {
                        for (int k = 0; k < 8; k++)
                        {
                            string x = table[j, k];
                            table[j, k] = table[j + 1, k];
                            table[j + 1, k] = x;
                        }
                    }
            return table;
        }
        private void Age_CheckedChanged(object sender, EventArgs e)
        {
            string[,] table = Conv("Данные.txt");
            table = AgeSort(table);
            Print(table);
        }

        private void FIOsort_CheckedChanged(object sender, EventArgs e)
        {
            string[,] table = Conv("Данные.txt");
            for (int i = 0; i < table.GetLength(0); i++)
                for (int j = 0; j < table.GetLength(0) - 1; j++)
                    if ((table[j, 1] + table[j, 2] + table[j, 3]).CompareTo(table[j + 1, 1] + table[j + 1, 2] + table[j + 1, 3]) > 0)
                    {
                        for (int k = 0; k < 8; k++)
                        {
                            string x = table[j, k];
                            table[j, k] = table[j + 1, k];
                            table[j + 1, k] = x;
                        }
                    }
            Print(table);
        }

        private void Plase_CheckedChanged(object sender, EventArgs e)
        {
            string[,] table = Conv("Данные.txt");
            for (int i = 0; i < table.GetLength(0); i++)
                for (int j = 0; j < table.GetLength(0) - 1; j++)
                    if (int.Parse(table[j, 7]) > int.Parse(table[j + 1, 7]))
                    {
                        for (int k = 0; k < 8; k++)
                        {
                            string x = table[j, k];
                            table[j, k] = table[j + 1, k];
                            table[j + 1, k] = x;
                        }
                    }
            Print(table);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void FIO_TextChanged(object sender, EventArgs e)
        {
            DataTabel.Rows.Clear();
            string[,] tabel = Conv("Данные.txt");
            string fio = FIO.Text;
            int k = 0;
            for (int i = 0; i < tabel.GetLength(0); i++)
            {
                if ((tabel[i, 1] + " " + tabel[i, 2] + " " + tabel[i, 3]).Contains(fio))
                {
                    DataTabel.Rows.Add();
                    for (int j = 0; j < 8; j++)
                    {
                        DataTabel[j, k].Value = tabel[i, j];
                    }
                    k++;
                }
            }
        }

        private void Contry_TextChanged(object sender, EventArgs e)
        {
            DataTabel.Rows.Clear();
            string[,] tabel = Conv("Данные.txt");
            string сontry = Contry.Text;
            int k = 0;
            for (int i = 0; i < tabel.GetLength(0); i++)
            {
                if ((tabel[i,5]).Contains(сontry))
                {
                    DataTabel.Rows.Add();
                    for (int j = 0; j < 8; j++)
                    {
                        DataTabel[j, k].Value = tabel[i, j];
                    }
                    k++;
                }
            }

        }

        private void Instrument_TextChanged(object sender, EventArgs e)
        {
            DataTabel.Rows.Clear();
            string[,] tabel = Conv("Данные.txt");
            string instrument = Instrument.Text;
            int k = 0;
            for (int i = 0; i < tabel.GetLength(0); i++)
            {
                if ((tabel[i, 6]).Contains(instrument))
                {
                    DataTabel.Rows.Add();
                    for (int j = 0; j < 8; j++)
                    {
                        DataTabel[j, k].Value = tabel[i, j];
                    }
                    k++;
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            log lg = new log();
            lg.Show();
            this.Hide();
        }
        void choose(string tool)
        {
            DataTabel.Rows.Clear();
            DataTabel.Columns[4].HeaderText = "Возраст";
            string[,] table = Conv("Данные.txt");
            int k = 0;
            for (int i = 0; i < table.GetLength(0); i++)
            {
                if (int.Parse(table[i, 7]) <= 3 & table[i, 6] == tool)
                {
                    DataTabel.Rows.Add();
                    for (int j = 0; j < table.GetLength(1); j++)
                        DataTabel[j, k].Value = table[i, j];
                    DataTabel[4, k].Value = (2026 - int.Parse(table[i, 4])).ToString();
                    k++;
                }
            }
        }
        private void Task_Click(object sender, EventArgs e)
        {
            if (pianobutton.Checked)
            {
                choose("фортепиано");

            }
            else if (guitarbutton.Checked)
            {
                choose("гитара");

            }
            else if (skripkabutton.Checked)
            {
                choose("скрипка");
            }
            else
            {
                DataTabel.Rows.Clear();
                DataTabel.Columns[4].HeaderText = "Возраст";
                string[,] table = Conv("Данные.txt");
                int k = 0;
                for (int i = 0; i < table.GetLength(0); i++)
                {
                    if (int.Parse(table[i, 7]) <= 3)
                    {
                        DataTabel.Rows.Add();
                        for (int j = 0; j < table.GetLength(1); j++)
                            DataTabel[j, k].Value = table[i, j];
                        DataTabel[4, k].Value = (2026 - int.Parse(table[i, 4])).ToString();
                        k++;
                    }
                }
            }
        }

        private void Task2_Click(object sender, EventArgs e)
        {
            DataTabel.Rows.Clear();
            DataTabel.Columns[4].HeaderText = "Возраст";
            string[,] table = Conv("Данные.txt");
            table = AgeSort(table);
            int k = 0;
            for (int i = 0; i < table.GetLength(0); i++)
            {
                if (int.Parse(table[i, 7]) <= 3 && (2026 - int.Parse(table[i, 4]))<12)
                {
                    DataTabel.Rows.Add();
                    for (int j = 0; j < table.GetLength(1); j++)
                        DataTabel[j, k].Value = table[i, j];
                    DataTabel[4, k].Value = (2026 - int.Parse(table[i, 4])).ToString();
                    k++;
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
