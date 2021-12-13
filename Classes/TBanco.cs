namespace OIDBank
{
    public class TBanco
    {
        private TipoConta TipoConta { get; set; } 
        private double Saldo { get; set; } 
        private double Credito { get; set; } 
        private string Nome { get; set; }
    
        
        public TBanco(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }

        public void chamaSaque(double valorSaque)
        {
            TSacar PassaValor = new TSacar(Saldo, Credito);
            PassaValor.Sacar(valorSaque);
        }

        public void chamaDeposito(double valorDeposito)
        {
            TDepositar PassaValor = new TDepositar(Saldo);
            PassaValor.Depositar(valorDeposito);
        }

        public void chamaTransferencia(double valorTransferencia, TBanco contaDestino)
        {
            TTransferir PassaValor = new TTransferir(Saldo, Credito);
            PassaValor.Transferir(valorTransferencia, contaDestino);
        }

        public override string ToString()//método Sobrescrevendo o método de TOBJECT
        {
            string retorno = "";
            retorno += "Tipo Conta " + this.TipoConta + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Crédito " + this.Credito;
            return retorno;
        }
    }
}