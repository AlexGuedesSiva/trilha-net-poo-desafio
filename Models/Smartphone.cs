namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        
        public string Numero { get; set; }        
        protected string Imei { get; set; }
        protected string Modelo { get; set; }
        protected int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei,int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
            //FEITO
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}