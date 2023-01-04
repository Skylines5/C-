namespace calc
{
    public partial class Form1 : Form
    {

        private decimal previousValue;
        private decimal currentValue;
        private string _operation = "";
        private string calc = "";
        

        public Form1()
        {
            InitializeComponent();
        }



        public void NumberBtn_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            prevValLabel.Text = $"{previousValue.ToString()} {_operation}";

            calculatorScreen.Text += btn.Text;
        }

        public void HandleOperation(object sender, EventArgs e)
        {

            var btn = (Button)sender;

            if (calculatorScreen.Text == "")
            {
                return;
            }
            else if (_operation == "")
            {
                _operation = btn.Text;
                previousValue = decimal.Parse(calculatorScreen.Text);
                calculatorScreen.Text = "";
                prevValLabel.Text = $"{previousValue} {_operation}";
            }

        }


        public void EqualsBtn(object sender, EventArgs e)
        {

            currentValue = decimal.Parse(calculatorScreen.Text);

            switch (_operation)
            {
                case "+":
                    calc = (previousValue + currentValue).ToString();
                    break;
                case "-":
                    calc = (previousValue - currentValue).ToString();
                    break;
                case "/":
                    calc = (previousValue / currentValue).ToString();
                    break;
                case "*":
                    calc = (previousValue * currentValue).ToString();
                    break;
            }
            calculatorScreen.Text = "";
            prevValLabel.Text = $"{previousValue.ToString()} {_operation}{currentValue} = {calc}";
            previousValue = Decimal.Parse(calc);
            _operation = "";
        }

        public void Clear(object sender, EventArgs e) { 
            currentValue = 0;
            calculatorScreen.Text = "";
        }

        public void AllClear(object sender, EventArgs e)
        {
            currentValue = 0;
            previousValue = 0;
            calc = "";
            _operation = "";
            calculatorScreen.Text = "";
            prevValLabel.Text = "";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}