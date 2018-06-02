using System;

namespace Calculator
{
    internal sealed class Operand
    {
        private readonly int value;

        public Operand(int value)
        {
            this.value = value;
        }

        public Operand(string value)
        {
            this.value = Convert.ToInt32(value);
        }

        public int Value { get => value; }

        public override string ToString()
        {
            return value.ToString();
        }

        public static Operand operator +(Operand first, Operand second)
        {
            return new Operand(first.value + second.value);
        }

        public static Operand operator -(Operand first, Operand second)
        {
            return new Operand(first.value - second.value);
        }

        public static Operand operator *(Operand first, Operand second)
        {
            return new Operand(first.value * second.value);
        }

        public static Operand operator /(Operand first, Operand second)
        {
            return new Operand(first.value / second.value);
        }
    }
}