using CSharpIntro.Model;

namespace CSharpIntro.Services
{
    public class SalleService
    {

        public Demande myDemande;

        private List<Salle> mesSalles;

        public SalleService()
        {
            this.mesSalles = new List<Salle>();
        }

        public virtual Salle CreerSalle()
        {
            Salle maSalle;

            maSalle = new Salle();

            maSalle.Code = myDemande.DemanderString("Quel est ton Code de salle ?");
            maSalle.Type = myDemande.DemanderString("Saissisez le type de salle ?");
            maSalle.Nombre = myDemande.DemanderNumeric("Choissisez le nombre de place requises ");
            
            // ajout de la salle à la liste
            AddSalle(maSalle);
            return maSalle;
        }

        public void AddSalle(Salle S)
        {
            mesSalles.Add(S);
        }


        
        



        public string AfficherMessageSalles()
        {
            // on boucle sur l'ensemble des salles de la liste
            List<string> resultats = new List<string>();
            foreach (Salle salle in mesSalles)
            {
                // affichage de la salle issue de la liste
                resultats.Add(AfficherMessageSalle(salle));
            }
            return string.Join("\n", resultats);

        }



        public string AfficherMessageSalle(Salle salle)
        {
            string messageResultat;

            if (salle.Code == "2B")
            {
                // messageResultat = "Bonjour, tu t'appelles " + salle.Prenom + " " + salle.Nom + ", tu as " + salle.Age + " an";
                // messageResultat = string.Format("Bonjour, tu t'appelles {0} {1}, tu as {2} an", salle.Prenom, salle.Nom, salle.Age);
                messageResultat = $"Code : {salle.Code} , Type :{salle.Type}\nNombre de places :{salle.Nombre}\nCette salle est en travaux \n" +
                    "-------------------------------------- \n" +
                    "--------------------------------------";
            }
           
            else
            {
                messageResultat = $"Code :{salle.Code} , Type :{salle.Type}\nNombre de places :{salle.Nombre}\n" +
                    "-------------------------------------- \n" +
                    "--------------------------------------";
            }
            return messageResultat;
        }
    }
}
