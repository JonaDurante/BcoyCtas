using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nico_Ejercicio_2
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Dni { get; set; }
        public string Direccion { get; set; }
        public Banco Banco { get; set; }
        public Cuenta Cuenta { get; set; }

        public Cliente(string _cliente, string _dni, string _direccion, Banco _pBanco , Cuenta _cuenta)
        {
            Nombre = _cliente;
            Dni = _dni;
            Direccion = _direccion;
            Banco = _pBanco;
            Cuenta = _cuenta;
        }
        public string VerNombre() => Nombre;
        public void ModificarNombre(string _nombre) => Nombre = _nombre;
    }
}
