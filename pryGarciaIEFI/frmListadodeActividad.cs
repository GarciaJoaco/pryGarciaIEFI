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
    public partial class frmListadodeActividad : Form
    {
        OleDbConnection Conexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Gimnasio.accdb");
        OleDbConnection ConexionBD2 = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Gimnasio.accdb");
        OleDbConnection ConexionBD3 = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Gimnasio.accdb");
        OleDbCommand ComandoBD = new OleDbCommand();
        OleDbCommand ComandoBD2 = new OleDbCommand();
        OleDbCommand ComandoBD3 = new OleDbCommand();
        public frmListadodeActividad()
        {
            InitializeComponent();
        }

        private void frmListadodeActividad_Load(object sender, EventArgs e)
        {

            btnGenerarInforme.Enabled = false;
            btnImprimir.Enabled = false;
            txtPromedio.Enabled = false;
            txtSaldoMayor.Enabled = false;
            txtSaldoMenor.Enabled = false;
            txtTotal.Enabled = false;

            

            //Procedimiento para llenar combobox
            Conexion.Open();
            ComandoBD.CommandText = "Actividad";
            OleDbDataReader lectorActividad = ComandoBD.ExecuteReader();

            //Se recorre la tabla
            while (lectorActividad.Read())
            {
                cboActividad.Items.Add(lectorActividad.GetString(1));
            }
            Conexion.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Decimal SaldoMayor = 0;
            Decimal SaldoMenor = 0;
            Decimal Total = 0;
            int contador = 0;

            btnGenerarInforme.Enabled = true;
            btnImprimir.Enabled = true;
            dgvListarActividad.Rows.Clear();
            if (cboActividad.SelectedIndex != -1)
            {
                //Se a bre conexion para obtener barrio
                Conexion.Open();
                ComandoBD.Connection = Conexion;
                ComandoBD.CommandType = CommandType.TableDirect;
                ComandoBD.CommandText = "Actividad";
                OleDbDataReader lector = ComandoBD.ExecuteReader();

                while (lector.Read()) //Se recorre el barrio
                {
                    if (lector.GetString(1) == cboActividad.Text) //Si es igual
                    {

                        ConexionBD2.Open();
                        ComandoBD2.Connection = ConexionBD2;
                        ComandoBD2.CommandType = CommandType.TableDirect;
                        ComandoBD2.CommandText = "Socio";
                        OleDbDataReader lector2 = ComandoBD2.ExecuteReader();

                        while (lector2.Read()) //Se recorre la base de datos SOCIOS 
                        {
                            if (lector2.GetInt32(4) == lector.GetInt32(0)) //SI el numero de ID_Barrio es el mismo
                            {
                                //Se asignan datos a las variables
                                if (SaldoMenor == 0)
                                {
                                    SaldoMenor = lector2.GetDecimal(5);
                                }
                                contador++;
                                if (SaldoMayor < lector2.GetDecimal(5))
                                {
                                    SaldoMayor = lector2.GetDecimal(5);
                                }
                                if (SaldoMenor > lector2.GetDecimal(5))
                                {
                                    SaldoMenor = lector2.GetDecimal(5);
                                }
                                Total = Total + lector2.GetDecimal(5);

                                ConexionBD3.Open();
                                ComandoBD3.Connection = ConexionBD3;
                                ComandoBD3.CommandType = CommandType.TableDirect;
                                ComandoBD3.CommandText = "Barrio";
                                OleDbDataReader lectorBarrio = ComandoBD3.ExecuteReader();

                                while (lectorBarrio.Read() && lectorBarrio.GetInt32(0) != lector2.GetInt32(3))
                                {
                                }
                                dgvListarActividad.Rows.Add(lector2.GetInt32(0), lector2.GetString(1), lector2.GetString(2) //Se agrega a la grilla
                                , lectorBarrio.GetString(1), lector.GetString(1), lector2.GetDecimal(5));
                                ConexionBD3.Close();
                            }
                        }
                    }
                }
                txtPromedio.Text = (Total / contador).ToString("0.00");
                txtSaldoMayor.Text = SaldoMayor.ToString();
                txtSaldoMenor.Text = SaldoMenor.ToString();
                txtTotal.Text = Total.ToString();
                ConexionBD2.Close();
                Conexion.Close();
            }
            else
            {
                MessageBox.Show("Ingrese una Actividad");
            }
        }
    }
}
