namespace ExemploConstrutores.Models
{
    public class Aluno : Pessoa
    {
        //Ao chamar o construtor de "Aluno", os argumentos 
        //são passados para a classe mãe "Pessoa".
        //Parâmetro "disciplina" só é exigido na classe aluno
        public Aluno(string nome, string sobrenome, string disciplina) : base(nome,sobrenome)
        {
            System.Console.WriteLine("Construtor classe Aluno");
        }
    }
}