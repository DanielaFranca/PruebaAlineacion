using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_técnica
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        #region "Patrón Singleton"
        private void Singleton(string pFormularioHijo)
        {
            bool encontrado = false;
            foreach (Form unFrm in this.MdiChildren)
            {
                if (unFrm.Name.Equals(pFormularioHijo))
                {
                    encontrado = true;
                    unFrm.Activate();
                }
            }
            if (!encontrado)
            {
                switch (pFormularioHijo)
                {
                    case "frmAlineacion":
                        Presentacion.frmAlineacion unFrmAlineacion = new Presentacion.frmAlineacion();
                        unFrmAlineacion.MdiParent = this;
                        unFrmAlineacion.Show();
                        break;
                    case "frmJugador":
                        Presentacion.frmJugador unFrmJugador = new Presentacion.frmJugador();
                        unFrmJugador.MdiParent = this;
                        unFrmJugador.Show();
                        break;
                }
            }
        }

        #endregion

        private void ingresarJugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombreFrm = "frmJugador";
            this.Singleton(nombreFrm);
        }

        private void ingresarAlineacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombreFrm = "frmAlineacion";
            this.Singleton(nombreFrm);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
