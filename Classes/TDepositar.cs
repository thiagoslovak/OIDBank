namespace OIDBank
{
    
    public class TDepositar
    {
       private double Saldo { get; set; }

       public TDepositar(double saldo)
       {
           this.Saldo = saldo;
       } 

       public void Depositar(double valorDeposito)
       {
           this.Saldo += valorDeposito;
           System.Console.WriteLine("Saldo atual da conta é: {0}", this.Saldo);
       }
    }
}