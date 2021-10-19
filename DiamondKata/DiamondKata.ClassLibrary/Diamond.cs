using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondKata.ClassLibrary
{
    public class Diamond
    {
        public string Print(char ch)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Convert.ToString(ch));
            stringBuilder.Append("\n");

            return stringBuilder.ToString();
        }
    }
}
