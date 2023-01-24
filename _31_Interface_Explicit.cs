namespace _31_Interface_Explicit
{
    interface IOne 
    {
        void methodeDeInterface();
    }

    interface ITwo 
    {
        void methodeDeInterface();

    }

    class Client : IOne, ITwo
    {
        public int id{set; get;}
        public string? name{set; get;}

        // public void methodeDeInterface()
        // {
        //     Console.WriteLine("Je suis la methode d une des deux interface IOne ou ITwo");
        // }


        // Explicit 

        // void IOne.methodeDeInterface()
        // {
        //     Console.WriteLine("Je suis la methode l interface IOne");
        // }

        void ITwo.methodeDeInterface()
        {
            Console.WriteLine("Je suis la methode l interface ITwo");
        }

        /* 
        rendre la methode de l inteterface IOne par defaut
            - IOne est implemeneter en premier
            - je peux l appeler sans cast ni creation avec type interface 
            - si je veux appeler la methode de l interface ITwo je cast ou je pointe avec ITwo
        */
        public void methodeDeInterface()
        {
            Console.WriteLine("Je suis la methode l interface IOne");
        }

    }

}

// using _31_Interface_Explicit;
// Client c = new Client();
// // c.methodeDeInterface();

// // calling (cast)
// ((IOne)c).methodeDeInterface();
// ((ITwo)c).methodeDeInterface();
// Console.WriteLine("\n");

// // calling type inteface 
// IOne c1 = new Client();
// ITwo c2 = new Client();
// c1.methodeDeInterface();
// c2.methodeDeInterface();