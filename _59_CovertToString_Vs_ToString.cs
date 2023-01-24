namespace _59_CovertToString_Vs_ToString
{
    /*
        la difference entre Convert?ToString() et ToString()
    */
    class A 
    {
        public string? name{set; get;}
        
        public static void main()
        {
            A a = new A{
                name = "yass"
            };

            Console.WriteLine(a.ToString()); // excepetion si l object est null 
            Console.WriteLine(Convert.ToString(a)); // remplace la valeur par un string vide "" => pas d exception

            /*
                Le Convert.Tostring() dans une application qui instancient automatiquemet des object
                donc ou cas elle n implemante pas bien les champs par exemple
                tu sais comme meme afficher klk chose :)
            */
        }

        public override string ToString()
        {
            return "Name: " + name;
        }
    }
}

// using _59_CovertToString_Vs_ToString;
// A.main();