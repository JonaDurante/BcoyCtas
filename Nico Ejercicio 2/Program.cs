using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nico_Ejercicio_2
{
    public class Program 
    { 
        public static void Main(string[] args)
        {
            Banco BancoCuenta = new Banco("Santander", "allá");

            CuentaCorriente CC = new CuentaCorriente("111-11",-500.00m, BancoCuenta);
            CajaAhorro CA = new CajaAhorro("CA-1212", 222.00m, BancoCuenta);
            
            Cliente cliente = new Cliente("Juan", "34397679", "Calle Falsa 123", BancoCuenta, CC);
            Cliente cliente2 = new Cliente("Juan", "34397679", "Calle Falsa 321", BancoCuenta, CA);

            List<Cliente> ListaCliente = new List<Cliente>();
            ListaCliente.Add(cliente);
            ListaCliente.Add(cliente2);

            List<Cuenta> ListaCuentas = new List<Cuenta>();
            ListaCuentas.Add(CC);
            ListaCuentas.Add(CA);

            BancoCuenta.Cliente = ListaCliente;
            BancoCuenta.Cuentas = ListaCuentas;


            BancoCuenta.Transferir(2000, CC, CA);
            //CC.Extraer(1000);
            //CC.Depositar(1000.00m);
            //Console.WriteLine("El banco es: " + BancoCuenta.Nombre);
            //Console.WriteLine("Se ubica en: " + BancoCuenta.Direccion);
            //Console.WriteLine("Cuenta con el Cliente: " + cliente.Nombre);
            //Console.WriteLine("Alojado en la calle: " + cliente.Direccion);
            //Console.WriteLine("Propietario de las cuenas:");
            //foreach (var Cuenta in BancoCuenta.Cuentas)
            //{
            //    Console.WriteLine(Cuenta.Nro);
            //}
            //Console.ReadLine();
        }
    }
}
