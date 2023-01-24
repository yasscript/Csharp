namespace _32_Abstract_Class
{
    /*
        - une class abstraite est une class incomplete
        - je ne peux creer un object de cette class
    */
    abstract class Personne 
    {
        public int ID{set;get;}
        public string? name{set;get;}
        public string? email{set;get;}

        public void displayClient()
        {
            Console.WriteLine("ID: {0},  Name: {1}, Reference: {2}", this.ID, this.name, this.email);
        }

        // Methode Abstract 
        public abstract void print();

    }

    class Etudiant : Personne
    {
        public int niveau{set;get;}
        public string? branche{set;get;}

        public Etudiant(int ID, string name, string email, int niveau, string branche)
        {
            this.ID = ID;
            this.name = name;
            this.email = email;
            this.niveau = niveau;
            this.branche = branche;
        }

        // Il ne faut pas oublier l OVERRIDE
        public override void print()
        {
            Console.WriteLine("ID: {0}\nName: {1}\nEmail: {2}\nNiveau: " 
            + "{3}\nBranche: {4}", ID, name, email, niveau, branche);
        }

        // une abstract class heritre d une autre abstarct class sans implementation de la methode.

        //!!! tous ce qui est abstarc est destiner a etre délégué a l enfant

        // je ne peux pas rendre une abstract class "sealed" = ne fais heriter personne 
    }
}

// using _32_Abstract_Class;

// // creation d instance impossible
// // Client c = new Client();

// Etudiant e = new Etudiant(11,"Yass","Yass@gmail.com", 2, "Info");
// e.print();

