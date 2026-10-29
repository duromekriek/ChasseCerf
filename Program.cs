namespace Chasse_cerf;

class Program
{
    static void Main(string[] args)
    {
        /*
        Arthur dispose de 5 flèches pour chasser un cerf.

        Consignes :
        - Demander au joueur si chaque tir touche ou rate la cible.
        - Décrémenter le nombre de flèches après chaque tir.
        - Compter le nombre de tirs réussis.
        - Arrêter la chasse lorsque les 5 flèches sont utilisées.
        - Arrêter immédiatement la chasse si le cerf est touché 3 fois.
        - Si la saisie est invalide, demander une nouvelle réponse
          sans consommer de flèche.
        - Afficher le bilan final de la chasse.
        */

        Console.WriteLine("Vous commencez votre chasse.");

        int NombresFlèches = 5;
        int TirsRéussis = 0;

        string reponse1 = "touché";
        string reponse2 = "raté";

        for (int flèchesRestantes = 5 ; flèchesRestantes > 0 && TirsRéussis < 3 ;)
        {
            Console.WriteLine("Flèches restantes : " + flèchesRestantes);
            Console.WriteLine("Résultat du tir (touché/raté) : ?");

            string reponse = Console.ReadLine();

			if (reponse == reponse1 || reponse == "touché")
            {
                Console.WriteLine("Bien joué ! Le cerf est touché.");
				TirsRéussis++;
				flèchesRestantes--;
			}
			else if (reponse == reponse2 || reponse == "raté")
			{
				Console.WriteLine("Raté ! Le cerf s'est échappé de justesse.");
				flèchesRestantes--;
			}
			else
            {
                Console.WriteLine("Réponse invalide. Veuillez réessayer.");

            }
			NombresFlèches = flèchesRestantes;
		}

        Console.WriteLine("===== BILAN DE LA CHASSE =====");

        Console.WriteLine("Tirs réussis : " + TirsRéussis);

        Console.WriteLine("Flèches restantes : " + NombresFlèches);

		if (TirsRéussis == 3)
		{
			Console.WriteLine("Résultat : chasse réussie!");
		}
		else
		{
			Console.WriteLine("Résultat : Chasse raté.");
		}
	}
}