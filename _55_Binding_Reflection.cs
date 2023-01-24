using System.Reflection;
namespace _55_Binding_Reflection
{
    /*
        -> Early binding = c est la red ligne si je veux creer un objet qui n existe pas
            ou je fais appel une methode qui n existe pas

        -> Late binding = je peux creer une instance d un type sans meme de savoir s il existe ou pas
        
        99% on utilse l'Early binding c est le codage normal
        mais dans klk cas on a besoin d utilser le Late Binding qui est complexe et couteux en ressources 
    
        on utilse le late binding si le type n est pas dans fichier assembly et que je load d une autre
             biblioteque ou un autre fichier assembly
        L'aventage c est que je n aurai pas d erreur en creant l objet mais j aurai une exception si il le trouve pas
        
        !!! Franchement c est un casse On l utilise presque jamais !!!
    
    */


    class Client
    {
        public string? Fname{set; get;}
        public string? Lname{set; get;} 

        public Client(){}
        public Client(string Fname, string Lname)
        {
            this.Fname = Fname;
            this.Lname = Lname;
        }  

        public string FullNameClient()
        {
            return "Nom: " +  Lname + ", " + "Prenom: " + Fname;
        }       


        public static void main()
        {
            // Early bindin 

            Client c1 = new Client("yassine","Echiguer");
            Console.WriteLine("Client => {0}",c1.FullNameClient());

            Client c2 = new Client();
            c2.Fname = "Caroline";
            c2.Lname = "Deumer";
            Console.WriteLine("Client => {0}",c2.FullNameClient());
            
            Client c3 = new Client{
                Fname = "Cedric",
                Lname = "Snoeck"
            };
            Console.WriteLine("Client => {0}",c3.FullNameClient());  

            
            // Late Binding =============================================
                // !!! - Appel de using.reflection
                // ne donne pas d erreur lors de l ecriture meme si la class Etudiant n existait pas 
                // il get le type du fichier assembly system
                // s il le trouve pas = une exeption 
                // utiliser pour un "test" de loadind de class... si ca marche ok sinon ..

            /*   
                // retirer les " /* " pour le test 

                Assembly executingAssembly = Assembly.GetExecutingAssembly();
                Type? EtudiantType = executingAssembly.GetType("_55_Binding_Reflection.Etudiant");
                object? EtudiantInstance = Activator.CreateInstance(EtudiantType);
                MethodInfo? getFullNameEtudiant = EtudiantType.GetMethod("FullNameEtudiant");
                
                string[] parameters = new string[2];
                parameters[0] = "Bob";
                parameters[1] = "Marley";
                
                string? FullNameEtudiant = (string)getFullNameEtudiant.Invoke(EtudiantInstance, parameters);

                Console.WriteLine("Etudiant => {0}",FullNameEtudiant);  
            */
            //=============================================

        }
    }

    // Class Test Late Binding ============================
    class Etudiant 
    {
        public string? Fname{set;get;}
        public string? Lname{set;get;}

        public string FullNameEtudiant(string Lname, string Fname)
        {
            return "Nom: " +  Lname + ", " + "Prenom: " + Fname;
        }
    }
}

// using _55_Binding_Reflection;
// Client.main();