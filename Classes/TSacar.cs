namespace OIDBank
{
    public class TSacar
    {
        private double Saldo { get; set; }
        private double Credito { get; set; }
      
        public TSacar(double saldo, double credito)
        {
            this.Saldo = saldo;
            this.Credito = credito;
        }

        public bool Sacar(double valorSaque)
        {
            if (this.Saldo - valorSaque < (this.Credito *-1))
            {
                System.Console.WriteLine("Saldo Insuficiente!");
                return false;
            }

            this.Saldo -= valorSaque;
            System.Console.WriteLine("Saldo atual da conta é: {0}", this.Saldo);
            return true;
        }
    }
}