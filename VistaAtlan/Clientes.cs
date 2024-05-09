using AtlanProject.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaAtlan
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private async void ClientesGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Obtiene el valor del código de cliente de la fila seleccionada
                    int codigoCliente = Convert.ToInt32(ClientesGrid.Rows[e.RowIndex].Cells[1].Value); // Obtiene el valor de la celda en el índice de columna 1


                    // Llama al método Get de la clase TARJETAS_Service con el código del cliente
                    TARJETAS_Service ts = new TARJETAS_Service();
                    var tarjetas = await ts.GetTarjetas(codigoCliente);

                    TarjetasGrid.AutoGenerateColumns = false;

                    // Define las columnas manualmente
                    TarjetasGrid.Columns.Clear(); // Limpia las columnas existentes para evitar duplicaciones

                    // Columna NUMCUENTA
                    DataGridViewColumn numCuentaColumn = new DataGridViewTextBoxColumn();
                    numCuentaColumn.HeaderText = "NUMERO DE CUENTA";
                    numCuentaColumn.DataPropertyName = "NUMCUENTA"; // Nombre de la propiedad en la clase TBL_TARJETA
                    numCuentaColumn.Width = 200; // Establece el ancho de la columna
                    TarjetasGrid.Columns.Add(numCuentaColumn);

                    // Columna NUMTARJETA
                    DataGridViewColumn numTarjetaColumn = new DataGridViewTextBoxColumn();
                    numTarjetaColumn.HeaderText = "NUMERO DE TARJETA";
                    numTarjetaColumn.DataPropertyName = "NUMTARJETA"; // Nombre de la propiedad en la clase TBL_TARJETA
                    numTarjetaColumn.Width = 200; // Establece el ancho de la columna
                    TarjetasGrid.Columns.Add(numTarjetaColumn);

                    // Asigna el origen de datos después de definir las columnas
                    // Limpia las filas existentes en caso de que haya
                    TarjetasGrid.Rows.Clear();

                    // Asegúrate de tener una lista de tarjetas llamada "result" o ajusta esta parte según corresponda
                    foreach (var tarjeta in tarjetas)
                    {
                        TarjetasGrid.Rows.Add(tarjeta.NUMCUENTA, tarjeta.NUMTARJETA);
                    }

                    // Actualiza la vista del DataGridView
                    TarjetasGrid.Refresh(); // o TarjetasGrid.Invalidate();
                }
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        private void TarjetasGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Obtener los datos de la fila seleccionada
                    int numCuenta = int.Parse(TarjetasGrid.Rows[e.RowIndex].Cells[0].Value.ToString());

                    // Crear una instancia del nuevo formulario y pasar los datos
                    DetallesTarjetaForm detallesForm = new DetallesTarjetaForm(numCuenta);
                    detallesForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private async void BUSCAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (TIPOFILTRO.Text == "TODOS")
                {
                    CLIENTE_Service ns = new CLIENTE_Service();
                    var result = await ns.GetClientes();

                    // Asegúrate de que AutoGenerateColumns esté en false
                    ClientesGrid.AutoGenerateColumns = false;

                    // Define las columnas manualmente (reemplaza 'Propiedad' con las propiedades reales de tu clase TBL_CLIENTE)
                    ClientesGrid.Columns.Clear(); // Limpia las columnas existentes para evitar duplicaciones
                    DataGridViewColumn codAgenciaColumn = new DataGridViewTextBoxColumn();
                    codAgenciaColumn.HeaderText = "AGENCIA";
                    codAgenciaColumn.DataPropertyName = "CODAGENCIA"; // Nombre de la propiedad en la clase TBL_CLIENTE
                    codAgenciaColumn.Width = 150; // Establece el ancho de la columna
                    ClientesGrid.Columns.Add(codAgenciaColumn);

                    DataGridViewColumn codClienteColumn = new DataGridViewTextBoxColumn();
                    codClienteColumn.HeaderText = "CODIGO DE CLIENTE";
                    codClienteColumn.DataPropertyName = "CODCLIENTE"; // Nombre de la propiedad en la clase TBL_CLIENTE
                    codClienteColumn.Width = 150; // Establece el ancho de la columna
                    ClientesGrid.Columns.Add(codClienteColumn);

                    DataGridViewColumn nombreClienteColumn = new DataGridViewTextBoxColumn();
                    nombreClienteColumn.HeaderText = "NOMBRE DE CLIENTE";
                    nombreClienteColumn.DataPropertyName = "NOMBRECLIENTE"; // Nombre de la propiedad en la clase TBL_CLIENTE
                    nombreClienteColumn.Width = 300; // Establece el ancho de la columna
                    ClientesGrid.Columns.Add(nombreClienteColumn);

                    // Asigna el origen de datos después de definir las columnas
                    // Limpia las filas existentes en caso de que haya
                    ClientesGrid.Rows.Clear();

                    // Agregar una fila al DataGridView y asignar los valores de las propiedades del cliente
                    foreach (var cliente in result)
                    {

                        ClientesGrid.Rows.Add(cliente.CODAGENCIA, cliente.CODCLIENTE, cliente.NOMBRECLIENTE);
                    }

                    // Actualizar la vista del DataGridView
                    ClientesGrid.Refresh(); // o ClientesGrid.Invalidate();
                }
                if (TIPOFILTRO.Text == "CODIGO DE CLIENTE")
                {
                    CLIENTE_Service ns = new CLIENTE_Service();
                    if (FILTRO.Text == "")
                    {
                        FILTRO.Text = "1";
                    }
                    var result = await ns.GetCliente(int.Parse(FILTRO.Text));

                    // Asegúrate de que AutoGenerateColumns esté en false
                    ClientesGrid.AutoGenerateColumns = false;

                    // Define las columnas manualmente (reemplaza 'Propiedad' con las propiedades reales de tu clase TBL_CLIENTE)
                    ClientesGrid.Columns.Clear(); // Limpia las columnas existentes para evitar duplicaciones
                    DataGridViewColumn codAgenciaColumn = new DataGridViewTextBoxColumn();
                    codAgenciaColumn.HeaderText = "AGENCIA";
                    codAgenciaColumn.DataPropertyName = "CODAGENCIA"; // Nombre de la propiedad en la clase TBL_CLIENTE
                    codAgenciaColumn.Width = 150; // Establece el ancho de la columna
                    ClientesGrid.Columns.Add(codAgenciaColumn);

                    DataGridViewColumn codClienteColumn = new DataGridViewTextBoxColumn();
                    codClienteColumn.HeaderText = "CODIGO DE CLIENTE";
                    codClienteColumn.DataPropertyName = "CODCLIENTE"; // Nombre de la propiedad en la clase TBL_CLIENTE
                    codClienteColumn.Width = 150; // Establece el ancho de la columna
                    ClientesGrid.Columns.Add(codClienteColumn);

                    DataGridViewColumn nombreClienteColumn = new DataGridViewTextBoxColumn();
                    nombreClienteColumn.HeaderText = "NOMBRE DE CLIENTE";
                    nombreClienteColumn.DataPropertyName = "NOMBRECLIENTE"; // Nombre de la propiedad en la clase TBL_CLIENTE
                    nombreClienteColumn.Width = 200; // Establece el ancho de la columna
                    ClientesGrid.Columns.Add(nombreClienteColumn);

                    // Asigna el origen de datos después de definir las columnas
                    // Limpia las filas existentes en caso de que haya
                    ClientesGrid.Rows.Clear();

                    // Agregar una fila al DataGridView y asignar los valores de las propiedades del cliente
                    ClientesGrid.Rows.Add(result.CODAGENCIA, result.CODCLIENTE, result.NOMBRECLIENTE);

                    // Actualizar la vista del DataGridView
                    ClientesGrid.Refresh(); // o ClientesGrid.Invalidate();
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
            VistaCompras vistaCompras = new VistaCompras();
            vistaCompras.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VistaPagos vistapagos = new VistaPagos();
            vistapagos.ShowDialog();
        }
    }
}
