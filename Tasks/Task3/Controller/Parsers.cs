using Task3.View;

namespace Task3.Controller
{
    public static class Parsers
    {
        static Symbol[] Symbols = new Symbol[]{
            new Symbol { SymbolChar = '*', Priority = 1},
            new Symbol { SymbolChar = '/', Priority = 1},
            new Symbol { SymbolChar = '-', Priority = 2},
            new Symbol { SymbolChar = '+', Priority = 2},
        };

        
        public static bool IsExpressionValid(List<string> expressions)
        {    
            for(int i = 1; i < expressions.Count; i++)
            {
                if (expressions[i] != expressions[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public static List<string> GetAllExpressionsForCompare(string expression)
        {
            List<string> expressionResults = new List<string>();
            expression = expression.Replace(" ", "");

            bool allExpressionsFound = false;            

            while (!allExpressionsFound)
            {
                int nextExpressionEndIndex = expression.IndexOf('=');

                if(nextExpressionEndIndex > 0)
                {
                    string stringToReduce = expression.Substring(0, nextExpressionEndIndex);
                    expressionResults.Add(ReduceExpression(stringToReduce));
                    expression = expression.Substring(nextExpressionEndIndex + 1);
                }
                else
                {
                    expressionResults.Add(ReduceExpression(expression));
                    allExpressionsFound = true;
                }
            }

            return expressionResults;
        }

        public static string ReduceExpression(string expression)
        {
            try
            {
                string nextBracketExpression = GetNextBracketExpression(expression);
                while (nextBracketExpression != expression)
                {
                    string replaceValue = CalculateExpressions(nextBracketExpression);
                    expression = expression.Replace(nextBracketExpression, replaceValue);
                    nextBracketExpression = GetNextBracketExpression(expression);
                }

                expression = CalculateExpressions(expression);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return expression;
        }

        static string CalculateExpressions(string expression)
        {
            expression = expression.Replace("(", "").Replace(")", "");

            bool finalExpression = false;
            string nextExpression = expression;
            Expression currentExpression = new Expression();
            
            while (!finalExpression)
            {
                nextExpression = GetNextExpression(expression);
                if (expression == nextExpression)
                {
                    finalExpression = true;
                }
                currentExpression = Calculations.CalculateExpression(nextExpression);
                expression = expression.Replace(nextExpression, currentExpression.Result.ToString());
            }

            return expression;
        }

        public static string GetNextExpression(string expression)
        {
            int subStringStartIndex = 0;
            int subStringEndIndex = expression.Length;
            int firstSymbolIndex = -1;
            int currentSymbolIndex = -1;
            int previousSymbolPriority = 1;
            
            foreach(Symbol symbol in Symbols)
            {
                currentSymbolIndex = expression.IndexOf(symbol.SymbolChar);
                if (currentSymbolIndex < 0) continue;
           
                firstSymbolIndex = firstSymbolIndex == -1? currentSymbolIndex: firstSymbolIndex;
                string remaining = string.Empty;

                do
                {
                    remaining = expression.Substring(currentSymbolIndex + 1);
                    if (remaining.Contains(symbol.SymbolChar))
                    {
                        //make sure negative / positive signs aren't replaced accidentally;
                        int remainingIndex = expression.Remove(currentSymbolIndex, 1).IndexOf(symbol.SymbolChar) + 1;
                        if (remainingIndex < subStringEndIndex && (expression[firstSymbolIndex + 1] != symbol.SymbolChar))
                        {
                            subStringEndIndex = remainingIndex;
                        }
                        previousSymbolPriority = symbol.Priority;
                        currentSymbolIndex = remainingIndex;
                        //continue;
                    }
                }
                while (remaining.Contains(symbol.SymbolChar));               

                if(firstSymbolIndex == -1 || currentSymbolIndex == -1)
                {
                    continue;
                }

                subStringStartIndex = ParserTools.GetStringStart(currentSymbolIndex, firstSymbolIndex, subStringStartIndex, previousSymbolPriority, symbol.Priority);

                subStringEndIndex = ParserTools.GetStringEnd(currentSymbolIndex, firstSymbolIndex, subStringEndIndex, symbol, Symbols, expression, previousSymbolPriority);

                previousSymbolPriority = symbol.Priority;
            }

            
            string returnString = expression.Substring(subStringStartIndex, subStringEndIndex - subStringStartIndex);

            return returnString;
        }       

    public static Expression GetResults(string expression)
        {
            Expression result = new Expression();

            expression = expression.Replace(" ", "");

            if (expression.Contains('('))
            {
                expression = GetNextBracketExpression(expression);
            }

            expression = GetNextExpression(expression);

            result = Calculations.CalculateExpression(expression);

            return result;
        }

        static string GetNextBracketExpression(string expression)
        {
            int firstOpenBracket = 0;
            int firstClosedBracket = expression.Length;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    firstOpenBracket = i;
                }
                else if (expression[i] == ')')
                {
                    firstClosedBracket = i;
                    return expression.Substring(firstOpenBracket, firstClosedBracket - firstOpenBracket + 1);
                }
            }

            return expression;            
        }

        public static Expression GetExpressionModelFromString(string expression)
        {
            Expression expressionModel = new Expression();
            expression = expression.Replace(" ", "");

            char symbol = GetSymbol(expression);
            float leftValue = GetLeftValue(expression, symbol);
            float rightValue = GetRightValue(expression, symbol);

            expressionModel.LeftHandSide = leftValue;
            expressionModel.RightHandSide = rightValue;
            expressionModel.Symbol = symbol == '?' ? '+' : symbol;

            return expressionModel;
        }

        static char GetSymbol(string expression)
        {            
            foreach (Symbol symbol in Symbols)
            {
                if(expression.Contains(symbol.SymbolChar))
                {
                    return symbol.SymbolChar;
                }
            }
            return '?';
        }

        static float GetLeftValue(string expression, char symbol)
        {
            float leftValue = 0f;
            if(symbol == '?')
            {
                return float.Parse(expression);
            }

            leftValue = float.Parse(expression.Substring(0, expression.IndexOf(symbol)));

            return leftValue;
        }

        static float GetRightValue(string expression, char symbol)
        {
            if (symbol == '?')
            {
                return 0f;
            }

            int symbolIndex = expression.IndexOf(symbol);
            int expressionRemainder = expression.Length - 1;
            
            expression = expression.Substring(symbolIndex + 1, expressionRemainder - symbolIndex);

            return(float.Parse(expression));

        }
    }
}
