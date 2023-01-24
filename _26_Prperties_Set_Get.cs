namespace _26_Prperties_Set_Get
{
    class Client 
    {
        private int _ID;
        private string? _name;
        private int _reference = 33;

        public int get_ID(){
            return this._ID;
        }
        public string get_Name(){
            if(string.IsNullOrEmpty(this._name)){ // string.IsNullOrEmpty(STR)
                return "No name";
            }
            return this._name;
        }
        public int get_Reference(){
            return this._reference;
        }

        public void set_ID(int ID)
        {
            if(ID < 0){
                throw new Exception("ID ne peut etre negatif !");
            }
            this._ID = ID;
        }
         public void set_Name(string name)
        {
            if(string.IsNullOrEmpty(name)){ // string.IsNullOrEmpty(STR)
                throw new Exception("Le nom ne peut pas etre null");
            }
            this._name = name;
            
        }

        public void displayClient()
        {
            Console.WriteLine("ID: {0},  Name: {1}, Reference: {2}", this.get_ID(), this.get_Name(), this.get_Reference());
        }
    }
}

// using _26_Prperties_Set_Get;

// Client c = new Client();

// // //Exceptions
// // c.set_ID(-101);
// // c.set_Name("");

// c.set_ID(101);
// c.set_Name("Yass");

// c.displayClient();