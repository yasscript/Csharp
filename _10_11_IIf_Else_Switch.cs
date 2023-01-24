using System;
namespace _10_11_IIf_Else_Switch
{
    class A 
    {
        public void ifElse()
        {
            string? continu1 = "";
            string? continu2 = "";
            bool? tryMenu = null;
            string? Quit = "";

            do {
                Console.Write("\nMENU\n 1 - IF_Else\n 2 - SWITCH\n 3 - Quitter\nFaites votre choix:  ");
                string? m = Console.ReadLine();
                tryMenu = int.TryParse(m, out int mr);
                
                if (tryMenu == false) {
                    Console.WriteLine("Veuillez entrez un choix correct !!");
                }
                
                if (mr > 3) {
                    Console.WriteLine("Ce choix n\'est pas dans le Menu.. ");
                }

                if (tryMenu == true && mr == 1) {
                    Console.Write("\n === nIF_ELSE === \n");
                    
                    do {
                        continu1 = "";
                        Console.Write("\nEntrez un numero de jours de la semaine : ");
                        string? strNum = Console.ReadLine(); 
                        bool x = int.TryParse(strNum, out int Num);
                        if (!x) {
                            Console.WriteLine("Vueillez entrez un nombre correct !!");
                        }

                        if(Num == 1){
                            Console.WriteLine("Lundi");
                        } else if (Num == 2){
                            Console.WriteLine("Mardi");
                        } else if (Num == 3){
                            Console.WriteLine("Mercredi");
                        } else if (Num == 4){
                            Console.WriteLine("Jeudi");
                        } else if (Num == 5){
                            Console.WriteLine("Vendredi");
                        } else if (Num == 6){
                            Console.WriteLine("Samedi"); 
                        } else if (Num == 7){
                            Console.WriteLine("Dimanche");                 
                        } else {
                            Console.WriteLine("N\'existe pas");
                        }

                        while (continu1 != "n" && continu1 != "N"  && continu1 != "y" && continu1 != "Y") {
                            Console.WriteLine("\nVoulez vous continuez? y/n: ");
                            continu1 = Console.ReadLine();
                            if (continu1 != "n" && continu1 != "N"  && continu1 != "y" && continu1 != "Y" ) {
                                Console.WriteLine("Veuillez entrer une reponse correcte !! ");
                            } 
                        } 
                    }  while (continu1 != "n" && continu1 != "N");  
                }

                if (tryMenu == true && mr == 2) {
                    
                    Console.WriteLine("\n === SWITCH ===");
                    bool? x = null; 
                   
                    do {
                        int Num2 = 0;
                        do {

                            Console.Write("\nEntrez un numero de jours de la semaine : ");
                            string? strNum2 = Console.ReadLine(); 
                            x = int.TryParse(strNum2, out Num2);
                            if (x == null) {
                                Console.WriteLine("Vueillez entrez un nombre correct !!");
                            }
                        } while (x == null);
                        

                        if ( x == false) {
                            Console.WriteLine("Veuillez entrez un choix correct !!");
                        } else {
                            if (Num2 > 7 && Num2 < 1) {
                                Console.WriteLine("Ce choix n\'est pas dans le Menu.. ");
                            } else {
                                switch (Num2) {
                                    case 1 : Console.WriteLine("Lundi"); break;
                                    case 2 : Console.WriteLine("Mardi"); break;
                                    case 3 : Console.WriteLine("Mercredi"); break;
                                    case 4 : Console.WriteLine("Jeudi"); break;
                                    case 5 : Console.WriteLine("Vendredi"); break;
                                    case 6 : Console.WriteLine("Samedi"); break;
                                    case 7 : Console.WriteLine("Dimanche"); break;
                                    default : Console.WriteLine("Non défini !"); break;
                                }
                            }
                        }

                        do {
                            Console.WriteLine("\nVoulez vous continuez? y/n: ");
                            continu2 = Console.ReadLine();
                            if (continu2 != "n" && continu2 != "N"  && continu2 != "y" && continu2 != "Y" ) {
                                Console.WriteLine("Veuillez entrer une reponse correcte !! ");
                            } 
                        } while (continu2 != "n" && continu2 != "N"  && continu2 != "y" && continu2 != "Y");
                       

                    }while (continu2 != "n" && continu2 != "N");
                }

                if (tryMenu == true && mr == 3) {
                    Console.WriteLine("\nAu revoir :)");
                    break;
                }

                do {
                    Console.WriteLine("\nVoulez vous quitter le programme? y/n: ");
                    Quit = Console.ReadLine();
                    if (Quit != "n" && Quit != "N"  && Quit != "y" && Quit != "Y" ) {
                        Console.WriteLine("Veuillez entrer une reponse correcte !! ");
                    } 
                } while (Quit != "n" && Quit != "N"  && Quit != "y" && Quit != "Y");



            } while (Quit != "y" && Quit != "Y");
                     
        }
    }
}

// using _10_11_IIf_Else_Switch;
// A a = new _10_11_IIf_Else_Switch.A();
// a.ifElse();