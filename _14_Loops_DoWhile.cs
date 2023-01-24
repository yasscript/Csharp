namespace _14_Loops_DoWhile
{
    class A 
    {
        public void doWhile()
        {
            int target;
            string? yy;

            do {
                int i = 0;
                Console.Write("\nEnter your target: ");
                string? xx = Console.ReadLine();
                bool x = int.TryParse(xx, out target);
                
                while (i <= target){    
                    if(!x){
                        Console.WriteLine("la valeur \"{0}\" n\'est pas valide", xx);
                        break;
                    } else {
                        Console.Write("{0} ", i);
                        i += 2;
                    }
                }

                do {
                    Console.Write("\nContinuer: ");
                    yy = Console.ReadLine();
                    yy = yy==null?"null":yy;
                    if(yy.ToUpper() != "Y" && yy.ToUpper() != "N"){
                        Console.WriteLine("votre reponse \"{0}\" n\'est pas valide..", yy);
                    }
                }while(yy.ToUpper() != "Y" && yy.ToUpper() != "N");
            
            }while(yy.ToUpper() == "Y");
        }          
    }
}
// using  _14_Loops_DoWhile;
// _14_Loops_DoWhile.A A = new _14_Loops_DoWhile.A();
// A.doWhile();