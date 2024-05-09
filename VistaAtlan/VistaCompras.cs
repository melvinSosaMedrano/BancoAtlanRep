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
    public partial class VistaCompras : Form
    {
        public VistaCompras()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TRANSACCIONBD cn = new TRANSACCIONBD();
                decimal monto;
                if (decimal.TryParse(montocompra.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out monto))
                {
                    cn.MONTO = monto;
                }
                cn.NUMTARJETA = int.Parse(numerotarjeta.Text);
                cn.DESCRIPCION = descripcioncompra.Text;
                cn.TIPO = 1;
                TARJETAS_Service tj = new TARJETAS_Service();
                var result = await tj.RealizarCompra(cn);
                if (result.codigo == 0)
                {

                    resultadocompra.Text = result.mensaje;
                    numerotarjeta.Text = "";
                    montocompra.Text = "";
                    descripcioncompra.Text = "";
                }
                else
                {
                    resultadocompra.Text = result.mensaje;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes clientes = new Clientes();
            clientes.ShowDialog();
        }
    }
}
