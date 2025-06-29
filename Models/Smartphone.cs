namespace DesafioPOO.Models
{
    //Propriedades definidas e adicionadas no contrutor da classe.
    //Por causa do nível de proteção solicitado nas propriedades, tive que fazer métodos para pelo menos exibir o valor delas.
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
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

        public void ExibirModelo()
        {
            Console.WriteLine(Modelo);
        }
        public void ExibirIMEI()
        {
            Console.WriteLine(IMEI);
        }
        public void ExibirMemoria()
        {
            Console.WriteLine(Memoria + " GB.");
        }
    }
}