using System.Numerics;
namespace _16_Method_Static_Instance
{
    class A 
    {
        public void methodes()
        {
            string? quit;
            do {
                Console.Write("Entrez une nombre: ");
                string? str = Console.ReadLine();
                bool x = int.TryParse(str, out int nbr);
                
                if(!x){
                    Console.WriteLine("Le nombre \"{0}\" n\'est pas valide",str );
                } else {
                    
                    //labo
                    PrintArray(calcul(nbr));                
                }

                Console.Write(" Quitter? y/n: ");
                quit = Console.ReadLine();
                quit = quit==null?"null":quit;
                if(quit.ToUpper() != "Y" && quit.ToUpper() != "N"){
                    Console.Write("reponse \"{0}\" invalide", quit);
                }

            } while(quit.ToUpper() != "Y");             
        }

        public int[] calcul(int nbr){
            int i=0;
            int cpt = 0;
            int[] Tab;

            while(i <= nbr){
                i+=2;
                cpt++;
            }
           
            Tab = new int[cpt];

            int k = 0;
            int v = 0;
            while(v <= nbr){
                Tab[k] = v;
                v+=2;
                k++;
            }

            return Tab;            
        }

        void PrintArray(int[] arr)
        {
            foreach(int x in arr){
              Console.Write("{0} ",  x);
            }
        }

        public static void helloStatic(){
            Console.WriteLine("\nHELLO je suis la methode static !!");
        }
    }
}

// using _16_Method_Static_Instance;

// //Appel instance Mth
// A a = new A();
// a.methodes();

// //Appel Mth static
// A.helloStatic();