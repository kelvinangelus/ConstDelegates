namespace ExemploConstrutores.Models
{
    public class Log
    {
        //Criação de uma propriedade privada do tipo Log (objeto Log)
        private static Log _log;

        public string ProriedadeLog {get; set;}

        //Construtor privado da classe. A classe não 
        //pode ser instanciada de modo convencional
        private Log()
        {

        }

        //Se não existe nenhuma instância, crie uma instância
        //chamando o método GetInstance. Caso a instância já 
        //exista retorne-a
        public static Log GetInstance()
        {
            if (_log == null)
            {
                _log = new Log();
            }
            return _log; //Retorna um objeto Log
        }
    }
}