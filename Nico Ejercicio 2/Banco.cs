using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nico_Ejercicio_2
{
    public class Banco
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<Cuenta> Cuentas { get; set; }
        public List<Cliente> Cliente { get; set; } 
        public Banco(string _nombre, string _direccion)
        {
            Nombre = _nombre;
            Direccion = _direccion;
        }
        public void Transferir(decimal _transferir, Cuenta CuentaReceptora, Cuenta CuentaEmisora) 
        {
            CuentaEmisora.Extraer(_transferir);
            CuentaReceptora.Depositar(_transferir);

        }
    }
}
