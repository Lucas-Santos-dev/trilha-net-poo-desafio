namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; }
        private string Modelo { get; }
        private string IMEI { get; }
        private int Memoria { get; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Métodos para obter informações
        public string ObterModelo() => Modelo;
        public string ObterIMEI() => IMEI;
        public int ObterMemoria() => Memoria;

        public void Ligar()
        {
            Console.WriteLine("Ligando para...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação de...");
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"Modelo: {ObterModelo()}");
            Console.WriteLine($"IMEI: {ObterIMEI()}");
            Console.WriteLine($"Memória: {ObterMemoria()}GB");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}