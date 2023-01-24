namespace _43_44_Exception_Handeling_Abuse
{
    class GestionException

    /*
        Attendre que l execption se produise est une mauvaise pratique
        vaut mieux faire on se sorte qu elle ne se produit pas  
    */
    {

        //Avant
        public static void AvantSeProduise()
        {
            try
            {
                Console.WriteLine("Enter number 1 : ");
                int nbr1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number 2");
                int nbr2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Le resultat = {0}", nbr1/nbr2);    
            }
            catch (System.DivideByZeroException ex)
            {
                Console.Write(ex.GetType().Name + " devision par 0 impossible !");
            }
            catch (System.OverflowException ex)
            {
                Console.Write(ex.GetType().Name + " Entrez un nombre raisonable !");
            }
            catch (System.FormatException ex)
            {
                Console.Write(ex.GetType().Name + " Entrez un nombre valide !");
            }
            catch(System.Exception ex)
            {
                Console.Write(ex.GetType().Name + " Exception !");
            }
        }

        //Apres
         public static void AvantSeProduise_2()
        {
            try
            {
                Console.WriteLine("Enter number 1 : ");
                bool isConvert_1_OK = int.TryParse(Console.ReadLine(), out int n1);
                
                if (isConvert_1_OK ) {
                
                    if ( n1 >= Int32.MinValue && n1 <= Int32.MaxValue) {
                    // if ( n1 >= -999999 && n1 <= 999999) {
                        
                        Console.WriteLine("Enter number 2");
                        bool isConvert_2_OK = int.TryParse(Console.ReadLine(), out int n2);
                
                        if(isConvert_2_OK ) {
                
                            if (n2 != 0) {
                
                                // if (n2 >= Int32.MinValue && n2 <= Int32.MaxValue) {
                                if (n2 >= -9999999 && n2 <= 9999999) {
                                    Console.WriteLine("Le resultat = {0}", n1/n2);    
                                }
                                else 
                                {
                                    Console.WriteLine("Veuillez entrez un nbr2 entre Min et Max");
                                }

                            } else {
                                Console.WriteLine("La devision sur 0 est impossible");
                            }
                        }
                        else 
                        {
                            Console.WriteLine("Veuillez entrez un nbr2 correct");
                        }
                    } 
                    else
                    {
                        Console.WriteLine("Veuillez entrez un nbr1 entre Min et Max");    
                    }     
                }
                else{
                    Console.WriteLine("Veuillez entrez un nbr1 correct");
                }
            }
            catch(System.Exception ex)
            {
                Console.Write(ex.GetType().Name + " valide !");
            }
        }
    }
 
    
}

// using _43_44_Exception_Handeling_Abuse;
// // GestionException.ApresSeProduise();
// GestionException.AvantSeProduise_2();
