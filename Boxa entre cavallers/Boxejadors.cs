namespace BoxaEntreCavallers
{
    public class Boxejador
    {
        public string Nom { get; private set; }
        public int Vida { get; private set; }

        public Boxejador(string nom)
        {
            Nom = nom;
            Vida = 10; 
        }

        public void RebreCop()
        {
            Vida--;
        }

        public bool EstaForaCombat()
        {
            return Vida <= 0;
        }
    }
}

