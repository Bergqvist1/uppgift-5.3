using System;
namespace Uppgift_5_3
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] frågor = new string[4];
            string[] svar = new string[4];

            frågor[0] = "Vad heter Australiens hvuudstad?";
            frågor[1] = "Vem är helt achoo klar?";
            frågor[2] = "Vilket är bästa laget i premier league?";
            frågor[3] = "Är kebab gott?";

            svar[0] = "Canberra";
            svar[1]= "Pontos";
            svar[2] = "Liverpool";
            svar[3] = "Ja";

            Console.WriteLine("Välj en fråga 1-4:");
            int användareSvar = int.Parse(Console.ReadLine()) - 1;

            

        
                Console.WriteLine("Fråga: " + frågor[användareSvar]);

                string användarensSvar = Console.ReadLine();
                if(användarensSvar.ToLower() == svar[användareSvar].ToLower())
                {

                    Console.WriteLine("Grattis du har svarat rätt på frågan");

                }

                else
                {
                    Console.WriteLine("Du svarade fel på frågan, rätt svar är =" + " " + svar[användareSvar]);
                }




            

                                                        

            

        }
    }
}
