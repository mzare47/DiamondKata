using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondKata.ClassLibrary
{
    public class Diamond
    {
        private const char CHAR_A = 'A';
        private const char CHAR_Z = 'Z';
        private const int CHAR_A_ASCII_CODE = 65;
        public string Print(char ch)
        {
            char targetChar = ch;
            if (targetChar < CHAR_A || targetChar > CHAR_Z)
            {
                return null;
            }
            var stringBuilder = new StringBuilder();
            int lineCount = 2 * (targetChar - CHAR_A) + 1;
            for (int index = 0; index < lineCount; index++)
            {
                stringBuilder.Append(PrintDiamondLine(index, lineCount));
            }
            return stringBuilder.ToString();
        }

        private string PrintDiamondLine(int index, int lineCount)
        {
            var middleIndex = lineCount / 2;
            var charPosition1 = Math.Abs(middleIndex - index);
            var charPosition2 = (lineCount - 1) - charPosition1;
            var currentChar = Convert.ToChar(CHAR_A_ASCII_CODE + middleIndex - charPosition1);
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(' ', lineCount);
            stringBuilder.Replace(' ', currentChar, charPosition1, 1);
            stringBuilder.Replace(' ', currentChar, charPosition2, 1);
            stringBuilder.Append("\n");
            return stringBuilder.ToString();
        }
    }
}
