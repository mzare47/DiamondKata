using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondKata.ClassLibrary
{
    public class Diamond
    {
        private StringBuilder stringBuilder;
        Diamond()
        {
            StringBuilder stringBuilder = new StringBuilder();
        }
        public string Print(char ch)
        {
            stringBuilder.Append(Convert.ToString(ch));
            stringBuilder.Append("\n");

            return stringBuilder.ToString();
        }
    }
}
