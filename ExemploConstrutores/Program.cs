using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            /*
            //Pessoa p1 = new Pessoa("Kelvin","Ângelus");
            Pessoa p1 = new Pessoa();

            p1.Apresentar();
            */

            /*
            //Criação de um objeto Log chamado log. Este objeto 
            //aponta para o mesmo local que o objeto retornado
            //por GetInstance()
            Log log = Log.GetInstance();

            log.ProriedadeLog = "Teste Instancia";

            //Esta instância também aponta para o mesmo
            //local do objeto retornado por Log.GetInstance() 
            Log log2 = Log.GetInstance();

            System.Console.WriteLine(log2.ProriedadeLog);
            */

            /*
            Aluno a1 = new Aluno("Kelvin","Ângelus","Teste");
            a1.Apresentar();
            */

            /*
            Data data = new Data();
            data.SetMes(20);

            data.ApresentarMes();
            */

            /*
            //a variável "pi" não pode ter seu valor 
            //modificado após sua inicialização
            const double pi = 3.14;
            System.Console.WriteLine(pi);
            */

            /*
            //Operacao op = Calculadora.Somar;
            Operacao op = new Operacao(Calculadora.Somar);
            //multicast delegate
            op += Calculadora.Subtrair; //Põe método subtrair na fila

            //op.Invoke(10,10);
            op(10,10);
            */

            Matematica m = new Matematica(10, 20); //Na chamada do construtor de "Matematica" é feita a inscrição
                                                   //do método "eventHandler"
            m.Somar();                             //Chamada do método "Somar" de "Matematica" que por sua 
                                                   //vez chamada o método "Somar" de "Calculadora"                                         
        }
    }
}