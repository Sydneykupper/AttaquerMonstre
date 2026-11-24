namespace Attaquer_monstre;

/*
    CONSIGNES
    Dans votre jeu vidéo, le héros peut attaquer différents monstres.
    Pour cela, vous devez créer une méthode Attaquer() qui reçoit le nom du monstre en paramètre.
    La méthode doit afficher un message sous la forme : "Le héros attaque le Dragon !"
    
    Dans Main(), appelez cette méthode trois fois pour attaquer :
    - Un Dragon
    - Un Gobelin
    - Un Zombie
 */
class Program
{
    static void Main(string[] args)
    {
        Attaquer("Dragon");
        Attaquer("Gobelin");
        Attaquer("Zombie");
    }

    static void Attaquer(string monstre)
    {
        Console.WriteLine("Le héros attaque le " + monstre + " !");
    }

}
