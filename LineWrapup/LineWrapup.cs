using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineWrapper
{
    public class LineWrapup
    {
        public String Wrapup(string lineText, int cutColumn)
        {
            string[] stringArray = lineText.Split(' ');

            StringBuilder result = new StringBuilder();
            StringBuilder newline = new StringBuilder(stringArray[0]);

            for (int i=1; i<stringArray.Length; i++)
            {
                if(newline.Length + stringArray[i].Length < cutColumn)
                {
                    newline.Append(" " + stringArray[i]);
                }
                else
                {
                    result.Append(newline + "\n");
                    newline = new StringBuilder(stringArray[i]);
                }
            }

            result.Append(newline);

            return result.ToString();
        }
    }
}
