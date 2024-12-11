namespace BoxaEntreCavallers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdueix el nom del primer boxejador:");
            string nom1 = Console.ReadLine();

            Console.WriteLine("Introdueix el nom del segon boxejador:");
            string nom2 = Console.ReadLine();

            Boxejador boxejador1 = new Boxejador(nom1);
            Boxejador boxejador2 = new Boxejador(nom2);

            Combat combat = new Combat(boxejador1, boxejador2);
            combat.Inicia();
        }
    }
}