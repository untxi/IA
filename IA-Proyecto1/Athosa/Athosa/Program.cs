using System;
using CommandLine;
using Athosa.Logic;
using Athosa.GUI;

namespace Athosa

{
    public class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /*[STAThread]
         static void Main()
         {
             Console.WriteLine("1 record");
             Console.WriteLine("2 save");
             Console.WriteLine("3 play");
             Console.WriteLine("4 stop");
             Console.WriteLine("5 exit");
             string reading = "none";
             Logic.Audio myAudio = new Logic.Audio();

             while (reading != "5")
             {
                 reading = Console.ReadLine();

                 switch (reading)
                 {
                     case "1":
                         myAudio.wave();
                         break;
                     case "2":
                         myAudio.save();
                         break;
                     case "3":
                         myAudio.play();
                         break;
                     case "4":
                         myAudio.waveOut_PlaybackStopped();
                         break;
                     case "5":
                         reading = "5";
                         break;
                     default:
                         Console.WriteLine("out");
                         break;



                 }


             }

         } */
        static void Main()
        {

            
            int n = 8;
            int m = 8;
            int a = 50;
            /*
            double prob = 0.2;
            MyTuple myInit = new MyTuple(0, 0);
            MyTuple myEnd = new MyTuple(6, 3);
            SearchAStar myA = new SearchAStar();
            myA.main(myInit, myEnd, n, m, prob);
            */


            //MyMatrix myMatrix = myA.getMatrix();

            Board myPanel = new Board(n,m,a);
            //myPanel.addMatrix(myMatrix);
            
        }
    }
}

