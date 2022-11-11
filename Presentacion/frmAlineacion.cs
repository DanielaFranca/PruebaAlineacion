using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks.Printing;

namespace Prueba_técnica.Presentacion
{
    public partial class frmAlineacion : Form
    {
        public frmAlineacion()
        {
            InitializeComponent();
        }
        private void frmAlineacion_Load(object sender, EventArgs e)
        {
            Dominio.Controladora unaControladora = new Dominio.Controladora();
            this.lstJugadores.DataSource = null;
            this.lstJugadores.DataSource = unaControladora.ListaJugadores();
            this.lstJugadores.SelectedIndex = -1;
        }
        #region "ABM"
        private void btnAlta_Click(object sender, EventArgs e)
        {
            Dominio.Controladora unaControladora = new Dominio.Controladora();
            short Nro = short.Parse(this.txtNro.Text);
            string Rival = this.txtRival.Text;
            Dominio.Alineacion unaAlineacion = unaControladora.BuscarAlineacion(Nro);
            if (unaAlineacion != null)
            {
                this.Limpiar();
                this.lblMensajes.Text = "La alineación ya existe!!";
            }
            else
            {
                if (this.rdb343.Checked)
                {
                    string Formacion = "3-4-3";
                    Dominio.Alineacion nuevaAlineacion = new Dominio.Alineacion(Nro,Rival,Formacion);
                    if (unaControladora.AltaAlineacion(nuevaAlineacion))
                    {
                        this.Limpiar();
                        this.ListarAlineaciones();
                        this.lblMensajes.Text = "Alineación ingresada";

                        lbl11.Visible = true;
                        lbl12.Visible = false;
                        lbl13.Visible = true;
                        lbl14.Visible = false;
                        lbl15.Visible = true;

                        lbl21.Visible = true;
                        lbl22.Visible = true;
                        lbl23.Visible = false;
                        lbl24.Visible = true;
                        lbl25.Visible = true;

                        lbl31.Visible = true;
                        lbl32.Visible = false;
                        lbl33.Visible = true;
                        lbl34.Visible = false;
                        lbl35.Visible = true;
                    }
                }
                else if (this.rdb433.Checked)
                {
                    string Formacion = "4-3-3";
                    Dominio.Alineacion nuevaAlineacion = new Dominio.Alineacion(Nro,Rival,Formacion);
                    if (unaControladora.AltaAlineacion(nuevaAlineacion))
                    {
                        this.Limpiar();
                        this.ListarAlineaciones();
                        this.lblMensajes.Text = "Alineación ingresada";

                        lbl11.Visible = true;
                        lbl12.Visible = true;
                        lbl13.Visible = false;
                        lbl14.Visible = true;
                        lbl15.Visible = true;

                        lbl21.Visible = true;
                        lbl22.Visible = false;
                        lbl23.Visible = true;
                        lbl24.Visible = false;
                        lbl25.Visible = true;

                        lbl31.Visible = true;
                        lbl32.Visible = false;
                        lbl33.Visible = true;
                        lbl34.Visible = false;
                        lbl35.Visible = true;
                    }
                }
                else if (this.rdb541.Checked)
                {
                    string Formacion = "5-4-1";
                    Dominio.Alineacion nuevaAlineacion = new Dominio.Alineacion(Nro,Rival,Formacion);
                    if (unaControladora.AltaAlineacion(nuevaAlineacion))
                    {
                        this.Limpiar();
                        this.ListarAlineaciones();
                        this.lblMensajes.Text = "Alineación ingresada";

                        lbl11.Visible = true;
                        lbl12.Visible = true;
                        lbl13.Visible = true;
                        lbl14.Visible = true;
                        lbl15.Visible = true;

                        lbl21.Visible = true;
                        lbl22.Visible = true;
                        lbl23.Visible = false;
                        lbl24.Visible = true;
                        lbl25.Visible = true;

                        lbl31.Visible = false;
                        lbl32.Visible = false;
                        lbl33.Visible = true;
                        lbl34.Visible = false;
                        lbl35.Visible = false;
                    }
                }
            }
            this.lstAlineaciones.SelectedIndex = -1;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Dominio.Controladora unaControladora = new Dominio.Controladora();
            short nro = short.Parse(this.txtNro.Text);
            Dominio.Alineacion unaAlineacion = unaControladora.BuscarAlineacion(nro);
            if (unaAlineacion != null)
            {
                if (unaControladora.BajaAlineacion(nro))
                {
                    this.Limpiar();
                    this.ListarAlineaciones();
                    this.lblMensajes.Text = "La alineación fue eliminada correctamente";
                }
                else
                {
                    this.Limpiar();
                    this.lblMensajes.Text = "ERROR: la alineación no fue eliminada";
                }
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        #endregion
        #region "Métodos auxiliares"
        private void Limpiar()
        {
            this.txtNro.Clear();
            this.txtRival.Clear();
            this.rdb343.Checked = false;
            this.rdb433.Checked = false;
            this.rdb541.Checked = false;
            this.txtNro.Focus();

            this.lbl11.Visible = true;
            this.lbl12.Visible = true;
            this.lbl13.Visible = true;
            this.lbl14.Visible = true;
            this.lbl15.Visible = true;

            this.lbl21.Visible = true;
            this.lbl22.Visible = true;
            this.lbl23.Visible = true;
            this.lbl24.Visible = true;
            this.lbl25.Visible = true;

            this.lbl31.Visible = true;
            this.lbl32.Visible = true;
            this.lbl33.Visible = true;
            this.lbl34.Visible = true;
            this.lbl35.Visible = true;
        }
        private void ListarAlineaciones()
        {
            Dominio.Controladora unaControladora = new Dominio.Controladora();

            this.lstAlineaciones.DataSource = null;
            this.lstAlineaciones.DataSource = unaControladora.ListaAlineaciones();
        }
        private void JugadoresYaCitados(Dominio.Alineacion pUnaAlineacion)
        {
            Dominio.Controladora unaControladora = new Dominio.Controladora();
            this.lstJugadoresCitados.DataSource = null;
            this.lstJugadoresCitados.DataSource = pUnaAlineacion.JugadoresCitados();

        }
        private void JugadoresCitados(Dominio.Alineacion pAlineacion)
        {
            Dominio.Controladora unaControladora = new Dominio.Controladora();
            this.lstJugadoresCitados.DataSource = null;
            this.lstJugadoresCitados.DataSource = pAlineacion.JugadoresCitados();

        }
        private void JugadoresSuplentes(Dominio.Alineacion pAlineacion)
        {
            Dominio.Controladora unaControladora = new Dominio.Controladora();
            this.lstSuplentes.DataSource = null;
            this.lstSuplentes.DataSource = pAlineacion.JugadoresSuplentes();
        }
        #endregion
        #region "Eventos"
        private void lstAlineaciones_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstAlineaciones.SelectedIndex > -1)
            {
                string linea = this.lstAlineaciones.SelectedItem.ToString();
                string[] partes = linea.Split(' ');

                short NroFecha = short.Parse(partes[0]);
                this.txtNro.Text = NroFecha.ToString();

                Dominio.Controladora unaControladora = new Dominio.Controladora();
                Dominio.Alineacion unaAlineacion = unaControladora.BuscarAlineacion(NroFecha);
                this.JugadoresYaCitados(unaAlineacion);

                string Rival = partes[1];
                this.txtRival.Text = Rival;

                string Formacion = partes[2];
                if (Formacion == "3-4-3")
                {
                    this.rdb343.Checked = true;

                    this.lbl11.Visible = true;
                    this.lbl12.Visible = false;
                    this.lbl13.Visible = true;
                    this.lbl14.Visible = false;
                    this.lbl15.Visible = true;

                    this.lbl21.Visible = true;
                    this.lbl22.Visible = true;
                    this.lbl23.Visible = false;
                    this.lbl24.Visible = true;
                    this.lbl25.Visible = true;

                    this.lbl31.Visible = true;
                    this.lbl32.Visible = false;
                    this.lbl33.Visible = true;
                    this.lbl34.Visible = false;
                    this.lbl35.Visible = true;
                }
                else if (Formacion == "4-3-3")
                {
                    this.rdb433.Checked = true;

                    this.lbl11.Visible = true;
                    this.lbl12.Visible = true;
                    this.lbl13.Visible = false;
                    this.lbl14.Visible = true;
                    this.lbl15.Visible = true;

                    this.lbl21.Visible = true;
                    this.lbl22.Visible = false;
                    this.lbl23.Visible = true;
                    this.lbl24.Visible = false;
                    this.lbl25.Visible = true;

                    this.lbl31.Visible = true;
                    this.lbl32.Visible = false;
                    this.lbl33.Visible = true;
                    this.lbl34.Visible = false;
                    this.lbl35.Visible = true;
                }
                else if (Formacion == "5-4-1")
                {
                    this.rdb541.Checked = true;

                    this.lbl11.Visible = true;
                    this.lbl12.Visible = true;
                    this.lbl13.Visible = true;
                    this.lbl14.Visible = true;
                    this.lbl15.Visible = true;

                    this.lbl21.Visible = true;
                    this.lbl22.Visible = true;
                    this.lbl23.Visible = false;
                    this.lbl24.Visible = true;
                    this.lbl25.Visible = true;

                    this.lbl31.Visible = false;
                    this.lbl32.Visible = false;
                    this.lbl33.Visible = true;
                    this.lbl34.Visible = false;
                    this.lbl35.Visible = false;

                    this.lbl11.Text = "⚽";
                    this.lbl12.Text = "⚽";
                    this.lbl13.Text = "⚽";
                    this.lbl14.Text = "⚽";
                    this.lbl15.Text = "⚽";

                    this.lbl21.Text = "⚽";
                    this.lbl22.Text = "⚽";
                    this.lbl23.Text = "⚽";
                    this.lbl24.Text = "⚽";
                    this.lbl25.Text = "⚽";

                    this.lbl31.Text = "⚽";
                    this.lbl32.Text = "⚽";
                    this.lbl33.Text = "⚽";
                    this.lbl34.Text = "⚽";
                    this.lbl35.Text = "⚽";
                }
                
                Dominio.Jugador unDt = unaControladora.BuscarDt(NroFecha);
                Dominio.Jugador unAsistente = unaControladora.BuscarAsistente(NroFecha);
                Dominio.Jugador unMedico = unaControladora.BuscarMedico(NroFecha);
                this.JugadoresYaCitados(unaAlineacion);

                if (unDt != null)
                {
                    this.lblDt.Text = "DT: " + unDt.Apellido;
                }
                if (unAsistente != null)
                {
                    this.lblAt.Text = "Asistente técnico: " + unAsistente.Apellido;
                }
                if (unMedico != null)
                {
                    this.lblMedico.Text = "Médico: " + unMedico.Apellido;
                }
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.lstJugadores.SelectedIndex > -1)
            {
                string linea = this.lstJugadores.SelectedItem.ToString();
                string[] partes = linea.Split(' ');
                short NroJugador = short.Parse(partes[0]);
                Dominio.Controladora unaControladora = new Dominio.Controladora();
                Dominio.Jugador unJugador = unaControladora.BuscarJugador(NroJugador);

                short NroAlineacion = short.Parse(this.txtNro.Text);
                Dominio.Alineacion unaAlineacion = unaControladora.BuscarAlineacion(NroAlineacion);
                if (unaAlineacion.AgregoJugador(unJugador))
                {
                    this.JugadoresCitados(unaAlineacion);
                    if (unJugador.Posicion == "Delantero")
                    {
                        if(this.lbl31.Text == "⚽" && lbl31.Visible == true)
                        {
                            this.lbl31.Text = unJugador.Apellido;
                        }
                        else if (this.lbl32.Text == "⚽" && lbl32.Visible == true)
                        {
                            this.lbl32.Text = unJugador.Apellido;
                        }
                        else if (this.lbl33.Text == "⚽" && lbl33.Visible == true)
                        {
                            this.lbl33.Text = unJugador.Apellido;
                        }
                        else if (this.lbl34.Text == "⚽" && lbl34.Visible == true)
                        {
                            this.lbl34.Text = unJugador.Apellido;
                        }
                        else if (this.lbl35.Text == "⚽" && lbl35.Visible == true)
                        {
                            this.lbl35.Text = unJugador.Apellido;
                        }
                    }
                    else if (unJugador.Posicion == "Mediocampo")
                    {
                        if (this.lbl21.Text == "⚽" && lbl21.Visible == true)
                        {
                            this.lbl21.Text = unJugador.Apellido;
                        }
                        else if (this.lbl22.Text == "⚽" && lbl22.Visible == true)
                        {
                            this.lbl22.Text = unJugador.Apellido;
                        }
                        else if (this.lbl23.Text == "⚽" && lbl23.Visible == true)
                        {
                            this.lbl23.Text = unJugador.Apellido;
                        }
                        else if (this.lbl24.Text == "⚽" && lbl24.Visible == true)
                        {
                            this.lbl24.Text = unJugador.Apellido;
                        }
                        else if (this.lbl25.Text == "⚽" && lbl25.Visible == true)
                        {
                            this.lbl25.Text = unJugador.Apellido;
                        }
                    }
                    else if (unJugador.Posicion == "Defensa")
                    {
                        if (this.lbl11.Text == "⚽" && lbl11.Visible == true)
                        {
                            this.lbl11.Text = unJugador.Apellido;
                        }
                        else if (this.lbl12.Text == "⚽" && lbl12.Visible == true)
                        {
                            this.lbl12.Text = unJugador.Apellido;
                        }
                        else if (this.lbl13.Text == "⚽" && lbl13.Visible == true)
                        {
                            this.lbl13.Text = unJugador.Apellido;
                        }
                        else if (this.lbl14.Text == "⚽" && lbl14.Visible == true)
                        {
                            this.lbl14.Text = unJugador.Apellido;
                        }
                        else if (this.lbl15.Text == "⚽" && lbl15.Visible == true)
                        {
                            this.lbl15.Text = unJugador.Apellido;
                        }
                    }
                    else if (unJugador.Posicion == "Golero")
                    {
                        this.lbl00.Text = unJugador.Apellido;
                    }
                    this.lblMensajes.Text = "Jugador citado correctamente";
                }
                else
                {
                    this.lblMensajes.Text = "Este jugador ya está citado";
                }
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstJugadoresCitados.SelectedIndex > -1)
            {
                string linea = this.lstJugadoresCitados.SelectedItem.ToString();
                string[] partes = linea.Split(' ');
                short NroJugador = short.Parse(partes[0]);
                Dominio.Controladora unaControladora = new Dominio.Controladora();
                Dominio.Jugador unJugador = unaControladora.BuscarJugador(NroJugador);

                short NroFecha = short.Parse(this.txtNro.Text);
                Dominio.Alineacion unaAlineacion = unaControladora.BuscarAlineacion(NroFecha);
                if (unaAlineacion.EliminoJugador(unJugador))
                {
                    this.JugadoresCitados(unaAlineacion);
                    if (unJugador.Posicion == "Delantero")
                    {
                        if (this.lbl31.Text == unJugador.Apellido && lbl31.Visible == true)
                        {
                            this.lbl31.Text = "⚽";
                        }
                        else if (this.lbl32.Text == unJugador.Apellido && lbl32.Visible == true)
                        {
                            this.lbl32.Text = "⚽";
                        }
                        else if (this.lbl33.Text == unJugador.Apellido && lbl33.Visible == true)
                        {
                            this.lbl33.Text = "⚽";
                        }
                        else if (this.lbl34.Text == unJugador.Apellido && lbl34.Visible == true)
                        {
                            this.lbl34.Text = "⚽";
                        }
                        else if (this.lbl35.Text == unJugador.Apellido && lbl35.Visible == true)
                        {
                            this.lbl35.Text = "⚽";
                        }
                    }
                    else if (unJugador.Posicion == "Mediocampo")
                    {
                        if (this.lbl21.Text == unJugador.Apellido && lbl21.Visible == true)
                        {
                            this.lbl21.Text = "⚽";
                        }
                        else if (this.lbl22.Text == unJugador.Apellido && lbl22.Visible == true)
                        {
                            this.lbl22.Text = "⚽";
                        }
                        else if (this.lbl23.Text == unJugador.Apellido && lbl23.Visible == true)
                        {
                            this.lbl23.Text = "⚽";
                        }
                        else if (this.lbl24.Text == unJugador.Apellido && lbl24.Visible == true)
                        {
                            this.lbl24.Text = "⚽";
                        }
                        else if (this.lbl25.Text == unJugador.Apellido && lbl25.Visible == true)
                        {
                            this.lbl25.Text = "⚽";
                        }
                    }
                    else if (unJugador.Posicion == "Defensa")
                    {
                        if (this.lbl11.Text == unJugador.Apellido && lbl11.Visible == true)
                        {
                            this.lbl11.Text = "⚽";
                        }
                        else if (this.lbl12.Text == unJugador.Apellido && lbl12.Visible == true)
                        {
                            this.lbl12.Text = "⚽";
                        }
                        else if (this.lbl13.Text == unJugador.Apellido && lbl13.Visible == true)
                        {
                            this.lbl13.Text = "⚽";
                        }
                        else if (this.lbl14.Text == unJugador.Apellido && lbl14.Visible == true)
                        {
                            this.lbl14.Text = "⚽";
                        }
                        else if (this.lbl15.Text == unJugador.Apellido && lbl15.Visible == true)
                        {
                            this.lbl15.Text = "⚽";
                        }
                    }
                    else if (unJugador.Posicion == "Golero")
                    {
                        this.lbl00.Text = "Golero";
                    }
                    this.lblMensajes.Text = "El jugador fue eliminado de la alineación";
                }
                else
                {
                    this.lblMensajes.Text = "El jugador ya fue citado";
                }
            }
        }
        private void lstJugadoresCitados_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstJugadoresCitados.SelectedIndex > -1)
            {
                string linea = this.lstJugadoresCitados.SelectedItem.ToString();
                string[] partes = linea.Split(' ');

                short Nro = short.Parse(partes[0]); 
            }
            else
            {
                this.lblMensajes.Text = "Debe seleccionar un jugador";
            }
        }
        private void btnSuplente_Click(object sender, EventArgs e)
        {
            if (this.lstJugadores.SelectedIndex > -1)
            {
                string linea = this.lstJugadores.SelectedItem.ToString();
                string[] partes = linea.Split(' ');
                short NroJugador = short.Parse(partes[0]);
                Dominio.Controladora unaControladora = new Dominio.Controladora();
                Dominio.Jugador unJugador = unaControladora.BuscarJugador(NroJugador);

                string linea2 = this.lstAlineaciones.SelectedItem.ToString();
                string[] partes2 = linea2.Split(' ');
                short NroAlineacion = short.Parse(partes2[0]);
                Dominio.Alineacion unaAlineacion = unaControladora.BuscarAlineacion(NroAlineacion);
                if (unaAlineacion.AgregoSuplente(unJugador))
                {
                    this.JugadoresSuplentes(unaAlineacion);
                }
            }
        }
        private void btnPdf_Click(object sender, EventArgs e)
        {
            PrintForm printForm = new PrintForm();
            printForm.Form = this;
            printForm.PrinterSettings.DefaultPageSettings.Landscape = true;
            printForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm.Print(this, PrintForm.PrintOption.FullWindow);

        }


        #endregion


    }
}
