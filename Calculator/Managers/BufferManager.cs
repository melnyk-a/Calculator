using System.Text;

namespace Calculator.Managers
{
    internal sealed class BufferManager : IBufferManager
    {
        private StringBuilder buffer = new StringBuilder();

        public string Buffer => buffer.ToString();

        public void Append(char value)
        {
            buffer.Append(value);
        }

        public void Append(string value)
        {
            buffer.Append(value);
        }

        public void Clear()
        {
            buffer.Clear();
        }
    }
}
