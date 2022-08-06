namespace Nico_Ejercicio_2
{
    public class CuentaCorriente : Cuenta, ICuentas
    {
        private const int Tope = -1000;
        public decimal SaldoEnRojo { get; set; }
        public CuentaCorriente(string _nro, decimal _saldo, Banco _oBanco) : base(_nro, _saldo, _oBanco)
        {
        }
        public void Extraer(decimal _extracto) //500
        {
            if ((Saldo - _extracto )> Tope) // -900 // -1000
            {
                if ((Saldo - _extracto) <= 0)
                {
                    SaldoEnRojo += (Saldo - _extracto);
                }
                base.Extraer(_extracto); // Saldo -1400
                //Saldo -= _extracto;
            }
        }
        public void Depositar(decimal _deposito) // 18
        {
            if(!(_deposito <=0))
            { 
                decimal SaldoRestante = _deposito + SaldoEnRojo; //-20 
                //queda - 2
                if (SaldoRestante > 0)
                {
                    base.Depositar(_deposito);
                    //Saldo += _deposito;
                    SaldoEnRojo = 0;
                }
                else
                {   
                    SaldoEnRojo += _deposito; // Saldo en rojo queda en -2
                    Saldo = SaldoEnRojo;
                }
            }
        }
    }
}
