using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_técnica.Dominio
{
    class Jugador
    {
        private short _nro;
        private string _nombre;
        private string _apellido;
        private string _posicion;

        public short Nro
        { get { return _nro; } set { _nro = value; } }

        public string Nombre
        { get { return _nombre; } set { _nombre = value; } }

        public string Apellido
        { get { return _apellido; } set { _apellido = value; } }

        public string Posicion
        { get { return _posicion; } set { _posicion = value; } }

        public override string ToString()
        {
            return this.Nro + " " + this.Nombre + " " + this.Apellido + " " + this.Posicion;
        }
        public Jugador(short pNro, string pNombre, string pApellido, string pPosicion)
        {
            this.Nro = pNro;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Posicion = pPosicion;
        }
    }
}
