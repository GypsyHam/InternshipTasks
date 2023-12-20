using Task3.View;

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
    }
}
