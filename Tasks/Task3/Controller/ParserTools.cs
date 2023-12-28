using System;
using Task3.View;

namespace Task3.Controller
{
    static internal class ParserTools
    { 
        public static int GetRemainingSymbolIndex(string expression, int symbolIndex, char symbol)
        {
            try
            {
                if(symbolIndex == -1)
                {
                    return -1;
                }

                int firstSymbolAfterZero = GetNextSymbolIndexIfZero(expression, symbolIndex, symbol);

                if (firstSymbolAfterZero < 1)
                {
                    return -1;
                }

                return firstSymbolAfterZero;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        static int GetNextSymbolIndexIfZero(string expression, int symbolIndex, char symbol)
        {
            if(symbolIndex == 0)
            {
                for(int i = 1; i < expression.Length; i++)
                {
                    if(!IsPreviousCharacterASymbol(expression, i) && symbol == expression[i]){
                        return i;
                    }
                }
                return -1;
            }
            else
            {
                return symbolIndex;
            }
        }

        public static (int, int) GetClosestSymbolsToAnchor(string expression, int anchor, (int, int) startEndIndex, char symbol)
        {
            int closestLeftSymbol = startEndIndex.Item1;
            int closestRightSymbol = startEndIndex.Item2;

            for (int i = 0; i < expression.Length; i++)
            {
                if(expression[i] == symbol && i > 0 && i < anchor && i >= startEndIndex.Item1)
                {
                    closestLeftSymbol = IsPreviousCharacterASymbol(expression, i)? i : i + 1;
                }

                if (expression[i] == symbol && i > anchor + 1 && i <= startEndIndex.Item2)
                {
                    closestRightSymbol = i;
                    break;
                }
            }

            return (closestLeftSymbol, closestRightSymbol);
        }

        public static bool IsPreviousCharacterASymbol(string expression, int index)
        {
            string symbols = "*/-+";
            return symbols.Contains(expression[index-1]);
        }
    }

}
