using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen1
{
    public partial class Form1 : Form
    {
        double cantidad = 200000;
        double interesMensual = 1.5;
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtCantidad.Text = cantidad.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] meses = {"NINGUNO","ENERO", "FEBRERO", "MARZO",
                              "ABRIL", "MAYO", "JUNIO",
                              "JULIO", "AGOSTO", "SEPTIEMBRE",
                              "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"
                             };
            lbMeses.Items.Clear();

            int periodoTiempo = dateTimePicker2.Value.Month;
            double valorGanado = (cantidad * interesMensual) * periodoTiempo;

            if (dateTimePicker1.Value.Month < dateTimePicker2.Value.Month)
            {
                for (int x = Convert.ToInt32(dateTimePicker1.Value.Month); x <= Convert.ToInt32(dateTimePicker2.Value.Month); x++)
                {
                    lbMeses.Items.Add(meses[x].ToString() + "-----------" + valorGanado);
                }
            }
            else
            {
                for (int x = Convert.ToInt32(dateTimePicker1.Value.Month); x <= 12; x++)
                {
                    lbMeses.Items.Add(meses[x].ToString() + "-----------" + valorGanado);
                }
                for (int x = 1; x <= Convert.ToInt32(dateTimePicker2.Value.Month); x++)
                {
                    lbMeses.Items.Add(meses[x].ToString() + "-----------" + valorGanado);
                }
            }
        }
    }
}
