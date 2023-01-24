namespace _29_StructuresVsClass
{
    /*
        class = reference type
        structure = value type

        value type "Struct" est stocké dans la partie stack de la memoire RAM
        reference type "Class" est stocké lui dans le Heap

        apres creation de d un value type il est stocké dans la RAM 
        apres creation d un reference type il est stock" dans l objet

        "Value" hors son block de fonctionnemet est effacé
        "reference" hors son block son nom 'reference' est effacé mais sont contenu reste present jusq a l appel du garbege.

        une class a un destructeur
        une struct n a pas de destructeur

        struct ne peut pas avoir un constructeur vide
        class a un constructeur un constructeur vide

        la structure n herite PAS et ne fais pas heriter les autres
        PARDON sauf d une interface :)
        la class ne peut pas heriter d une structure

        keyword "sealed" => transforme l objet en un objet qui ne fait heriter personne
    */

    class test{
         public static void test1()
        {
            // int est une structure !!
            // int est une alias de la structure Int32 dans le space name system !!
            
            /*
                a pointe sur la valeur 10
                b pointe sur une autre valeur copié de la la valeur de j
            */
            int a = 10;
            int b = a;
            Console.WriteLine("La valer de a = {0}\nLa valeur de b = {1}", a, b);
            
            /*
                a = 10;
                b = 11
                la valeur de a reste inchangée
            */
            b = b + 1;
            Console.WriteLine("La valer de a = {0}\nLa valeur de b = {1}", a, b);

            /*
                dans les "references" si on change sur 1 l autre change 
                les deux pointes sur le meme objet
            */
            Client c1 = new Client(111, "yass");
            Client c2 = c1;
            c2.name = "Mary";
            c1.displayClient();
            c2.displayClient();

            /*
                On va voir ce qui se passe avec les srtuctures
                puisk une structure une valeur value !
                    - creation de instance une pointe sur l autre
                    - changer une et voir si l autre s affecte !?

                !! OK les 2 objets sont independant l un a l autre !!
            */
            Etudiant e1 = new Etudiant("yass",22);
            Etudiant e2 = e1;
            e2.name = "Max";
            e1.displayEtudiant();
            e2.displayEtudiant();

            Lala la = new Lala();
            la.x = 33;
            la.displayLala();

        }
    }
    /*
        une Class est une reference
    */
    class Client
    {
        public int ID{set;get;}
        public string name{set;get;}
        public Client(int ID, string name)
        {
            this.ID = ID;
            this.name = name;
        }
        public void displayClient()
        {
            Console.WriteLine("ID: {0}  Name: {1}", ID, name);
        }
    }

    struct Etudiant
    {
        public string? name{set; get;}
        public int age{set; get;}
        public Etudiant(string name, int age)
        {   
            this.name = name;
            this.age = age;
        }
        public void displayEtudiant()
        {
            Console.WriteLine("Name: {0}  Age: {1}", name, age);
        }
    }

    struct Lala
    {
        public int x;

        // une struct ne peut pas avoir un constructeur vide 
        // public Lala(){}

        public Lala(int x){this.x=x;}
        
        public void displayLala()
        {
            Console.WriteLine("lala {0}", x);
        }
    }
}

// using _29_StructuresVsClass;
// test.test1();
