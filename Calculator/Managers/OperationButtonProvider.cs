using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculator.Managers
{
    internal sealed class OperationButtonProvider : IButtonProvider
    {
        private IEnumerable<Button> buttons;

        public OperationButtonProvider(IEnumerable<Button> buttons)
        {
            this.buttons = buttons;
        }

        public IEnumerable<Button> Buttons => buttons;
    }
}