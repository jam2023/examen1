using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace examen1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private async void button1_Click_1(object sender, EventArgs e)
           
        {
            decimal precio1, precio2, subtotal,descuento,isv;
            int cantidad, cantidad2;

            if (producto1textBox.Text == "" || producto2textBox.Text == "" || precio1textBox.Text == "" ||
                precio2textBox.Text == "" || cantidad1textBox.Text == "" || cantidad2textBox.Text == "") ;
            {
                MessageBox.Show("error complete los espacio en blanco", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                precio1 = Convert.ToDecimal(precio1textBox.Text);
                precio2 = Convert.ToDecimal(precio2textBox.Text);
                cantidad = Convert.ToInt32(precio1textBox.Text);
                cantidad2 = Convert.ToInt32(precio1textBox.Text);

                subtotaltextBox.Text= ((precio1 * cantidad)+ (precio2 * cantidad2)).ToString();
                documentotextBox.Text = await DescuentoAsync(Convert.ToDecimal(subtotaltextBox.Text, Convert.ToDecimal(porcentajetextBox.Text));

                subtotal = Convert.ToDecimal(subtotaltextBox.Text);
                descuento = Convert.ToDecimal(documentotextBox);
                decimal porcentaje = Convert.ToDecimal(porcentajetextBox.Text);

                totalpagartextBox.Text= ((subtotal - descuento)* porcentaje).ToString();
                isv = Convert.ToDecimal(impuestotextBox.Text);

                totalpagartextBox.Text =(subtotal- descuento+ isv).ToString();
            }
        }
        private async Task<string> DescuentoAsync(decimal subtotal, decimal porcentaje)
        {
            decimal descuento = await Task.Run(() =>
            {
                return (subtotal * porcentaje);
            });
            return descuento.ToString();
        }


    }
}
