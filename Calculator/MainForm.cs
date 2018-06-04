using Calculator.Managers;
using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        private readonly IBufferManager bufferManager = new BufferManager();
        private readonly IOperandManager operandManager = new OperandManager();
        private readonly IButtonProvider operantionButtonProvider;
        private Operation operation;

        public MainForm()
        {
            InitializeComponent();

            operantionButtonProvider = new OperationButtonProvider(new[] {
                plusButton,
                minusButton,
                multiplyButton,
                divideButton
            });
        }
        #region Handlers
        private void CleanButton_Click(object sender, EventArgs e)
        {
            ProcessClear();
            ActiveControl = null;
        }

        private void CurrentInputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (operandManager.First == null && bufferManager.Buffer.Length > 0)
            {
                EnableOptionsButton(true);
                resultButton.Enabled = false;
            }
            else if (operandManager.First != null && bufferManager.Buffer.Length > 0)
            {
                resultButton.Enabled = true;
                previousInputLabel.Text = null;
            }
        }

        private void DigitButton_Click(object sender, EventArgs e)
        {
            string text = ((Button)sender).Text;
            ProcessDigitInput(text);
            ActiveControl = null;
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                ProcessDigitInput(e.KeyChar.ToString());
            }
            else if (e.KeyChar == '-' || e.KeyChar == '+' || e.KeyChar == '*' || e.KeyChar == '/')
            {
                bool isOperationEnable = false;
                foreach (Button button in operantionButtonProvider.Buttons)
                {
                    isOperationEnable = isOperationEnable | button.Enabled;
                }
                if (isOperationEnable)
                {
                    ProcessOperationInput(e.KeyChar.ToString());
                }
            }
            else if (e.KeyChar == '\r')
            {
                if (resultButton.Enabled)
                {
                    ProcessResult();
                }
            }
            else if (e.KeyChar == '\b')
            {
                ProcessClear();
            }
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            ProcessOperationInput(((Button)sender).Text);
            ActiveControl = null;
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            ProcessResult();
            ActiveControl = null;
        }
        #endregion

        private void ProcessClear()
        {
            bufferManager.Clear();
            currentInputTextBox.Text = null;
            EnableOptionsButton(false);
            if (operandManager.First != null)
            {
                resultButton.Enabled = false;
            }
        }

        private void ProcessDigitInput(string input)
        {
            if (bufferManager.Buffer.StartsWith(button0.Text))
            {
                bufferManager.Clear();
            }
            bufferManager.Append(input);
            currentInputTextBox.Text = bufferManager.Buffer;
            if (operandManager.First != null)
            {
                previousInputLabel.Text = $"{operandManager.First}{operation}";
            }
        }

        private void ProcessOperationInput(string input)
        {
            operation = new Operation(input);
            operandManager.First = new Operand(bufferManager.Buffer);

            bufferManager.Clear();
            currentInputTextBox.Text = bufferManager.Buffer;
            previousInputLabel.Text = $"{operandManager.First}{operation}";

            EnableOptionsButton(false);
        }

        private void ProcessResult()
        {
            operandManager.Second = new Operand(bufferManager.Buffer);
            Operand result = Calculator.Calculate(operandManager.First, operandManager.Second, operation);
            currentInputTextBox.Text = result.ToString();

            bufferManager.Clear();
            operandManager.First = null;
            operandManager.Second = null;
            resultButton.Enabled = false;
        }

        private void EnableOptionsButton(bool enabled)
        {
            foreach (Button button in operantionButtonProvider.Buttons)
            {
                button.Enabled = enabled;
            }
        }
    }
}