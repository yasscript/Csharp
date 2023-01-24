namespace _49_50_Acces_Modifiers_Members
{
    /*
        Les Acces modifiers qu on peut appliquer sur les type Members
            - Private 
            - Protected
            - Internal
            - Protected Internal
            - Public
            la restriction du moins au plus 
    */
    class Client
    {
        private int _id; // Je ne peux l utilser que dans la class Client

        protected int age; // je peux l utilser dans la class et les class qui herite de cette class.

        // internal int XX;
        // Je peux l'utilser tant que je suis dans le projet dans le meme fichier assemby 
        // C est un peu l acced modifiers Public 
        
        // internal protected int YY;
         // Je peux l utilser dans d autre class meme celles qui ne sont pas dans
        // le fichier assemby du projet c est a dire dans d autre projet tant quelles herite de cette clas.  
        // et cela est surtout du a l hritage 

         
        public int id // je peut l utiser par tout
        { 
            set{this._id = value;}
            get{return this._id;}
        }


        public static void main()
        {

        }
    }

    class Insolbvable : Client
    {
        public  void print()
        {
            this.age = 22;
            base.age = 33;

            Console.WriteLine("L\'attribut AGE hérité de la class Client => {0}", this.age);
        }
    }
    class Employee
    {
        public void print()
        {
            Client c = new Client();
            // c.age l attribut age pas accecible         
        }
    }
    
} 

// using _49_50_Acces_Modifiers_Members;
// Client.main();