using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class calculator : Form
    {
        public calculator()
        {
            //textBox3.Text = 0.ToString();
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Text = "00:00:00";
            dateTimePicker2.Text = "00:00:00";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           // dateTimePicker1.Format = DateTimePickerFormat.Time;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime momentInitial = dateTimePicker1.Value; // momentul inițial selectat din controlul DateTimePicker1
            DateTime momentFinal = dateTimePicker2.Value; // momentul final selectat din controlul DateTimePicker2

            TimeSpan diferenta = momentFinal - momentInitial; // calculează diferența de timp

            double numarOre = Math.Abs(diferenta.TotalHours); // calculează numărul de ore și transformă valoarea în pozitiv

            int vanzare = Convert.ToInt32(textBox3.Text);
            double vanzareSalariu = (double)3 / 100 * vanzare;






            MessageBox.Show("Numărul de ore dintre cele două momente este: " + numarOre+
                "\nVanzarile de astazi : "+vanzare+
                "\n\n\n\nAstfel Salariul acumulat astazi este  "+(vanzareSalariu+numarOre*30)+
                "\n\n Din care "+vanzareSalariu+" din vanzari si"+" "+(numarOre*30)+ " "+ "din nr de ore lucrate a cate 30 lei");

            
        }
    }
}
