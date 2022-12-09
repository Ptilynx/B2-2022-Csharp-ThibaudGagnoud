using CSharpIntro.Model;
using CSharpIntro.Services;

internal class Program {

    private static void Main(string[] args) {

        //// demander le nom à l'utilisateur
        bool Quitter = false;
        string MessageMenu = "Bienvenue dans l'application de gestion des salles\n" +
"que voulez vous faire ?\n" +
"1. Créée une salle\n" +
"2. Afficher les salles dans l'ensemble\n" +
"Q. Quitter";
        Demande myDemande = new Demande();
        SalleService mySalleService = new SalleService();
        mySalleService.myDemande = myDemande;
        
        while (!Quitter) {

            string choix = myDemande.DemanderString(MessageMenu, 1, 1);
            if (choix == "1") {
                // création de la Salle de classe
                // après
                Salle maSalle = mySalleService.CreerSalle();
            } else if (choix == "2") {
                Console.WriteLine(mySalleService.AfficherMessageSalles());
            } else if (choix == "3") {
                mySalleService.AfficherMessageSalles();
            } else if (choix == "Q") {
                Quitter = true;
            }
        }
    }
}