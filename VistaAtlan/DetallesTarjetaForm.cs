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
using OfficeOpenXml;
using System.IO;
using System.Configuration;

namespace VistaAtlan
{
    public partial class DetallesTarjetaForm : Form
    {
        public DetallesTarjetaForm(int numCuenta)
        {
            try
            {
                InitializeComponent();
                LoadDetalle(numCuenta);
                LoadDetalleTransacciones(numCuenta);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private async void LoadDetalle(int numCuenta)
        {
            try
            {
                // Asegúrate de que AutoGenerateColumns esté en false
                DetalleTarjetaGrid.AutoGenerateColumns = false;
                TARJETAS_Service ts = new TARJETAS_Service();
                var detallesTarjeta = await ts.GetTarjetasDet(numCuenta);

                // Define las columnas manualmente
                DetalleTarjetaGrid.Columns.Clear(); // Limpia las columnas existentes para evitar duplicaciones

                DataGridViewColumn saldoDisponibleColumn = new DataGridViewTextBoxColumn();
                saldoDisponibleColumn.HeaderText = "SALDO DISPONIBLE";
                saldoDisponibleColumn.DataPropertyName = "SALDOGLOBALDISPO";
                saldoDisponibleColumn.Width = 150; // Establece el ancho de la columna
                DetalleTarjetaGrid.Columns.Add(saldoDisponibleColumn);

                DataGridViewColumn interesColumn = new DataGridViewTextBoxColumn();
                interesColumn.HeaderText = "INTERES";
                interesColumn.DataPropertyName = "INTERESCONFBONIF";
                interesColumn.Width = 150; // Establece el ancho de la columna
                DetalleTarjetaGrid.Columns.Add(interesColumn);

                DataGridViewColumn interesCuotaMinimaColumn = new DataGridViewTextBoxColumn();
                interesCuotaMinimaColumn.HeaderText = "INTERES CUOTA MINIMA";
                interesCuotaMinimaColumn.DataPropertyName = "INTERESCONFCUOMIN";
                interesCuotaMinimaColumn.Width = 200; // Establece el ancho de la columna
                DetalleTarjetaGrid.Columns.Add(interesCuotaMinimaColumn);

                DataGridViewColumn saldoGlobalColumn = new DataGridViewTextBoxColumn();
                saldoGlobalColumn.HeaderText = "SALDO GLOBAL";
                saldoGlobalColumn.DataPropertyName = "SALDOGLOBAL";
                saldoGlobalColumn.Width = 150; // Establece el ancho de la columna
                DetalleTarjetaGrid.Columns.Add(saldoGlobalColumn);

                DataGridViewColumn limiteTarjetaColumn = new DataGridViewTextBoxColumn();
                limiteTarjetaColumn.HeaderText = "LIMITE DE TARJETA";
                limiteTarjetaColumn.DataPropertyName = "LIMITEMAXACTUAL";
                limiteTarjetaColumn.Width = 150; // Establece el ancho de la columna
                DetalleTarjetaGrid.Columns.Add(limiteTarjetaColumn);

                DataGridViewColumn pagoMinimoColumn = new DataGridViewTextBoxColumn();
                pagoMinimoColumn.HeaderText = "PAGO MINIMO";
                pagoMinimoColumn.DataPropertyName = "PAGOMINIMO";
                pagoMinimoColumn.Width = 150; // Establece el ancho de la columna
                DetalleTarjetaGrid.Columns.Add(pagoMinimoColumn);


                DataGridViewColumn interesBonfiicable = new DataGridViewTextBoxColumn();
                interesBonfiicable.HeaderText = "INTERES BONIFICABLE";
                interesBonfiicable.DataPropertyName = "INTERESBONIFICABLE";
                interesBonfiicable.Width = 150; // Establece el ancho de la columna
                DetalleTarjetaGrid.Columns.Add(interesBonfiicable);

                // Asigna el origen de datos después de definir las columnas
                // Limpia las filas existentes en caso de que haya
                DetalleTarjetaGrid.Rows.Clear();

                // Agregar una fila al DataGridView y asignar los valores de las propiedades
                // del objeto correspondiente a DetalleTarjeta
                foreach (var detalle in detallesTarjeta)
                {
                    var interes = Math.Round(detalle.SALDOGLOBAL * (detalle.INTERESCONF / 100), 2);
                    var interescuo = Math.Round(detalle.SALDOGLOBAL * (detalle.INTERESCONFCUOMIN / 100), 2);
                    totalapagar.Text = "$ " + (interes + detalle.SALDOGLOBAL);
                    DetalleTarjetaGrid.Rows.Add(detalle.SALDOGLOBALDISPO, detalle.INTERESCONF, detalle.INTERESCONFCUOMIN, detalle.SALDOGLOBAL, detalle.LIMITEMAXACTUAL, interescuo, interes);
                }

                // Actualizar la vista del DataGridView
                DetalleTarjetaGrid.Refresh(); // o DetalleTarjetaGrid.Invalidate();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void LoadDetalleTransacciones(int numCuenta)
        {

            try
            {
                // Asegúrate de que AutoGenerateColumns esté en false
                DetalleTarjetaGrid.AutoGenerateColumns = false;
                TARJETAS_Service ts = new TARJETAS_Service();

                //obtenemos todas las transacciones
                var transacciones = await ts.GetTransacciones(numCuenta);

                // Define las columnas manualmente
                TransacGrid.Columns.Clear(); // Limpia las columnas existentes para evitar duplicaciones

                DataGridViewColumn transacNumColumn = new DataGridViewTextBoxColumn();
                transacNumColumn.HeaderText = "NUMERO DE TRANSACCION";
                transacNumColumn.DataPropertyName = "TRANSACNUM";
                transacNumColumn.Width = 150; // Establece el ancho de la columna
                TransacGrid.Columns.Add(transacNumColumn);

                DataGridViewColumn numCuentaColumn = new DataGridViewTextBoxColumn();
                numCuentaColumn.HeaderText = "NUMERO DE CUENTA";
                numCuentaColumn.DataPropertyName = "NUMCUENTA";
                numCuentaColumn.Width = 150; // Establece el ancho de la columna
                TransacGrid.Columns.Add(numCuentaColumn);

                DataGridViewColumn montoColumn = new DataGridViewTextBoxColumn();
                montoColumn.HeaderText = "MONTO";
                montoColumn.DataPropertyName = "MONTO";
                montoColumn.Width = 150; // Establece el ancho de la columna
                TransacGrid.Columns.Add(montoColumn);

                DataGridViewColumn descripcionColumn = new DataGridViewTextBoxColumn();
                descripcionColumn.HeaderText = "DESCRIPCION";
                descripcionColumn.DataPropertyName = "DESCRIPCION";
                descripcionColumn.Width = 200; // Establece el ancho de la columna
                TransacGrid.Columns.Add(descripcionColumn);

                DataGridViewColumn fechaTransacColumn = new DataGridViewTextBoxColumn();
                fechaTransacColumn.HeaderText = "FECHA DE TRANSACCION";
                fechaTransacColumn.DataPropertyName = "FECHATRANSAC";
                fechaTransacColumn.Width = 200; // Establece el ancho de la columna
                TransacGrid.Columns.Add(fechaTransacColumn);

                DataGridViewColumn credDebColumn = new DataGridViewTextBoxColumn();
                credDebColumn.HeaderText = "TIPO";
                credDebColumn.DataPropertyName = "CREDDEB";
                credDebColumn.Width = 150; // Establece el ancho de la columna
                TransacGrid.Columns.Add(credDebColumn);

                // Asigna el origen de datos después de definir las columnas
                // Limpia las filas existentes en caso de que haya
                TransacGrid.Rows.Clear();

                // Obtener el mes y el año actual
                int mesActual = DateTime.Now.Month;
                int añoActual = DateTime.Now.Year;

                // Calcular el mes anterior
                int mesAnterior = mesActual - 1;
                int añoAnterior = añoActual;

                if (mesAnterior == 0) // Si el mes anterior es diciembre, ajustar el año
                {
                    mesAnterior = 12;
                    añoAnterior--;
                }

                // Variables para sumar los montos de las transacciones
                decimal totalMesActual = 0;
                decimal totalMesAnterior = 0;
                // Iterar sobre las transacciones
                foreach (var transaccion in transacciones)
                {
                    // si es de tipo compra (1)
                    if (transaccion.CREDDEB == 1)
                    {
                        // Obtener el mes y el año de la transacción
                        int mesTransaccion = transaccion.FECHATRANSAC.Month;
                        int añoTransaccion = transaccion.FECHATRANSAC.Year;

                        // Verificar si la transacción es del mes actual
                        if (mesTransaccion == mesActual && añoTransaccion == añoActual)
                        {
                            totalMesActual += transaccion.MONTO;
                        }
                        // Verificar si la transacción es del mes anterior
                        else if (mesTransaccion == mesAnterior && añoTransaccion == añoAnterior)
                        {
                            totalMesAnterior += transaccion.MONTO;
                        }

                    }

                    string tipoTransaccion = transaccion.CREDDEB == 0 ? "PAGO" : "COMPRA";
                    //agregamos a nuestras vistas la informacion
                    TransacGrid.Rows.Add(transaccion.TRANSACNUM, transaccion.NUMCUENTA, transaccion.MONTO, transaccion.DESCRIPCION, transaccion.FECHATRANSAC, tipoTransaccion);
                }

                totalactual.Text = "$ " + totalMesActual.ToString();
                totalanterior.Text = "$ " + totalMesAnterior.ToString();
                // Actualizar la vista del DataGridView
                TransacGrid.Refresh();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void DetallesTarjetaForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                // Obtener los datos del DataGridView
                var data = new List<string[]>();
                foreach (DataGridViewRow row in TransacGrid.Rows)
                {
                    var rowData = new List<string>();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        rowData.Add(cell.Value?.ToString() ?? "");
                    }
                    data.Add(rowData.ToArray());
                }

                // Crear un nuevo archivo Excel
                var excelPackage = new ExcelPackage();
                var worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                // Añadir los encabezados de columna
                for (int i = 0; i < TransacGrid.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = TransacGrid.Columns[i].HeaderText;
                }

                // Llenar Excel con datos del DataGridView
                for (int i = 0; i < data.Count; i++)
                {
                    for (int j = 0; j < data[i].Length; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = data[i][j]; // Comenzamos desde la fila 2
                    }
                }

                // Ajustar el ancho de las columnas
                worksheet.Cells.AutoFitColumns();

                // Obtener la ruta del archivo desde la configuración
                var ruta = ConfigurationManager.AppSettings["RutaArchivo"];
                //obtenemos el nombre del archivo parametrizado en nuestro archivo de configuracion
                var nombreArchivo = ConfigurationManager.AppSettings["NombreXLS"];

                // Combinar la ruta y el nombre del archivo
                var rutaCompleta = Path.Combine(ruta, nombreArchivo);

                // Crear la carpeta si no existe
                Directory.CreateDirectory(ruta);

                // Guardar el archivo Excel
                File.WriteAllBytes(rutaCompleta, excelPackage.GetAsByteArray());

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
