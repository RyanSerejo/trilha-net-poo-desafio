namespace DesafioPOO.Models
{
    //Herdar da classe "Smartphone OK
    //Sobreescrever o método abstrato OK
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no dispositivo Nokia.");
        }
    }
}