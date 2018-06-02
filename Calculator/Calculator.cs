namespace Calculator
{
    internal static class Calculator
    {
        public static Operand Calculate(Operand first, Operand second, Operation operation)
        {
            Operand result = null;

            switch (operation.Value)
            {
                case '+':
                    result = first + second;
                    break;
                case '-':
                    result = first - second;
                    break;
                case '*':
                    result = first * second;
                    break;
                case '/':
                    result = first / second;
                    break;
            }
            return result;
        }
    }
}