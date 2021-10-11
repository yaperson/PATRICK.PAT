using System;
using System.IO;

namespace ConsoleApp1
{
    class ReadFromFile
    {
        static void ecrire()
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("P:/C#/SIO2/PATRIC.PAT/text.txt");
                //Write a line of text
                sw.WriteLine("Hello World !");
                sw.WriteLine("Hello World ! Ton cul");
                sw.WriteLine("Hello World ! class");
                sw.WriteLine("Hello World !");
                sw.WriteLine("Hello World ! StreamWriter");
                sw.WriteLine(" ");

                sw.WriteLine("From the StreamWriter class");
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        public static void traiterUneLigne(string ligne)
        {
            //String ligne;
            
            try
            {
                //StreamReader sr = new StreamReader("P:/C#/SIO2/PATRIC.PAT/text.txt");
                //ligne = sr.ReadLine();
                //Console.WriteLine(cpt + " " + ligne);
                int cpt = 0;
                string token = ExtraireToken(ref cpt, ligne);

                while (token != "")
                {
                    Console.Write("<" + token + ">");
                    token = ExtraireToken(ref cpt, ligne);
                }
                //cpt++;
                //sr.Close();
                Console.ReadLine();
            }
            catch (Exception f)
            {
                Console.WriteLine("Exception: " + f.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        static void traiterFichier()
        {
            String ligne;
            int cpt = 0;
            try
            {
                StreamReader sr = new StreamReader("P:/C#/SIO2/PATRIC.PAT/text.txt");
                ligne = sr.ReadLine();
                //string ligne = " ";

                while (ligne != null)
                {
                    traiterUneLigne(ligne);
                    cpt++;
                    Console.WriteLine(cpt + " - " + " " + ligne);
                    ligne = sr.ReadLine();
                }
                sr.Close();
                //Console.ReadLine();
            }
            catch (Exception f)
            {
                Console.WriteLine("Exception: " + f.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        public static string ExtraireToken(ref int cpt, string ligne)
        {
            string token = "";
            int lgn = ligne.Length;

            if (ligne == "") return token;
            if (lgn <= cpt) return token;

            while (ligne[cpt] <= ' ')
            {
                cpt++;
                if (cpt >= lgn) return token;
            }

            while (ligne[cpt] > ' ')
            {
                token = token + ligne[cpt];
                cpt++;
                if (cpt >= lgn) return token;
            }

            return token;
        }
        static void Main()
        {
            //string ligne = "  Salut les amis  !  ";

            //int i = 0;
            //string token = ExtraireToken(ref i,ligne);

            //while (token != "")
            //{
            //    Console.WriteLine("<" +token + ">");
            //    token = ExtraireToken(ref i, ligne);
            //}
            ecrire();
            traiterFichier();

            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
