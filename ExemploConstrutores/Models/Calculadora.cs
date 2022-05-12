using ExemploConstrutores.Models;
namespace ExemploConstrutores{
    public class Calculadora
    {
        //Delegate
        public delegate void DelegateCalculadora();

        //Event
        public static event DelegateCalculadora EventoCalculadora;
        public static void Somar(int x, int y)
        {
            if(EventoCalculadora != null) //Se há inscritos no evento
            {
                System.Console.WriteLine($"Adição: {x + y}"); //Realize a adição
                EventoCalculadora(); //Notifique aos inscritos que o método "Somar" foi executado
            }
            else
            {
                System.Console.WriteLine("Nenhum inscrito"); //Se não houver inscritos
            }
            
        }
        public static void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"Subtração: {x - y}");
        }   
    }
}