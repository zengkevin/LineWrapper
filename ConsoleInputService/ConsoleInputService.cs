using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineWrapper
{
    public class ConsoleInputService
    {
        public string GetString()
        {
            return Console.ReadLine();
        }

        public int GetInt()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
