namespace Nico_Ejercicio_2
{
    public abstract class Cuenta: ICuentas
    {
        public string Nro { get; set; }
        public decimal Saldo { get; set; }
        public Banco oBanco { get; set; }
        public Cuenta(string _nro, decimal _saldo, Banco _oBanco)
        {
            Nro = _nro;
            Saldo = _saldo;
            oBanco = _oBanco;
        }
        public void Depositar(decimal _deposito) => Saldo += _deposito;
        //public abstract void Depositar(decimal _deposito);
         public void Extraer (decimal _extracto) => Saldo -= _extracto;
        //public abstract void Extraer (decimal _extracto);
        public decimal verSaldo() => Saldo;
    }
}
