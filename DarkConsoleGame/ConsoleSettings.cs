using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkConsoleGame
{
    internal static class ConsoleSettings 
    {

        public static ConsoleColor currentColor = ConsoleColor.White;

        public static void Dark_Console() {
            Console.WriteLine(@"
     (                                                                           
     )\ )                    )         (                              (          
    (()/(       )   (     ( /(         )\                             )\     (   
     /(_))   ( /(   )(    )\())      (((_)    (     (      (     (   ((_)   ))\  
    (_))_    )(_)) (()\  ((_)\       )\___    )\    )\ )   )\    )\   _    /((_) 
     |   \  ((_)_   ((_) | |(_)     ((/ __|  ((_)  _(_/(  ((_)  ((_) | |  (_))   
     | |) | / _` | | '_| | / /       | (__  / _ \ | ' \)) (_-< / _ \ | |  / -_)  
     |___/  \__,_| |_|   |_\_\        \___| \___/ |_||_|  /__/ \___/ |_|  \___|  
                                                                                                              
");
        }

        public static ConsoleColor SetConsoleColor()
        {
            ConsoleColor temp = ConsoleColor.DarkYellow;

            if (Console.ForegroundColor == ConsoleColor.DarkYellow  )
            {
                currentColor = ConsoleColor.Cyan;
                return ConsoleColor.Cyan;
            }
            else if (Console.ForegroundColor == ConsoleColor.Cyan || Console.ForegroundColor == ConsoleColor.White)
            {
                currentColor = ConsoleColor.DarkYellow;
                return ConsoleColor.DarkYellow;
            }

            return temp;
        }


   


    }
}
