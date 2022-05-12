namespace ExemploConstrutores.Models
{
    public class Matematica
    {
        public int X{ get; set; }
        public int Y { get; set; }

        public Matematica(int x, int y)
        {
            X = x;
            Y = y;

            Calculadora.EventoCalculadora += EventHandler; //Inscrição do método "EventHandler" no evento "EventoCalculadora"
        }                                                  //Sempre que o método "Somar" de "Matematica" for chamado,
                                                           //ele chama o método "Somar" de "Calculadora"
        public void Somar()
        {
            Calculadora.Somar(X,Y); //Este método chama o método "Somar" de "Calculadora"
        }

        public void EventHandler()
        {
            System.Console.WriteLine("Método executado");
        }
    }
}