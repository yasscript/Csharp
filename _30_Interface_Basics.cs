namespace _30_Interface_Basics
{
    interface IClient
    {
        /* 
            - Pas besoin de l accebilité "public" l interface est par default public sinon Erreur !
            - interface ne contient pas d attributs
            - oblige la class qui implemente cette interface d overrider ses methode
            - je ne peut pas creer une instace de l interface mais il peut pointer sur la class enfant
        */
        void print();
        
        int calc(int a, int b);

    }

    interface IClient2
    {
        void print2();
    }

    interface In1
    {
        void functionIn1();
    }

    interface In2
    {
        void functionIn2();
    }

    interface Iinstance
    {
        void helloInstance();
    }

    class Client :IClient, IClient2, In2, Iinstance
    {
        public int id{set; get;}
        public string? name{set; get;}

        public void print()
        {
            Console.WriteLine("Je suis la methode Print de l interface IClient !");
        }

        public int calc(int a, int b)
        {
            return a + b;
        }

        public void print2()
        {
            Console.WriteLine("Je suis la methode Print2 de l interface IClient2 !");
            
        }

        public void functionIn1()
        {
            Console.WriteLine("Je suis la methde functionIn1 héritée de l interface In2 que elle l herite de In1");
        }
        public void functionIn2()
        {
         Console.WriteLine("Je suis la methde functionIn1 héritée de l interface I In2");   
        }
        
        public void helloInstance()
        {
         Console.WriteLine("Hello je suis un objet creer avec L interface !!");   
        }
    }   
}

// using _30_Interface_Basics;

// Client c = new Client();
// c.print();
// c.print2();
// c.functionIn1();
// c.functionIn2();
// Console.WriteLine(c.calc(2,3));

// Iinstance ii = new Client();
// ii.helloInstance();
