using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_técnica.Dominio
{
    class Controladora
    {
        private static List<Jugador> _listaJugadores = new List<Jugador>();
        private static List<Alineacion> _listaAlineaciones = new List<Alineacion>();

        public List<Jugador> ListaJugadores()
        {
            return _listaJugadores;
        }
        public List<Alineacion> ListaAlineaciones()
        {
            return _listaAlineaciones;
        }

        #region "ABM de Jugadores"
        public Jugador BuscarJugador(short pNro)
        {
            foreach (Jugador unJugador in _listaJugadores)
            {
                if (unJugador.Nro == pNro)
                    return unJugador;
            }
            return null;
        }
        public bool AltaJugador(Jugador pJugador)
        {
            Jugador unJugador = this.BuscarJugador(pJugador.Nro);
            if (unJugador == null)
            {
                _listaJugadores.Add(pJugador);
                return true;
            }
            return false;
        }
        public bool BajaJugador(short pNro)
        {
            Jugador unJugador = this.BuscarJugador(pNro);
            if (unJugador != null)
            {
                _listaJugadores.Remove(unJugador);
                return true;
            }
            return false;
        }

        public bool ModificarJugador(short pNro, string pNombre, string pApellido, string pPosicion)
        {
            Jugador unJugador = this.BuscarJugador(pNro);
            if (unJugador != null)
            {
                unJugador.Nombre = pNombre;
                unJugador.Apellido = pApellido;
                unJugador.Posicion = pPosicion;
                return true;
            }
            else
                return false;
        }

        #endregion
        #region "ABM de Alineaciones"
        public Alineacion BuscarAlineacion(short pNro)
        {
            foreach (Alineacion unaAlineacion in _listaAlineaciones)
            {
                if (unaAlineacion.NroFecha == pNro)
                {
                    return unaAlineacion;
                }
            }
            return null;
        }
        public bool AltaAlineacion(Alineacion pAlineacion)
        {
            Alineacion unaAlineacion = this.BuscarAlineacion(pAlineacion.NroFecha);
            if (unaAlineacion == null)
            {
                _listaAlineaciones.Add(pAlineacion);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool BajaAlineacion(short pNro)
        {
            Alineacion unaAlineacion = this.BuscarAlineacion(pNro);
            if (unaAlineacion != null)
            {
                _listaAlineaciones.Remove(unaAlineacion);
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        public Jugador BuscarDt(short pNro)
        {
            foreach(Alineacion unaAlinecion in _listaAlineaciones)
            {
                if (unaAlinecion.NroFecha == pNro)
                {
                    foreach(Jugador unJugador in unaAlinecion.JugadoresCitados())
                    {
                        if (unJugador.Posicion == "DT")
                        {
                            return unJugador;
                        }
                    }
                }
            }
            return null;
        }
        public Jugador BuscarAsistente(short pNro)
        {
            foreach (Alineacion unaAlinecion in _listaAlineaciones)
            {
                if (unaAlinecion.NroFecha == pNro)
                {
                    foreach (Jugador unJugador in unaAlinecion.JugadoresCitados())
                    {
                        if (unJugador.Posicion == "AT")
                        {
                            return unJugador;
                        }
                    }
                }
            }
            return null;
        }
        public Jugador BuscarMedico(short pNro)
        {
            foreach (Alineacion unaAlinecion in _listaAlineaciones)
            {
                if (unaAlinecion.NroFecha == pNro)
                {
                    foreach (Jugador unJugador in unaAlinecion.JugadoresCitados())
                    {
                        if (unJugador.Posicion == "Médico")
                        {
                            return unJugador;
                        }
                    }
                }
            }
            return null;
        }
    }
}
