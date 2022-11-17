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

namespace pryGarciaIEFI
{
    public partial class frmConsultarSocios : Form
    {
        OleDbConnection Conexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Gimnasio.accdb");
        OleDbConnection ConexionBD2 = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Gimnasio.accdb");
        OleDbCommand ComandoBD = new OleDbCommand();
        OleDbCommand ComandoBD2 = new OleDbCommand();
        public frmConsultarSocios()
        {
            InitializeComponent();
        }

        private void frmConsultarSocios_Load(object sender, EventArgs e)
        {

        }

        private void lblMostrarSaldo_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            if (txtDNI.Text != "")
            {
                try
                {
                    Conexion.Open();

                    ComandoBD.Connection = Conexion;
                    ComandoBD.CommandType = CommandType.TableDirect;
                    ComandoBD.CommandText = "Socio";
                    OleDbDataReader lector = ComandoBD.ExecuteReader();

                    while (lector.Read())
                    {
                        if (lector.GetInt32(0) == Convert.ToInt32(txtDNI.Text))
                        {
                            bandera = true;
                            lblMostrarNombre.Text = lector.GetString(1);
                            lblMostrarDireccion.Text = lector.GetString(2);
                            ConexionBD2.Open();
                            ComandoBD2.Connection = ConexionBD2;
                            ComandoBD2.CommandType = CommandType.TableDirect;
                            ComandoBD2.CommandText = "Barrio";
                            OleDbDataReader lector2 = ComandoBD2.ExecuteReader();
                            while (lector2.Read())
                            {
                                if (lector2.GetInt32(0) == lector.GetInt32(3))
                                {
                                    lblMostrarBarrio.Text = lector2.GetString(1);
                                }
                            }
                            ConexionBD2.Close();
                            ConexionBD2.Open();
                            ComandoBD2.Connection = ConexionBD2;
                            ComandoBD2.CommandType = CommandType.TableDirect;
                            ComandoBD2.CommandText = "Actividad";
                            OleDbDataReader lector3 = ComandoBD2.ExecuteReader();
                            while (lector3.Read())
                            {
                                if (lector3.GetInt32(0) == lector.GetInt32(4))
                                {
                                    lblMostrarACtividad.Text = lector3.GetString(1);
                                }
                            }
                            ConexionBD2.Close();
                            lblMostrarSaldo.Text = Convert.ToString(lector.GetDecimal(5));
                        }

                    }
                    if (bandera == false)
                    {

                        MessageBox.Show("Ese DNI no esta registrado en la base de datos");

                    }
                    Conexion.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
            else
            {
                MessageBox.Show("Ingrese un Numero de DNI");
            }
        }
    }
}   
