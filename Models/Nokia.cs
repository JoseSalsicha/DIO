namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memorial) : base(numero, modelo, imei, memorial)
        { }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine(nomeApp + " está sendo instalado no Nokia");
        }
    }
        // TODO: Sobrescrever o método "InstalarAplicativo"
}