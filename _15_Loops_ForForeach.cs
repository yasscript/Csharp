namespace _15_Loops_ForForeach
{
    class A 
    {
        public void forForeach()
        {
            int[] Tab = new int[4];
            Tab[0] = 10;
            Tab[1] = 20;
            Tab[2] = 30;
            Tab[3] = 40;

            Console.WriteLine(" => Boucle For");
            for (int i=0; i<Tab.Length; i++) {
                Console.Write("{0} ", Tab[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine(" => Boucle Foreach");
            foreach (int x in Tab ) {
                Console.Write("{0} ", x);
            }
            Console.WriteLine("\n");

            Console.WriteLine(" => Break Boucle");
            for (int i=0; i<20; i++) {
                Console.Write("{0} ", i);
                if(i==15){
                    break;
                }
            }
            Console.WriteLine("\n");

            Console.WriteLine(" => Contine Boucle");
            for (int i=0; i<20; i++) {
                if((i%2)==1){
                    continue;
                } 
                Console.Write("{0} ", i);
            }
        }
    }
}
// using _15_Loops_ForForeach;
// A a = new A();
// a.forForeach();  