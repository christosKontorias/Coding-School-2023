using CalculatorLibrary;

namespace Sessions_09
{
    public partial class Form1 : Form
    {
        private decimal? _value1 = null;
        private decimal? _value2 = null;
        private decimal? _result = null;
        private CalcOperation _calcOperation;

        private bool _isOperatorSet = false;


        enum CalcOperation
        {
            Addition,
            Subtraction,
            Multiplication,
            Division,
            Power,
            SquareRoot
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " = ";

            switch (_calcOperation)
            {
                case CalcOperation.Addition:
                    CheckOperation();
                    Addition addition = new Addition();
                    _result = addition.Do(_value1, _value2);
                    break;

                case CalcOperation.Subtraction:
                    CheckOperation();
                    Subtraction subtraction = new Subtraction();
                    _result = subtraction.Do(_value1, _value2);
                    break;

                case CalcOperation.Multiplication:
                    CheckOperation();
                    Multiplication multiplication = new Multiplication();
                    _result = multiplication.Do(_value1, _value2);
                    break;

                case CalcOperation.Division:
                    CheckOperation();
                    Division division = new Division();
                    _result = division.Do(_value1, _value2);
                    break;

                case CalcOperation.Power:
                    Power power = new Power();
                    break;

                case CalcOperation.SquareRoot:
                    SquareRoot squareRoot = new SquareRoot();
                    break;

                default:
                    break;
            }

            ctrlDisplay.Text += _result;
        }
        private void SetValues(decimal value)
        {
            ClearValues();
            if (_value1 == null)
            {
                _value1 = value;
            }
            else
            {
                _value2 = value;
            }
        }

        private void CheckOperation()
        {
            // perform the calculation
            _isOperatorSet = false;
            btnAddition.Enabled = true;
            btnSubtraction.Enabled = true;
            btnMultiplication.Enabled = true;
            btnDivision.Enabled = true;
            btnSquareRoot.Enabled = true;
            btnPower.Enabled = true;
            // enable other operator buttons
        }

        private void ClearValues()
        {
            if (_result != null)
            {
                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            ClearValues();
            ctrlDisplay.Text += " 0 ";
            SetValues(0);
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            ClearValues();
            ctrlDisplay.Text += " 1 ";
            SetValues(1);
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            ClearValues();
            ctrlDisplay.Text += " 2 ";
            SetValues(2);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            ClearValues();
            ctrlDisplay.Text += " 3 ";
            SetValues(3);
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            ClearValues();
            ctrlDisplay.Text += " 4 ";
            SetValues(4);
        }
        private void btnFive_Click(object sender, EventArgs e)
        {
            ClearValues();
            ctrlDisplay.Text += " 5 ";
            SetValues(5);
        }
        private void btnSix_Click(object sender, EventArgs e)
        {
            ClearValues();
            ctrlDisplay.Text += " 6 ";
            SetValues(6);
        }
        private void btnSeven_Click(object sender, EventArgs e)
        {
            ClearValues();
            ctrlDisplay.Text += " 7 ";
            SetValues(7);
        }
        private void btnEight_Click(object sender, EventArgs e)
        {
            ClearValues();
            ctrlDisplay.Text += " 8 ";
            SetValues(8);
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            ClearValues();
            ctrlDisplay.Text += " 9 ";
            SetValues(9);
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            if (!_isOperatorSet)
            {
                ctrlDisplay.Text += " + ";
                _calcOperation = CalcOperation.Addition;
                _isOperatorSet = true;
                btnAddition.Enabled = false;
                btnSubtraction.Enabled = false;
                btnMultiplication.Enabled = false;
                btnDivision.Enabled = false;
                btnSquareRoot.Enabled = false;
                btnPower.Enabled = false;
                //disable other operator buttons
            }
        }


        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            if (!_isOperatorSet)
            {
                ctrlDisplay.Text += " - ";
                _calcOperation = CalcOperation.Subtraction;
                _isOperatorSet = true;
                btnAddition.Enabled = false;
                btnSubtraction.Enabled = false;
                btnMultiplication.Enabled = false;
                btnDivision.Enabled = false;
                btnSquareRoot.Enabled = false;
                btnPower.Enabled = false;
                //disable other operator buttons
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (!_isOperatorSet)
            {
                ctrlDisplay.Text += " * ";
                _calcOperation = CalcOperation.Multiplication;
                btnAddition.Enabled = false;
                btnSubtraction.Enabled = false;
                btnMultiplication.Enabled = false;
                btnDivision.Enabled = false;
                btnSquareRoot.Enabled = false;
                btnPower.Enabled = false;
                //disable other operator buttons
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (!_isOperatorSet)
            {
                ctrlDisplay.Text += " / ";
                _calcOperation = CalcOperation.Division;
                btnAddition.Enabled = false;
                btnSubtraction.Enabled = false;
                btnMultiplication.Enabled = false;
                btnDivision.Enabled = false;
                btnSquareRoot.Enabled = false;
                btnPower.Enabled = false;
                //disable other operator buttons
            }
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            try
            {
                double ans = Math.Pow(Double.Parse(ctrlDisplay.Text), 2);
                ctrlDisplay.Text = ans.ToString();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            //_calcOperation = CalcOperation.Power;
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            try
            {
                double ans = Math.Sqrt(Double.Parse(ctrlDisplay.Text));
                ctrlDisplay.Text = ans.ToString();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            //_calcOperation = CalcOperation.SquareRoot;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text = "";
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text = ctrlDisplay.Text.Remove(ctrlDisplay.Text.Length - 2);
        }
    }
}
