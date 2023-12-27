using Task3.View;
using static Task3.Controller.ParserTools;

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
            char nextExpressionSymbol = '?';
            (string, char) expressionSymbolPair;
            Expression currentExpression = new Expression();
            
            while (!finalExpression)
            {
                expressionSymbolPair = GetNextExpressionWithSymbol(expression);
                nextExpression = expressionSymbolPair.Item1;
                nextExpressionSymbol = expressionSymbolPair.Item2;

                if (expression == nextExpression)
                {
                    finalExpression = true;
                }
                currentExpression = Calculations.CalculateExpression(nextExpression, nextExpressionSymbol);
                expression = expression.Replace(nextExpression, currentExpression.Result.ToString());
            }

            return expression;
        }



        public static (string, char) GetNextExpressionWithSymbol(string expression)
        {
            int firstSymbolIndex = -1;
            int currentSymbolIndex = -1;
            int previousSymbolPriority = 1;
            char firstSymbol = '?';
            (int, int) startEndIndex = (0, expression.Length);


            foreach (Symbol symbol in Symbols)
            {
                currentSymbolIndex = expression.IndexOf(symbol.SymbolChar);

                
                currentSymbolIndex = GetRemainingSymbolIndex(expression, currentSymbolIndex, symbol.SymbolChar);
                

                if (currentSymbolIndex < 1) continue;

                if (firstSymbolIndex == -1)
                {
                    firstSymbolIndex = currentSymbolIndex;
                    firstSymbol = symbol.SymbolChar;
                }

                if (firstSymbolIndex == -1 || currentSymbolIndex == -1)
                {
                    continue;
                }

                startEndIndex = GetClosestSymbolsToAnchor(expression, firstSymbolIndex, startEndIndex, symbol.SymbolChar);           

                previousSymbolPriority = symbol.Priority;
            }

            
            string returnString = expression.Substring(startEndIndex.Item1, startEndIndex.Item2 - startEndIndex.Item1);

            return (returnString, firstSymbol);
        }       

    public static Expression GetResults(string expression)
        {
            Expression result = new Expression();

            expression = expression.Replace(" ", "");

            if (expression.Contains('('))
            {
                expression = GetNextBracketExpression(expression);
            }

            (string, char) expressionSymbolPair = GetNextExpressionWithSymbol(expression);

            expression = expressionSymbolPair.Item1;
            char symbol = expressionSymbolPair.Item2;

            result = Calculations.CalculateExpression(expression, symbol);

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

        public static Expression GetExpressionModelFromString(string expression, char symbol)
        {
            Expression expressionModel = new Expression();
            expression = expression.Replace(" ", "");

            float leftValue = GetLeftValue(expression, symbol);
            float rightValue = GetRightValue(expression, symbol);

            expressionModel.LeftHandSide = leftValue;
            expressionModel.RightHandSide = rightValue;
            expressionModel.Symbol = symbol == '?' ? '+' : symbol;

            return expressionModel;
        }

        static float GetLeftValue(string expression, char symbol)
        {
            float leftValue = 0f;
            if(symbol == '?')
            {
                return float.Parse(expression);
            }

            if (expression[0] == '-')
            {
                return float.Parse(expression.Substring(0, expression.Substring(1).IndexOf(symbol) + 1));
            }

            return float.Parse(expression.Substring(0, expression.IndexOf(symbol)));

        }

        static float GetRightValue(string expression, char symbol)
        {
            if (symbol == '?')
            {
                return 0f;
            }

            int symbolIndex = expression.IndexOf(symbol);
            int expressionRemainder = expression.Length - 1;

            if (expression[0] == '-')
            {
                symbolIndex = expression.Substring(1).IndexOf(symbol) + 1;
            }
            
            expression = expression.Substring(symbolIndex + 1, expressionRemainder - symbolIndex);

            return(float.Parse(expression));

        }
    }
}
