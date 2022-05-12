namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        //Propriedades "readonly" só podem ter seu valor modi
        //ficado na inicialização ou dentro do construtor
        private readonly string nome = "Kelvin";
        private readonly string sobrenome;

        /*
        public Pessoa()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }
        */

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;       
            System.Console.WriteLine("Construtor classe Pessoa");     
        }
        public void Apresentar()
        {
            //this.nome = "teste";
            System.Console.WriteLine($"Olá, meu nome é: {nome} {sobrenome}");
        }
    }
}