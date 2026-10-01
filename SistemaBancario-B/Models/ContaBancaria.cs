namespace SistemaBancario_B.Models
{
    //Pilar: Abstração 
    public abstract class ContaBancaria
    {

        //Pilar: Encapsulmento: Campos privados protegidos por propriedades publicas
        //Campos
        private string _numeroConta;
        private decimal _saldo;

        //exitems 3 tipos de modificadores
        //public - todos acessam
        //private - somente a classe acessa
        //protected- somente as classes filhas

        //Propriedades
        public string NumeroConta
        {
            get => _numeroConta;
            protected set => _numeroConta = value;
        }
        public decimal Saldo
        {
            get => _saldo;
            protected set => _saldo = value < 0 ? 0 : value;
        }
        
        public string NomeTitular { get; set; }
        public List<string> ExtratoTrasancoes { get; set; } = new List<string>();

        //Construtor da classe base
        protected ContaBancaria(string numeroConta,string nomeTitular,decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = saldoInicial;
            ExtratoTrasancoes.Add($"Conta Criada com saldo inicial de : R$ {saldoInicial:F2}");

        }
    }
   
}
