namespace  myclass
{
    using System;
    using System.IO;
   class ReadWrite 
    {
        public static DateTime now = DateTime.Now;
        public static StreamReader? sr = null;
        public static StreamWriter? sw = null;
        private static string path = "/media/zoro/E/CodeC#/myApp/Files/journal.log";
        public static string lireLigne(string str)
        {
            try
            {
                sr = new StreamReader(str);
                string? ligne = sr.ReadLine();
                if (string.IsNullOrEmpty(ligne)) {
                    return "Vide";
                }
                return ligne;
            } 
            catch (DirectoryNotFoundException ms)
            {
                write(path, now + " " + ms.GetType()+ " "+ str + " Chemin pas valid !");
                Console.WriteLine(ms.Message);
                return "Le Dossier n existe pas !!";   
            }
            catch (FileNotFoundException ms)
            {
                write(path, now + " " + ms.GetType()+ " "+ ms.FileName + " Non trouvé !");
                Console.WriteLine(ms.FileName);
                return "Le fichier n existe pas !!";
            }
            catch (Exception ms) 
            {   
                write(path, now + " " + ms.GetType() + " Excption !");
                Console.WriteLine(ms.GetType());
                return "Problem de lecture !!";
            }
            finally {
                if (sr != null){
                    sr.Close();
                }
            }           
        }

        public static string lireAll(string str)
        {
            try
            {
                sr = new StreamReader(str);
                string text =  sr.ReadToEnd();
                if (string.IsNullOrEmpty(text)) {
                    return "le text est vide !";
                }
                return text;
            }
            catch (DirectoryNotFoundException ms)
            {
                write(path, now + " " + ms.GetType()+ " "+ str + " Chemin pas valid !");
                Console.WriteLine(ms.Message);
                return "Le Dossier n existe pas !!";
                
            }
            catch (FileNotFoundException ms)
            {
                write("/media/zoro/E/CodeC#/myApp/Files/journal.log", now + " " + ms.GetType()+ " "+ ms.FileName + " Non trouvé !");
                Console.WriteLine(ms.Message);
                return "Le fichier n existe pas !!";
            }
            catch (Exception ms) 
            {   
                write("/media/zoro/E/CodeC#/myApp/Files/journal.log", now + " " + ms.GetType() + " Excption !");
                Console.WriteLine(ms.GetType());
                return "Problem de lecture !!";
            }
            finally {
                if (sr != null){
                    sr.Close();
                }
            } 
        }

        public static void write(string path, string text )
        {
            try
            {
               sw = new StreamWriter(path, append: true);
                sw.WriteLineAsync(text); 
            }
            catch (System.Exception ms)
            {
                write(path, now + " " + ms.GetType() + " Excption !");
                Console.WriteLine(ms.GetType());
            }
            finally 
            {
                if(sw != null){
                    sw.Close();
                }
            }
        }
    }
}


