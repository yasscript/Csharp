namespace _45_46_Enums
{
    /*
        Why Enumms ?

    */


    class Client 
    {
        public string? _name{set; get;}
        public int _genre{set; get;}

        //===================
        public string? name2{set; get;}
        public Genre genre2{set; get;}


        public static List<Client> _Tab = new List<Client>();
        public static List<Client> Tab = new List<Client>();

        public Client(string name, int genre) 
        {
            this._name = name;
            this._genre = genre;
        }

        public Client(){}

        /*
            1-Homme
            2-Femme
            3-X
        */

        public static void main()
        {
            Client._Tab.Add(new Client("yass",1));
            Client._Tab.Add(new Client("Max",2));
            Client._Tab.Add(new Client("Lisa",3));
            
            Client._Tab.Add(new Client
            {
                _name = "Max",
                _genre = 3
            });

            foreach(Client x in Client._Tab)
            {
                Console.WriteLine("Nom: {0},\t  Genre: {1}", x._name, getGenre(x));
            }       
        }

        public static string getGenre(Client clt)
        {
            switch(clt._genre)
            {
                case 1 : return "Homme";
                case 2 : return "Femme";
                case 3 : return "x";
                default : return "Non defini";
            }
        
        }   

        //================================================================================
        /* 
            Le problemme c est que lors de la creation des objets je donne des valeur
            1,2,3 insignifiantes meme por le programmeur
        */

        // ENUM
        public enum Genre
        {
            Homme,
            Femme,
            x,
            indefini
        }
        
        public static void main2()
        {
            Console.WriteLine("====================================");

            Client.Tab.Add(
                new Client {
                    name2 = "Alex",
                    genre2 = Genre.Homme
                }
            );
            Client.Tab.Add(
                new Client {
                    name2 = "Caro",
                    genre2 = Genre.Femme
                }
            );
            Client.Tab.Add(
                new Client {
                    name2 = "Sophie",
                    genre2 = Genre.indefini
                }
            );
            Client.Tab.Add(
                new Client {
                    name2 = "Albert",
                    genre2 = Genre.x
                }
            );

            
            foreach(Client x in Client.Tab)
            {
                Console.WriteLine("Nom: {0},\t  Genre: {1}", x.name2, getGenre2(x.genre2));
            }      
        }   

        public static string getGenre2(Genre genree)
        {
            switch(genree)
            {
                case Genre.Homme : return "Homme";
                case Genre.Femme : return "Femme";
                case Genre.x : return "X";
                case Genre.indefini : return "indefini";
                default : return "invalid";
            }
        }    
    }
}

// using _45_46_Enums;
// Client.main();
// Client.main2();
