using System;

namespace Calculator
{
    internal struct Operation
    {
        private readonly char operation;

        public Operation(string operation)
        {
            this.operation = Convert.ToChar(operation);
        }

        public Operation(char operation)
        {
            this.operation = operation;
        }

        public int Value { get => operation; }

        public override string ToString()
        {
            return operation.ToString();
        }
    }
}