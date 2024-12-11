namespace BoxaEntreCavallers
{
    public class Combat
    {
        private Boxejador Boxejador1;
        private Boxejador Boxejador2;

        public Combat(Boxejador boxejador1, Boxejador boxejador2)
        {
            Boxejador1 = boxejador1;
            Boxejador2 = boxejador2;
        }

        public void Inicia()
        {
            Console.WriteLine($"Combat entre {Boxejador1.Nom} i {Boxejador2.Nom}");
            Console.WriteLine("-------------------------------------");

            while (!Boxejador1.EstaForaCombat() && !Boxejador2.EstaForaCombat())
            {
                SimulaAtac(Boxejador1, Boxejador2);

                if (Boxejador2.EstaForaCombat()) break;

                SimulaAtac(Boxejador2, Boxejador1);
            }

            DeclaraGuanyador();
        }

        private void SimulaAtac(Boxejador atacant, Boxejador defensor)
        {
            Console.WriteLine($"{atacant.Nom} ataca!");
            defensor.RebreCop();
            Console.WriteLine($"{defensor.Nom} perd 1 punt de vida. Vida restant: {defensor.Vida}");
        }

        private void DeclaraGuanyador()
        {
            if (Boxejador1.EstaForaCombat())
            {
                Console.WriteLine($"{Boxejador1.Nom} CAU! per KO.");
                Console.WriteLine($"GUANYADOR: {Boxejador2.Nom} a deixat KO a {Boxejador1.Nom}");
            }
            else
            {
                Console.WriteLine($"{Boxejador2.Nom} CAU! per KO.");
                Console.WriteLine($"GUANYADOR: {Boxejador1.Nom} a deixat KO a {Boxejador2.Nom}");
            }
        }
    }
}