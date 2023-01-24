namespace _41_Exception_Inner
{
using myclass;

    class Calcule
    {
        /*
            L idee c est qu on a une premiere exeption et puis une autre 
            pour pouvoir reccuperer les deux pour les logs 
            c est un double try .. avec passage de la premiere exception dans le throw de la dexieme
            finalement on sait la geter avec InnerExcepetion  
        */

        public static void division()
        {
            try
            {
                try
                {
                    Console.Write( "## Division\n Entrez nb1: ");
                    int nbr1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write( "Entrez nb1: ");
                    int nbr2 = Convert.ToInt32(Console.ReadLine());

                    int div = nbr1 / nbr2;
                    Console.WriteLine( " = " + div);

                }
                catch (Exception ex)
                {
                    string path = "/media/zoro/E/CodeC#/myApp/Files/journal.logXX";
                    if (File.Exists(path))
                    {
                        ReadWrite.write(path, ReadWrite.now + " " + ex.GetType() + " Excption !");
                        // Console.WriteLine("Le fichier n'existe pas !!");                    
                    } else {
                        throw new FileNotFoundException("Le fichier n'existe pas !!", ex);
                    }
                }

            } catch (Exception ex2)
            {
                 
                Console.WriteLine("Current {0}", ex2.GetType().Name);
                Console.WriteLine("Inner {0}", ex2.InnerException?.GetType().Name);

            }
            


            // catch (DivideByZeroException ex)
            // {
            //     Console.WriteLine(ex.Message + "   La division sur 0 est imposssible !!");
            //     ReadWrite.write("/media/zoro/E/CodeC#/myApp/Files/journal.log", ReadWrite.now + " " + ex.GetType() + "Excption !");
            // }
            // catch (System.FormatException ex)
            // {
            //     Console.WriteLine(ex.GetType() + "   Entrez un numero valid !");
            //     ReadWrite.write("/media/zoro/E/CodeC#/myApp/Files/journal.log", ReadWrite.now + " " + ex.GetType() + "Excption !");
            // }
            // catch (System.OverflowException ex)
            // {
            //     Console.WriteLine(ex.GetType() + "   Entrez un nobre de taille raisonnable !");
            //     ReadWrite.write("/media/zoro/E/CodeC#/myApp/Files/journal.log", ReadWrite.now + " " + ex.GetType() + "Excption !");
            // }
            // catch (System.Exception ex)
            // {
            //     Console.WriteLine(ex.GetType());
            //     ReadWrite.write("/media/zoro/E/CodeC#/myApp/Files/journal.log", ReadWrite.now + " " + ex.GetType() + "Excption !");
            // }
            

            
        }
    }

}

// using _41_Exception_Inner;
// Calcule.division();