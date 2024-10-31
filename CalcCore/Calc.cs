namespace CalcCore
{
    public class Calc
    {
        public double Display { get; private set; }

        private char? _operation = null;
        private double? _operand1 = null;
        private double? _operand2 = null;
        private bool _isNewInput = true;

        public void Input(char argument)
        {
            if (char.IsDigit(argument) || argument == '.')
            {
                InputDigit(argument);
            }
            else if (IsOperation(argument))
            {
                InputOperation(argument);
            }
            else if (argument == '=')
            {
                Calculate();
            }
            else if (argument == 'C')
            {
                Clear();
            }
            else if (argument == '←')
            {
                Backspace();
            }
            else if (argument == '±')
            {
                ChangeSign();
            }
        }

        private void InputDigit(char digit)
        {
            if (_isNewInput && _operand1.HasValue && _operation.HasValue && _operand2.HasValue)
            {
               Clear();
            }
            
            if (_isNewInput)
            {
                Display = char.GetNumericValue(digit);
                _isNewInput = false;
            }
            else
            {
                string currentDisplay = Display.ToString();
                if (digit == '.' && !currentDisplay.Contains('.'))
                {
                    Display = double.Parse(currentDisplay,);
                    //Convert
                }
                else if (digit != '.')
                {
                    Display = double.Parse(currentDisplay + digit);
                }
            }
        }

        private void InputOperation(char operation)
        {
            if (_operand1.HasValue && !_isNewInput)
            {
                Calculate();
            }
            _operand1 = Display;
            _operation = operation;
            _isNewInput = true;
        }

        private void Calculate()
        {
            if (!_operation.HasValue) return;

            if (!_operand2.HasValue)
            {
                _operand2 = Display;
            }

            switch (_operation)
            {
                case '+':
                    Display = _operand1.Value + _operand2.Value;
                    break;
                case '-':
                    Display = _operand1.Value - _operand2.Value;
                    break;
                case '*':
                    Display = _operand1.Value * _operand2.Value;
                    break;
                case '%':
                    CalculatePercentage();
                    break;
                case '/':
                    if (_operand2.Value != 0)
                    {
                        Display = _operand1.Value / _operand2.Value;
                    }
                    else
                    {
                        Display = 0; // Обработка нуля
                    }
                    break;
                case '√':
                    CalculateRoot();
                    break;
                case '¼':
                    CalculateReciprocal();
                    break;
                case '²':
                    CalculateSquare();
                    break;
            }

            _operand1 = Display;
            _isNewInput = true;
        }

        private void CalculatePercentage()
        {
            if (_operand1.HasValue)
            {
                Display = _operand1.Value * (Display / 100);
                _isNewInput = false;
            }
        }

        private void CalculateRoot()
        {
            if (Display >= 0)
            {
                Display = Math.Sqrt(Display);
            }
            else
            {
                Display = 0; // Обработка отрицательного корня
            }
            _isNewInput = false;
        }

        private void CalculateSquare()
        {
            if (Display >= 0)
            {
                Display = Math.Pow(Display, 2);
            }
            else
            {
                Display = 0; // Обработка Квадрата нуля
            }
            _isNewInput = false;
        }

        private void CalculateReciprocal()
        {
            if (Display != 0)
            {
                Display = 1 / Display;
            }
            else
            {
                Display = 0; // Обработка нуля
            }
            _isNewInput = false;
        }

        private void Clear()
        {
            Display = 0;
            _operand1 = null;
            _operand2 = null;
            _operation = null;
            _isNewInput = true;
        }

        private void Backspace()
        {
            if (!_isNewInput)
            {
                string currentDisplay = Display.ToString();
                if (currentDisplay.Length > 1)
                {
                    Display = double.Parse(currentDisplay.Substring(0, currentDisplay.Length - 1));
                }
                else
                {
                    Display = 0;
                    _isNewInput = true;
                }
            }
        }

        private void ChangeSign()
        {
            Display = -Display;
        }

        private bool IsOperation(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/' || c == '%' || c == '√' || c == '¼' || c == '²';
        }
    }
}