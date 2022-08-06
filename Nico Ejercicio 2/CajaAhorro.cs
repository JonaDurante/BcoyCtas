namespace Nico_Ejercicio_2
{
    public class CajaAhorro : Cuenta, ICuentas
    {
        public decimal cantExtracciones { get; set; }
        public CajaAhorro(string _nro, decimal _saldo, Banco _oBanco) : base(_nro, _saldo, _oBanco)
        {
        }
        public void Extraer(decimal _extraer)
        {
            if (Saldo < 0 && Saldo >= _extraer)
            {
                base.Extraer(Saldo);
                //Saldo -= _extraer;
                cantExtracciones++;
            }
        }
    }
}
