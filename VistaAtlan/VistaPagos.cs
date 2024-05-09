using AtlanProject.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VistaAtlan.Models;

namespace VistaAtlan
{
    public partial class VistaPagos : Form
    {
        public VistaPagos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes clientes = new Clientes();
            clientes.ShowDialog();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TRANSACCIONBD cn = new TRANSACCIONBD();
                decimal monto;
                if (decimal.TryParse(montopago.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out monto))
                {
                    cn.MONTO = monto;
                }
                cn.NUMTARJETA = int.Parse(numerotarjeta.Text);
                cn.DESCRIPCION = descripcionpago.Text;
                cn.TIPO = 0;
                TARJETAS_Service tj = new TARJETAS_Service();
                var result = await tj.RealizarCompra(cn);
                if (result.codigo == 0)
                {

                    resultadopago.Text = result.mensaje;
                    numerotarjeta.Text = "";
                    montopago.Text = "";
                    descripcionpago.Text = "";
                }
                else
                {
                    resultadopago.Text = result.mensaje;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
