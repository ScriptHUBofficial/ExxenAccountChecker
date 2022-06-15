using System;
using System.Drawing;

namespace ScriptHUB
{
    class Logo
    {
        //Birinci bölüm renkleri
        static Color _color1 = Color.FromArgb(254, 203, 5);

        //ikinci bölüm renkleri
        static Color _color2 = Color.FromArgb(254, 203, 5);

        //üçüncü bölüm renkleri
        static Color _color3 = Color.FromArgb(254, 203, 5);


        public static void _Show()
        {
            Console.Clear();
            string line = "\t";
            Console.Write("\n\n");
            Colorful.Console.Write(@"        ", _color3); Colorful.Console.Write(@"███████╗██╗  ██╗██╗  ██╗███████╗███╗   ██╗" + "\n", _color3);
            Colorful.Console.Write(@"        ", _color3); Colorful.Console.Write(@"██╔════╝╚██╗██╔╝╚██╗██╔╝██╔════╝████╗  ██║" + "\n", _color3);
            Colorful.Console.Write(@"        ", _color3); Colorful.Console.Write(@"█████╗   ╚███╔╝  ╚███╔╝ █████╗  ██╔██╗ ██║" + "\n", _color3);
            Colorful.Console.Write(@"        ", _color3); Colorful.Console.Write(@"██╔══╝   ██╔██╗  ██╔██╗ ██╔══╝  ██║╚██╗██║" + "\n", _color3);
            Colorful.Console.Write(@"        ", _color3); Colorful.Console.Write(@"███████╗██╔╝ ██╗██╔╝ ██╗███████╗██║ ╚████║" + "\n", _color3);
            Colorful.Console.Write(@"        ", _color3); Colorful.Console.Write(@"╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═══╝" + "\n", _color3);

        }
    }
}
