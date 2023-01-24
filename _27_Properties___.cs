namespace _27_Properties___
{
    /*
    Propreties 
        - read/Write
        - read only
        - write only
        - Auto implemented
    */

    class Client 
    {
        private int _ID;
        private string? _name;
        private int _Reference = 33;
        private string? _Email;

        // Directement sur l attribut s il n y a pas de specification
        //Mais dois etre public 
        public string? etude{set;get;} 

        public string? city{set; get;}

        // Set normal Get specification
        public string Email
        {
            set {this._Email = value;}
            get {
                if(string.IsNullOrEmpty(this._Email)){
                    return "No Email";
                }
                return this._Email;}
        }

        // Les deux 
        public int ID{
            set {
                if(value < 0){
                    throw new Exception("ID ne peut etre negatif !");
                }
                this._ID = value;
            }
            get {
                return this._ID;
            }
        }


        public string name
        {
            set
            {
                if(string.IsNullOrEmpty(value)){
                    throw new Exception("ID ne peut etre negatif !");
                }
                this._name = value;
            }
            get
            {
                if(string.IsNullOrEmpty(this._name)){
                    return "No name";
                }
                return this._name;
            }
        }

        public int reference
        {
            get
            {
                return this._Reference;
            }
        }

        public void displayClient()
        {
            Console.WriteLine("ID: {0},  Name: {1}, Reference: {2}, City: {3}", this.ID, this.name, this.reference, this.city);
        }


    }
}

// using _27_Properties___;

// Client c = new Client();
// // c.ID = -5;
// c.ID = 5;
// // c.name = "";
// c.name = "Yass";
// c.city = "Bastogne";
// c.etude = "ddd";

// c.displayClient();

