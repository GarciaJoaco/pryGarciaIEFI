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
    public partial class frmMenu : Form
    {
        OleDbConnection Conexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BDclientes.accdb");
        OleDbCommand ComandoBD = new OleDbCommand();



        public frmMenu()
        {
            InitializeComponent();
        }

        private void barrioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgrgarSocios frmAgrgarSocios = new frmAgrgarSocios();
            frmAgrgarSocios.ShowDialog();
        }

        private void consultarSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarSocios frmConsultarSocios = new frmConsultarSocios();
            frmConsultarSocios.ShowDialog();

        }

        private void modificarOEliminarSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgrgarSocios frmAgrgarSocios = new frmAgrgarSocios();
            frmAgrgarSocios.ShowDialog();
        }

        private void listadoDeSociosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListadodeSocios frmListadodeSocios = new frmListadodeSocios();
            frmListadodeSocios.ShowDialog();
        }

        private void listadoDeSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadodeSaldos frmListadodeSaldos = new frmListadodeSaldos();   
            frmListadodeSaldos.ShowDialog();
        }

        private void listadoDeSociosPorActividadOBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void actividadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListadodeActividad frmListadodeActividad = new frmListadodeActividad();  
            frmListadodeActividad.ShowDialog();

        }

        private void barrioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmconsultaBarrio frmconsultaBarrio = new frmconsultaBarrio();
            frmconsultaBarrio.ShowDialog();

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
