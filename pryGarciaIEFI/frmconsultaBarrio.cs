using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace pryGarciaIEFI
{
    public partial class frmconsultaBarrio : Form
    {
        OleDbConnection Conexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Gimnasio.accdb");
        OleDbConnection ConexionBD2 = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Gimnasio.accdb");
        OleDbConnection ConexionBD3 = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Gimnasio.accdb");
        OleDbCommand ComandoBD = new OleDbCommand();
        OleDbCommand ComandoBD2 = new OleDbCommand();
        OleDbCommand ComandoBD3 = new OleDbCommand();
        public frmconsultaBarrio()
        {
            InitializeComponent();
        }

        private void frmconsultaBarrio_Load(object sender, EventArgs e)
        {

        }

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font Letra = new Font("Arial", 9);
            Font Titulo = new Font("Arial", 15);
            int linea = 200;
            int f = 0;

            //Se escribe el titlo
            e.Graphics.DrawString("Listado de socios de: " + cboBarrio.Text + "", Titulo, Brushes.Black, 100, 50);
            //Se escriben el nombre de las columnas
            e.Graphics.DrawString("DNI", Letra, Brushes.Black, 100, 150);
            e.Graphics.DrawString("Nombre y Apellido", Letra, Brushes.Black, 150, 150);
            e.Graphics.DrawString("Direccion", Letra, Brushes.Black, 300, 150);
            e.Graphics.DrawString("Barrio", Letra, Brushes.Black, 470, 150);
            e.Graphics.DrawString("Actividad", Letra, Brushes.Black, 600, 150);
            e.Graphics.DrawString("Saldo", Letra, Brushes.Black, 700, 150);

            //Se escriben los datos de las filas
            while (f < dgvListarBarrio.Rows.Count - 1)
            {
                e.Graphics.DrawString(dgvListarBarrio.Rows[f].Cells[0].Value.ToString(), Letra, Brushes.Black, 100, linea);
                e.Graphics.DrawString(dgvListarBarrio.Rows[f].Cells[1].Value.ToString(), Letra, Brushes.Black, 150, linea);
                e.Graphics.DrawString(dgvListarBarrio.Rows[f].Cells[2].Value.ToString(), Letra, Brushes.Black, 300, linea);
                e.Graphics.DrawString(dgvListarBarrio.Rows[f].Cells[3].Value.ToString(), Letra, Brushes.Black, 470, linea);
                e.Graphics.DrawString(dgvListarBarrio.Rows[f].Cells[4].Value.ToString(), Letra, Brushes.Black, 600, linea);
                e.Graphics.DrawString(dgvListarBarrio.Rows[f].Cells[5].Value.ToString(), Letra, Brushes.Black, 700, linea);
                linea = linea + 15;
                f++;
            }
            //Se escribe la información
            linea = linea + 20;
            e.Graphics.DrawString("Saldo Mayor: " + txtSaldoMayor.Text + "", Letra, Brushes.Black, 100, linea);
            e.Graphics.DrawString("Saldo Menor: " + txtSaldoMenor.Text + "", Letra, Brushes.Black, 250, linea);
            e.Graphics.DrawString("Promedio: " + txtPromedio.Text + "", Letra, Brushes.Black, 400, linea);
            e.Graphics.DrawString("Total: " + txtTotal.Text + "", Letra, Brushes.Black, 550, linea);
            MessageBox.Show("Lista impresa con exito!");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Le asignamos la impresora que selecciona la ventana
            prtVentana.ShowDialog();
            prtDocumento.PrinterSettings = prtVentana.PrinterSettings; 
            prtDocumento.Print();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            //Se ejecuta la conexion y la tabla de actividad
            ConexionBD3.Open();
            ComandoBD3.Connection = ConexionBD3;
            ComandoBD3.CommandType = CommandType.TableDirect;
            ComandoBD3.CommandText = "Barrio";
            OleDbDataReader lector3 = ComandoBD3.ExecuteReader();

            //Se crea un SW para crear el archivo
            StreamWriter swListado = new StreamWriter("./Informe de clientes por barrio.csv", false, Encoding.UTF8);
            swListado.WriteLine("Listado de clientes \n");
            swListado.WriteLine("DNI,Nombre,Direccion,Barrio,Actividad,Saldo");

            //Procedimiento para comprobar el barrio que se selecciono
            while (lector3.Read() && lector3.GetString(1) != cboBarrio.Text)
            {
            }

            //Se abre la conexion para buscar los datos requeridos
            Conexion.Open();
            ComandoBD.Connection = Conexion;
            ComandoBD.CommandType = CommandType.TableDirect;
            ComandoBD.CommandText = "Socio";
            OleDbDataReader lector = ComandoBD.ExecuteReader();
            while (lector.Read())
            {
                if (lector.GetInt32(3) == lector3.GetInt32(0))
                {
                    //Se abre otra conexion para poner el detalle de la actividad en el archivo
                    ConexionBD2.Open();
                    ComandoBD2.Connection = ConexionBD2;
                    ComandoBD2.CommandType = CommandType.TableDirect;
                    ComandoBD2.CommandText = "Actividad";
                    OleDbDataReader lector2 = ComandoBD2.ExecuteReader();
                    while (lector2.Read() && lector2.GetInt32(0) != lector.GetInt32(4))
                    {
                    }
                    swListado.Write(lector.GetInt32(0));
                    swListado.Write(",");
                    swListado.Write(lector.GetString(1));
                    swListado.Write(",");
                    swListado.Write(lector.GetString(2));
                    swListado.Write(",");
                    swListado.Write(lector3.GetString(1));
                    swListado.Write(",");
                    swListado.Write(lector2.GetString(1));
                    swListado.Write(",");
                    swListado.Write(lector.GetDecimal(5));
                    swListado.Write("\n");
                    ConexionBD2.Close();
                }
            }
            MessageBox.Show("Informe generado con exito!");
            ConexionBD3.Close();
            Conexion.Close();
            swListado.Close();
        }

        private void lblBarrio_Click(object sender, EventArgs e)
        {

        }
    }
}

