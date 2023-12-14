using Task3.Model;

namespace Task3.Controller
{
    public static class Parsers
    {

        class Symbol {
            internal char SymbolChar { get; set; }
            internal int Priority { get; set; }
         }

        static Symbol[] Symbols = new Symbol[]{
            new Symbol { SymbolChar = '*', Priority = 1},
            new Symbol { SymbolChar = '/', Priority = 1},
            new Symbol { SymbolChar = '+', Priority = 2},
            new Symbol { SymbolChar = '-', Priority = 2},         
        };

        static string brackets = "()";
        
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
            ExpressionModel currentExpression = new ExpressionModel();
            
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

                if(firstSymbolIndex == -1 && currentSymbolIndex != -1)
                {
                    firstSymbolIndex = currentSymbolIndex;
                    string remaining = expression.Substring(firstSymbolIndex + 1);

                    if (remaining.Contains(symbol.SymbolChar))
                    {
                        //make sure negative / positive signs aren't replaced accidentally;
                        int remainingIndex = expression.Remove(firstSymbolIndex, 1).IndexOf(symbol.SymbolChar) + 1;
                        if (remainingIndex < subStringEndIndex && (expression[firstSymbolIndex + 1] != symbol.SymbolChar))
                        {
                            subStringEndIndex = remainingIndex;
                        }
                        previousSymbolPriority = symbol.Priority;
                        continue;
                    }
                }

                if(firstSymbolIndex == -1 || currentSymbolIndex == -1)
                {
                    previousSymbolPriority = symbol.Priority;
                    continue;
                }

                // get first symbol after currently found symbol; make sure negative / positive signs aren't replaced accidentally;
                if (currentSymbolIndex > firstSymbolIndex && currentSymbolIndex < subStringEndIndex && !(Symbols.Select(x => x.SymbolChar).Contains(expression[currentSymbolIndex-1])))
                {
                    subStringEndIndex = currentSymbolIndex;
                }else if (symbol.Priority == previousSymbolPriority)
                {
                    subStringEndIndex = firstSymbolIndex;
                    subStringStartIndex = 0;
                    previousSymbolPriority = symbol.Priority;
                    continue;
                }

                // get first symbol before currently found symbol
                if (currentSymbolIndex < firstSymbolIndex && currentSymbolIndex > subStringStartIndex)
                {
                    subStringStartIndex = currentSymbolIndex + 1;
                }
                previousSymbolPriority = symbol.Priority;
            }

            string returnString = expression.Substring(subStringStartIndex, subStringEndIndex - subStringStartIndex);

            return returnString;
        }

        public static ExpressionModel GetResults(string expression)
        {
            ExpressionModel result = new ExpressionModel();

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


        public static ExpressionModel GetExpressionModelFromString(string expression)
        {
            ExpressionModel expressionModel = new ExpressionModel();
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
