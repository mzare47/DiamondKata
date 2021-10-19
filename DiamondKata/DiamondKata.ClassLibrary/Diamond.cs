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
            char targetChar = ch;
            if (targetChar < 'A' || targetChar > 'Z')
            {
                return null;
            }
            StringBuilder diamondStringBuilder = new StringBuilder();
            int lineCount = 2 * (targetChar - 'A') + 1;
            int middleIndex = lineCount / 2;
            int charPosition1 = 0;
            int charPosition2 = 0;
            int asciiA = Convert.ToInt32('A');
            char currentChar = ' ';

            for (int index = 0; index < lineCount; index++)
            {
                charPosition1 = Math.Abs(middleIndex - index);
                charPosition2 = (lineCount - 1) - charPosition1;
                currentChar = Convert.ToChar(asciiA + middleIndex - charPosition1);
                StringBuilder diamondLineStringBuilder = new StringBuilder();
                diamondLineStringBuilder.Append(' ', lineCount);
                diamondLineStringBuilder.Replace(' ', currentChar, charPosition1, 1);
                diamondLineStringBuilder.Replace(' ', currentChar, charPosition2, 1);
                diamondLineStringBuilder.Append("\n");
                diamondStringBuilder.Append(diamondLineStringBuilder.ToString());
            }
            return diamondStringBuilder.ToString();
        }
    }
}
