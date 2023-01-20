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

            int poäng = 0;
            for(int i=0; i < frågor.Length; i++)
            {

                Console.WriteLine(frågor[i]);

                string användarensSvar = Console.ReadLine();
                if(användarensSvar == svar[i])
                {

                    Console.WriteLine("Grattis du har svarat rätt på frågan");

                }

                else
                {
                    Console.WriteLine("Du svarade fel på frågan, rätt svar är =" + " " + svar[i]);
                }




            }

                                                        

            

        }
    }
}
