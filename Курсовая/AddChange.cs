using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class AddChange : Form
    {
        public AddChange()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string data = "Данные.txt";
                int lineCount = System.IO.File.ReadLines(data).Count();
                string[] add = new string[8];
                add[0] = Convert.ToString(lineCount + 1);

                
               
                string FIO = FIOadd.Text;
                string[] fio = FIO.Split(" ".ToCharArray());
                add[1]=fio[0];
                add[2]=fio[1];
                add[3]=fio[2];
                int year = int.Parse(yearadd.Text);
                add[4]=year.ToString();
                string country = CountryList.Text;
                add[5] = country;
                
                string Instrument = InstrumentList.Text;
                add[6] = Instrument;
                int place = int.Parse(placelist.Text);
                add[7] = place.ToString();
                string lite = Environment.NewLine + string.Join("_", add);
                System.IO.File.AppendAllText(data, lite);

            }
            catch (Exception ex)
            {
                DialogResult a = MessageBox.Show("Вводите данные правильно", "Неверный ввод данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            basicadm basicadm = new basicadm();
            basicadm.Show();
            this.Close();
        }
    }
}
