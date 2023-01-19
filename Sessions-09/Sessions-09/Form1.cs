using CalculatorLibrary;

namespace Sessions_09
{
    public partial class Form1 : Form
    {
        private decimal? _value1 = null;
        private decimal? _value2 = null;
        private decimal? _result = null;
        private CalcOperation _calcOperation;

        enum CalcOperation
        {
            Addition
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void ctrlDisplay_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " = ";

            switch (_calcOperation)
            {
                case CalcOperation.Addition:

                    Addition addition = new Addition();
                    _result = addition.Do(_value1, _value2);

                    break;

                default:
                    break;
            }

            ctrlDisplay.Text += _result;
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

    }
}