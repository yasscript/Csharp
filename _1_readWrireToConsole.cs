
namespace _1_readWrireToConsole
{
    class readWrite
    {
        string? Fname;
        string? Lname;
        public readWrite(){}
        public void read_write()
        {
            Console.WriteLine("please enter your Fname: ");
            Fname = Console.ReadLine();
            Console.WriteLine("please enter your Lname: ");
            Lname = Console.ReadLine();

            Console.WriteLine("Bonjour Mr " + Fname);
            Console.WriteLine("Bonjour Mr {0} {1}", Fname, Lname);
        }
    }
}

// using _1_readWrireToConsole;
// 1_readWrireToConsole.readWrite clas = new _1_readWrireToConsole.readWrite();
// clas.read_write();
