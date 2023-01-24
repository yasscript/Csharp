namespace _20_Static_Instance_Class
{
    class Circle
    {
        // static float _PI = 3.141F;
        public static float _PI;
        int _Radius;

        static Circle()
        {
            _PI = 3.141F;
            Console.WriteLine("Tu es rentré dans le constructeur static .."); 
        }


        public Circle(int Radius)
        {
            this._Radius = Radius;
            Console.WriteLine("Initiale constructeur ..");        
        }

        public void surface()
        {
            Console.WriteLine("La surface = {0}", this._Radius*this._Radius*Circle._PI);
        }

        public static void DisplayPi()
        {
            Console.WriteLine("Pi depuis la fonction = {0} =>Constructor??", _PI);
        }
    }

}

// using _20_Static_Instance_Class;

// // Circle C1 = new Circle(5);
// // C1.surface();

// // Circle C2 = new Circle(6);
// // C2.surface();

// // Circle C3 = new Circle(4);
// // C3.surface();

// // Console.WriteLine(Circle._PI);

// Circle.DisplayPi();
// Circle.DisplayPi();