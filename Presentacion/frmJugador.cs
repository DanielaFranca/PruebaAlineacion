using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_técnica.Presentacion
{
    public partial class frmJugador : Form
    {
        public frmJugador()
        {
            InitializeComponent();
        }

        #region "ABM"
        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (this.FaltanDatos())
            {
                this.lblMensajes.Text = "Faltan datos";
                this.Limpiar();
            }
            else
            {

                Dominio.Controladora unaControladora = new Dominio.Controladora();
                short nro = short.Parse(this.txtNro.Text);

                Dominio.Jugador unJugador = unaControladora.BuscarJugador(nro);

                if (unJugador == null)
                {
                    string Nombre = this.txtNombre.Text;
                    string Apellido = this.txtApellido.Text;
                    if (rdbDelantero.Checked)
                    {
                        string Posicion = "Delantero";
                        Dominio.Jugador nuevoJugador = new Dominio.Jugador(nro, Nombre, Apellido, Posicion);
                        if (unaControladora.AltaJugador(nuevoJugador))
                        {
                            this.Limpiar();
                            this.ListarJugadores();
                            this.lblMensajes.Text = "El jugador fue ingresado correctamente.";
                        }
                    }
                    else if (rdbMedio.Checked)
                    {
                        string Posicion = "Mediocampo";
                        Dominio.Jugador nuevoJugador = new Dominio.Jugador(nro, Nombre, Apellido, Posicion);
                        if (unaControladora.AltaJugador(nuevoJugador))
                        {
                            this.Limpiar();
                            this.ListarJugadores();
                            this.lblMensajes.Text = "El jugador fue ingresado correctamente.";
                        }
                    }
                    else if (rdbDefensa.Checked)
                    {
                        string Posicion = "Defensa";
                        Dominio.Jugador nuevoJugador = new Dominio.Jugador(nro, Nombre, Apellido, Posicion);
                        if (unaControladora.AltaJugador(nuevoJugador))
                        {
                            this.Limpiar();
                            this.ListarJugadores();
                            this.lblMensajes.Text = "El jugador fue ingresado correctamente.";
                        }
                    }
                    else if (rdbGolero.Checked)
                    {
                        string Posicion = "Golero";
                        Dominio.Jugador nuevoJugador = new Dominio.Jugador(nro, Nombre, Apellido, Posicion);
                        if (unaControladora.AltaJugador(nuevoJugador))
                        {
                            this.Limpiar();
                            this.ListarJugadores();
                            this.lblMensajes.Text = "El jugador fue ingresado correctamente.";
                        }
                    }
                    else if (rdbDT.Checked)
                    {
                        string Posicion = "DT";
                        Dominio.Jugador nuevoJugador = new Dominio.Jugador(nro, Nombre, Apellido, Posicion);
                        if (unaControladora.AltaJugador(nuevoJugador))
                        {
                            this.Limpiar();
                            this.ListarJugadores();
                            this.lblMensajes.Text = "El jugador fue ingresado correctamente.";
                        }
                    }
                    else if (rdbAT.Checked)
                    {
                        string Posicion = "AT";
                        Dominio.Jugador nuevoJugador = new Dominio.Jugador(nro, Nombre, Apellido, Posicion);
                        if (unaControladora.AltaJugador(nuevoJugador))
                        {
                            this.Limpiar();
                            this.ListarJugadores();
                            this.lblMensajes.Text = "El jugador fue ingresado correctamente.";
                        }
                    }
                    else if (rdbMedico.Checked)
                    {
                        string Posicion = "Médico";
                        Dominio.Jugador nuevoJugador = new Dominio.Jugador(nro, Nombre, Apellido, Posicion);
                        if (unaControladora.AltaJugador(nuevoJugador))
                        {
                            this.Limpiar();
                            this.ListarJugadores();
                            this.lblMensajes.Text = "El jugador fue ingresado correctamente.";
                        }
                    }

                }
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Dominio.Controladora unaControladora = new Dominio.Controladora();
            short nro = short.Parse(this.txtNro.Text);
            Dominio.Jugador unJugador = unaControladora.BuscarJugador(nro);
            if (unJugador != null)
            {
                if (unaControladora.BajaJugador(nro))
                {
                    this.Limpiar();
                    this.ListarJugadores();
                    this.lblMensajes.Text = "El jugador fue eliminado correctamente";
                }
                else
                {
                    this.Limpiar();
                    this.lblMensajes.Text = "ERROR: el jugador no fue eliminado";
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Dominio.Controladora unaControladora = new Dominio.Controladora();
            short nro = short.Parse(this.txtNro.Text);
            Dominio.Jugador unJugador = unaControladora.BuscarJugador(nro);
            if (unJugador != null)
            {
                nro = short.Parse(this.txtNro.Text);
                string Nombre = this.txtNombre.Text;
                string Apellido = this.txtApellido.Text;

                if (rdbDelantero.Checked)
                {
                    string Posicion = "Delantero";
                    if (unaControladora.ModificarJugador(nro, Nombre, Apellido, Posicion))
                    {
                        this.Limpiar();
                        this.lblMensajes.Text = "Jugador modificado correctamente";
                        this.ListarJugadores();
                    }
                }
                else if (rdbMedio.Checked)
                {
                    string Posicion = "Mediocampo";
                    if (unaControladora.ModificarJugador(nro, Nombre, Apellido, Posicion))
                    {
                        this.Limpiar();
                        this.lblMensajes.Text = "Jugador modificado correctamente";
                        this.ListarJugadores();
                    }
                }
                else if (rdbDefensa.Checked)
                {
                    string Posicion = "Defensa";
                    if (unaControladora.ModificarJugador(nro, Nombre, Apellido, Posicion))
                    {
                        this.Limpiar();
                        this.lblMensajes.Text = "Jugador modificado correctamente";
                        this.ListarJugadores();
                    }
                }
                else if (rdbGolero.Checked)
                {
                    string Posicion = "Golero";
                    if (unaControladora.ModificarJugador(nro, Nombre, Apellido, Posicion))
                    {
                        this.Limpiar();
                        this.lblMensajes.Text = "Jugador modificado correctamente";
                        this.ListarJugadores();
                    }
                }
                else if (rdbDT.Checked)
                {
                    string Posicion = "DT";
                    if (unaControladora.ModificarJugador(nro, Nombre, Apellido, Posicion))
                    {
                        this.Limpiar();
                        this.lblMensajes.Text = "Jugador modificado correctamente";
                        this.ListarJugadores();
                    }
                }
                else if (rdbAT.Checked)
                {
                    string Posicion = "AT";
                    if (unaControladora.ModificarJugador(nro, Nombre, Apellido, Posicion))
                    {
                        this.Limpiar();
                        this.lblMensajes.Text = "Jugador modificado correctamente";
                        this.ListarJugadores();
                    }
                }
                else if (rdbMedico.Checked)
                {
                    string Posicion = "Médico";
                    if (unaControladora.ModificarJugador(nro, Nombre, Apellido, Posicion))
                    {
                        this.Limpiar();
                        this.lblMensajes.Text = "Jugador modificado correctamente";
                        this.ListarJugadores();
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        #endregion
        #region "Métodos auxiliares"
        private bool FaltanDatos()
        {
            if (this.txtNro.Text == "" || this.txtNombre.Text == "" || this.txtApellido.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Limpiar()
        {
            this.txtNro.Clear();
            this.txtNombre.Clear();
            this.txtApellido.Clear();
            this.txtPosicion.Clear();
            this.txtNro.Focus();
        }
        private void ListarJugadores()
        {
            Dominio.Controladora unaControladora = new Dominio.Controladora();

            this.lstJugadores.DataSource = null;
            this.lstJugadores.DataSource = unaControladora.ListaJugadores();
        }
        #endregion

        private void lstJugadores_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstJugadores.SelectedIndex > -1)
            {
                string linea = this.lstJugadores.SelectedItem.ToString();
                string[] partes = linea.Split(' ');

                short Nro = short.Parse(partes[0]);
                this.txtNro.Text = Nro.ToString();

                string Nombre = partes[1];
                this.txtNombre.Text = Nombre;

                string Apellido = partes[2];
                this.txtApellido.Text = Apellido;

                string Posicion = partes[3];
                this.txtPosicion.Visible = true;
                this.txtPosicion.Text = Posicion;
            }
            else
            {
                this.lblMensajes.Text = "Debe seleccionar un jugador";
            }
        }
    }
}
