namespace _12_Switch_Goto
{
    class A
    {
        bool? rep;
        string? conti1;
        string? conti2;
    
        public void gotoo()
        {
            int[] panier = new int[3];
            panier[0] = 0;
            panier[1] = 0;
            panier[2] = 0;
            do {
                // do {
                    //====================
                    start :
                    Console.Write("\nMenu\n 1-Lait\n 2-Café\n 3-Pain\n 4-Quitter\nVeuillez faire votre choix: ");
                    rep = int.TryParse(Console.ReadLine(), out int choix);

                    switch (choix) {
                        case 1 : panier[0]+=1; break;
                        case 2 : panier[1]+=1; break;
                        case 3 : panier[2]+=1; break;
                        default : Console.WriteLine("Non défini !"); break;
                    }
                    //=======================
                    start2 :
                    Console.Write("Continuer? y/n: ");
                    conti1 = Console.ReadLine();
                    conti1 = conti1==null? "null":conti1;
                    switch(conti1.ToUpper()){
                        case "Y": goto start; 
                        case "N": Console.WriteLine("Quit"); break;
                        default : Console.WriteLine("la valeur {0} n\'est pas valide.. Veuillez resseyer !!", conti1); goto start2;
                    }

                    // if (conti1 != "n" && conti1 != "N" && conti1 != "y" && conti1 != "Y") {
                    //     Console.WriteLine("Veuillez entrer une reponse correct !");
                    // }
                    // if (conti1 == "n" || conti1 == "N" ) {
                    if (conti1.ToUpper() == "N") {
                        for (int i = 0; i < panier.Length; i++ ) {
                            switch(i){
                                case 0 : Console.WriteLine("Lait = {0}", panier[0]); break;
                                case 1 : Console.WriteLine("Café = {0}", panier[1]); break;
                                case 2 : Console.WriteLine("Pain = {0}", panier[2]); break;
                            }
                        }
                    }
                // } while (conti1 == "y");
              
                Console.Write("Quitter? y/n: ");
                conti2 = Console.ReadLine();
                conti2 = conti2==null? "null":conti2;
            } while (conti2.ToUpper() != "Y");
        }
    }
}
// using _12_Switch_Goto;
// _12_Switch_Goto.A A = new _12_Switch_Goto.A();

// A.gotoo();

//// goto peut aller sur une case aussi !!