using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculator.Managers
{
    internal interface IButtonProvider
    {
        IEnumerable<Button> Buttons { get; }
    }
}