namespace _57_Override_Tostring
{
    /*
        using ToString methode héritée de Object
    */
    class OverrideToS
    {
        public string? Fname{set;get;}
        public string? Lname{set;get;}
        public int age{set;get;}

        public static void main()
        {
            int number = 10;

            // les Methodes qui herire de Object

            int r1 = number.CompareTo(20);
            Console.WriteLine("CompareTo => {0}", r1);
            
            bool r2 = number.Equals(22);
            Console.WriteLine("Equals => {0}", r2);

            int r3 = number.GetHashCode();
            Console.WriteLine("GetHashCode => {0}", r3);

            Type r4 = number.GetType();
            Console.WriteLine("GetType => {0}", r4);

            TypeCode r5 = number.GetTypeCode();
            Console.WriteLine("GetTypeCode => {0}", r5);

            string r6 = number.ToString();
            Console.WriteLine("ToString => {0}", r6);

            //Tente de formater la valeur de l'instance du nombre entier actuel dans la plage de caractères fournie.???
            // bool r7 = number.TryFormat();
            // Console.WriteLine("ToString => {0}", r7);

            Console.WriteLine("\n**************************\n");
            OverrideToS yass = new OverrideToS{
                Fname = "yass",
                Lname = "echi",
                age = 38
            };
            Console.WriteLine(yass.ToString());

        
        }
        public override string ToString()
        {
            return "Nom: " + Fname + ", Prenom: " + Lname + ", Age: " + age;
        }
    }
}
// using _57_Override_Tostring;
// OverrideToS.main();