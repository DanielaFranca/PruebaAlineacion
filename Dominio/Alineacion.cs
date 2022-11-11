using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_técnica.Dominio
{
    class Alineacion
    {
        private short _nroFecha;
        private string _rival;
        private string _formacion;
        private List<Jugador> _listaJugadores = new List<Jugador>();
        private List<Jugador> _listaSuplentes = new List<Jugador>();


        public short NroFecha
        {
            get { return _nroFecha; }
            set { _nroFecha = value; }
        }
        public string Rival 
        {
            get { return _rival; }
            set { _rival = value; }
        }
        public string Formacion
        {
            get { return _formacion; }
            set { _formacion = value; }
        }
        public List<Jugador> Jugadores
        {
            get { return _listaJugadores; }
            set { _listaJugadores = value; }
        }
        public List<Jugador> Suplentes
        {
            get { return _listaSuplentes; }
            set { _listaSuplentes = value; }
        }
        public List<Jugador> JugadoresCitados()
        {
            return _listaJugadores;
        }
        public List<Jugador> JugadoresSuplentes()
        {
            return _listaSuplentes;
        }
        public Jugador BuscarJugador(short pNro)
        {
            foreach (Jugador unJugador in _listaJugadores)
            {
                if (unJugador.Nro == pNro)
                {
                    return unJugador;
                }
            }
            return null;
        }
        public bool AgregoJugador(Jugador pJugador)
        {
            Jugador unJugador = this.BuscarJugador(pJugador.Nro);
            if (unJugador == null)
            {
                _listaJugadores.Add(pJugador);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EliminoJugador(Jugador pJugador)
        {
            Jugador unJugador = this.BuscarJugador(pJugador.Nro);
            if (unJugador != null)
            {
                _listaJugadores.Remove(pJugador);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AgregoSuplente(Jugador pJugador)
        {
            Jugador unJugador = this.BuscarJugador(pJugador.Nro);
            if (unJugador == null && _listaSuplentes.Count < 7)
            {
                _listaSuplentes.Add(pJugador);
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return this.NroFecha + " " + this.Rival + " " + this.Formacion;
        }
        public Alineacion(short pNroFecha, string pRival, string pFormacion)
        {
            this.NroFecha = pNroFecha;
            this.Rival = pRival;
            this.Formacion = pFormacion;
        }
    }
}
