using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineWrapper
{
    public class LineWrapupLoop
    {
        private ConsoleInputService _inputService;
        private LineWrapup _lineWrapup;

        public LineWrapupLoop()
        {
            _inputService = new ConsoleInputService();
            _lineWrapup = new LineWrapup();
        }

        public void Run()
        {
            while (true)
            {
                String lineText = _inputService.GetString();
                int cutColumn = _inputService.GetInt();

                try
                {
                    string result = _lineWrapup.Wrapup(lineText, cutColumn);
                    Console.WriteLine(result);
                }
                catch
                {

                }
            }
        }
    }
}
