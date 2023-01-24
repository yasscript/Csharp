namespace _5_2_Coalescing
{
    class A 
    {
        public void Coalescing()
        {
            Console.WriteLine("First name: ");

            // Coalesing Operator ??
            string? xx =  Console.ReadLine(); 
            string? yy = xx == "" ? null:xx; 
            string FN = yy ?? "null";

            Console.WriteLine("Bonjour Mr {0}", FN);
        }
        
    }
}
// using _5_2_Coalescing;
// _5_2_Coalescing.A A = new _5_2_Coalescing.A();

// A.Coalescing();