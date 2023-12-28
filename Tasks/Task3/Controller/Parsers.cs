using Task3.View;
using static Task3.Controller.ParserTools;

namespace Task3.Controller
{
    public static class Parsers
    {
        static string symbols = "*/-+";

        
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
            char firstSymbol = '?';
            (int, int) startEndIndex = (0, expression.Length);


            foreach (char symbol in symbols)
            {
                currentSymbolIndex = expression.IndexOf(symbol);
                
                currentSymbolIndex = GetRemainingSymbolIndex(expression, currentSymbolIndex, symbol);

                if (currentSymbolIndex < 1) continue;

                if (firstSymbolIndex == -1)
                {
                    firstSymbolIndex = currentSymbolIndex;
                    firstSymbol = symbol;
                }

                if (firstSymbolIndex == -1 || currentSymbolIndex == -1)
                {
                    continue;
                }

                startEndIndex = GetClosestSymbolsToAnchor(expression, firstSymbolIndex, startEndIndex, symbol);           
            }

            
            string returnString = expression.Substring(startEndIndex.Item1, startEndIndex.Item2 - startEndIndex.Item1);

            return (returnString, firstSymbol);
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
