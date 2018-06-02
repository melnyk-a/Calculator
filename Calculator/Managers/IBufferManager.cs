namespace Calculator.Managers
{
    internal interface IBufferManager
    {
        string Buffer { get; }

        void Append(char value);
        void Append(string value);
        void Clear();
    }
}