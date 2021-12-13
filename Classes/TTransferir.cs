namespace OIDBank
{
    public class TTransferir
    {
        
         private double Saldo { get; set; }
         private double Credito { get; set; }
        public TTransferir(double saldo, double credito)
        {
           this.Saldo = saldo;
           this.Credito = credito;
        } 
        public void Transferir(double valorTransferencia, TBanco contaDestino)
        {
            TSacar confereSaque = new TSacar(Saldo, Credito);
            if (confereSaque.Sacar(valorTransferencia))
            {
                contaDestino.chamaDeposito(valorTransferencia);
            }
        }
    }
}