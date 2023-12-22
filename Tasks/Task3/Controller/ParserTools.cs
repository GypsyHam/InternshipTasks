﻿using Task3.View;

namespace Task3.Controller
{
    static internal class ParserTools
    {
        public static int GetStringStart(int currentSymbolIndex, int firstSymbolIndex, int subStringStartIndex, int previousSymbolPriority, int priority)
        {
            try
            {
                // get first symbol before currently found symbol
                if (currentSymbolIndex < firstSymbolIndex && currentSymbolIndex > subStringStartIndex)
                {
                    return currentSymbolIndex + 1;
                }

                return subStringStartIndex;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public static int GetStringEnd(int currentSymbolIndex, int firstSymbolIndex, int subStringEndIndex, Symbol symbol, Symbol[] Symbols, string expression, int previousSymbolPriority)
        {
            // get first symbol after currently found symbol, check that it is not another symbol (negative / positive for example)
            if (currentSymbolIndex > firstSymbolIndex && currentSymbolIndex < subStringEndIndex && !(Symbols.Select(x => x.SymbolChar).Contains(expression[currentSymbolIndex - 1])))
            {
                return currentSymbolIndex;
            }
            //else if (symbol.Priority == previousSymbolPriority)
            //{
            //    return firstSymbolIndex;
            //    // subStringStartIndex = 0;
            //}
            return subStringEndIndex;
        }

        public static (int, int) GetStartEndIndex((int, int) startEndIndex, int anchorSymbolIndex, int incomingSymbolIndex, char symbol, string expression, string remaining)
        {
            int startIndex = startEndIndex.Item1;
            int endIndex = startEndIndex.Item2;

            if(incomingSymbolIndex < anchorSymbolIndex && incomingSymbolIndex > startIndex) // move starting point right
            {
                startIndex = incomingSymbolIndex + 1;
            }
            else if(incomingSymbolIndex > anchorSymbolIndex && incomingSymbolIndex < endIndex) // move ending point left
            {
                endIndex = incomingSymbolIndex;
            }

            return (startIndex, endIndex);
        }

        public static int GetRemainingSymbolIndex(string expression,  int symbolIndex, char symbol)
        {
            try
            {
                int newIndex = expression.Remove(symbolIndex, 1).IndexOf(symbol);

                return newIndex == -1 ? newIndex : newIndex + 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static bool IsPreviousIndexASymbol(string expression, int currentSymbolIndex, Symbol[] symbols)
        {
            if(currentSymbolIndex - 1 < 1)
            {
                return false;
            }

            return (symbols.Select(x => x.SymbolChar).Contains(expression[currentSymbolIndex - 1]));
        }
    }
}
