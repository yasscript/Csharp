namespace _13_Loops_While
{
    class A 
    {
        public void loops()
        {
            start :
            Console.Write("Please enter your target: ");
            string? a = Console.ReadLine();
            bool x = int.TryParse(a, out int targer); 
            if(x){
                int i=0;
                while(i <= targer){
                    if((i%2)==0){
                        Console.Write("{0} ", i);
                    }
                    i++;
                }    
                Console.WriteLine();
            } else {
                Console.WriteLine("la valeur \"{0}\" n\'est pas valable..", a);
                goto start;
            }

            start2 :
            Console.Write("\ncontinuer? y/n: ");
            string? rep = Console.ReadLine();
            rep = rep==null?"null":rep;
            switch(rep.ToUpper()){
                case "Y" : goto start;
                case "N" : Console.WriteLine("Bye");break;
                default : Console.WriteLine("la valeur \"{0}\" n\'est pas valable..", rep);
                    goto start2;
            }    
        }
    }
}
// using _13_Loops_While;
// _13_Loops_While.A A = new _13_Loops_While.A();
// A.loops();