namespace Etudiantt 
{
    /**
    Test POO C#
    **/
    class Etudiant
    {
        public string name; 
        public int age; 


        public Etudiant (string aa, int bb)
        {
            this.name = aa;
            this.age = bb;
        }

        public string getName(){
            return this.name;
        }

        public int getAge(){
            return this.age;
        }

        public void setName(string name2){
            this.name = name2;
        }

        public void setAge(int age2){
            this.age = age2;
        }

        public int ageSurDeux()
        {
            return (this.age / 2) ;
        }

        public string toString()
        {
            return ("Name: " + this.name + "  age: " + this.age);
        }

    }

}
// using _0_Etudiantt;
// Etudiantt.Etudiant et = new Etudiantt.Etudiant("fff", 22);
// Console.WriteLine("Lage/2: " + et.ageSurDeux());
// Console.WriteLine(et.toString());
