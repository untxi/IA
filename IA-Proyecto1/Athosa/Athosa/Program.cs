using System;
using Gtk;

namespace Athosa
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            new SharpApp();
            Application.Run();
        }
    }
}
