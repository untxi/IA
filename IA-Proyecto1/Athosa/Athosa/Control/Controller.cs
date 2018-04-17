using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Athosa.Logic;
using Athosa.GUI;

namespace Athosa
{
    class Controller
    {
        public Controller()
        {
            SearchAStar MyAStar = new SearchAStar();
            Board MyBoard = new Board();
            Audio myListener = new Audio();
            
        }
        public void init()
        {


        }
    }
}
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