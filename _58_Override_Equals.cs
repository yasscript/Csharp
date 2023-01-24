namespace _58_Override_Equals
{
    /*
        pour comparer deux type values 'int string enums ' la methode equals fais le boulot
        Mais pour compares de references 'class structure' ?
    */
    class MthEquals
    {
        public static void main()
        {
            //// VALUES
            // Console.WriteLine("Hello");
            // int a = 10;
            // int b = 10;
            // Console.WriteLine(a.Equals(b)); // OK


            //// REFERENCES
            // referene 2 objects differents avec donnés egaux
            Client c1 = new Client{
                Fname = "yass",
                Lname = "echi"    
            };

            Client c2 = new Client{
                Fname = "yass",
                Lname = "echi"    
            };
            
            Console.WriteLine(" _1_ " + (c1 == c2)); // compare les references
            Console.WriteLine(" _2_ " + c1.Equals(c2)); // compare les valeurs


            // les deux instances referencent le meme objet
            Client c3 = c1;
            Console.WriteLine(" _3_ " + (c1 == c3)); // compare les references
            Console.WriteLine(" _4_ " + c1.Equals(c3)); // compare les valeurs


            /* Dans le 1 er cas ou il reference 2 objects diffrence 
                si je veux que Equals me compare les valeurs des objects pas les references des objects
                je fais un override de la methode equals 

                On mettant la methode overridée "Equals" en commentaire le _2_ deviens True !
            */  

            int aa = 5;
            Console.WriteLine(" _5_ " + c1.Equals(aa)); // test de comparaison de type differents géré par Mth equals overridée
        
            // Client? x = null;
            // Console.WriteLine(" _6_ " + c1.Equals(x)); // test de comparaison de type NULL géré par Mth equals overridée
        }


    }

    class Client
    {
        public string? Fname{set; get;}
        public string? Lname{set; get;}

        
        public override bool Equals(object? obj)
        {
            if (obj == null){
                return false;
            }
            if ( obj is Client == false){
                return false;
            }
            if((this.Fname == ((Client)obj).Fname) && (this.Lname == ((Client)obj).Lname)  ){ /// !!! il faut double parentaises
                return true;
            }
            return base.Equals(obj);
        }

        // demande automatiquement d overroider la gethashCode une fois qu on override l 'equals
        public override int GetHashCode()
        {
            if( this.Fname == null|| this.Lname==null){
                return 0;
            } 
            return this.Fname.GetHashCode() ^ this.Lname.GetHashCode();
        }
        
    }
}

// using _58_Override_Equals;
// MthEquals.main();