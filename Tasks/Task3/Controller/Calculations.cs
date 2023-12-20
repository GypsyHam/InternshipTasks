using Task3.View;


namespace Task3.Controller
{
    public static class Calculations
    {
        public static Expression CalculateExpression(string expression)
        {
            Expression expressionModel = Parsers.GetExpressionModelFromString(expression);
             
            switch (expressionModel.Symbol)
            {
                case '+':
                    expressionModel.Result = Add(expressionModel.LeftHandSide, expressionModel.RightHandSide);
                    break;
                case '-':
                    expressionModel.Result = Subtract(expressionModel.LeftHandSide, expressionModel.RightHandSide);
                    break;
                case '*':
                    expressionModel.Result = Multiply(expressionModel.LeftHandSide, expressionModel.RightHandSide);
                    break;
                case '/':
                    expressionModel.Result = Divide(expressionModel.LeftHandSide, expressionModel.RightHandSide);
                    break;
            default:
                break;
            }

            return expressionModel;
        }



        static float Add(float LeftValue, float RightValue)
        {
            return LeftValue + RightValue;
        }

        static float Subtract(float LeftValue, float RightValue)
        {
            return LeftValue - RightValue;
        }

        static float Multiply(float LeftValue, float RightValue)
        {
            return LeftValue * RightValue;
        }

        static float Divide(float LeftValue, float RightValue)
        {
            if(RightValue == 0)
            {
                throw new InvalidOperationException("Cannot divide by zero.");
            }

            return LeftValue / RightValue;
        }
    }
}
