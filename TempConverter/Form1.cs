namespace TempConverter_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // initialize combo boxes with 1st unit in list
            cmbInitialUnit.SelectedIndex = 0;
            cmbFinalUnit.SelectedIndex = 0;

        }

        /*
         * KeyDown event-handler method: validate user input for txtBoxInput
         */
        private void txtBoxInput_KeyDown(object sender, KeyEventArgs e)
        {

            // get the pressed-keys' value and the current txtBoxInput text
            int pressedKey = int.Parse(e.KeyValue.ToString());
            string currentInput = txtBoxInput.Text;

            // valid values
            int[] validValues = { 96, 97, 98, 99, 100, 101, 102, 103, 04, 105,
                                    48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 8};

            // if key press is 190 ( a decimal point) make sure the text box doesn't already have one
            if ((pressedKey == 190 || pressedKey == 110) && (currentInput.Contains('.') == false))
            {

            }
            // if the pressedKey is one of the valid values (values in the Array), allow it
            else if (validValues.Contains(pressedKey))
            {

            }
            // ignore any other keys
            else
            {
                e.SuppressKeyPress = true;
            }


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // get current input textbox text, initial and final temp units
            string input = txtBoxInput.Text;
            char initialTempUnit = cmbInitialUnit.Text[0];
            char finalTempUnit = cmbFinalUnit.Text[0];

            // ternary operator: if textbox is empty, default value for input is 0
            input = (input == "") ? ("0") : (input);

            // convert input (string) to a number
            double initialTemp = Double.Parse(input);
            double finalTemp = 0.0;



            // which formula do we use? initialTempUnit --> finalTempUnit (6 formulas)

            // edge-case: both units are the same
            if (initialTempUnit == finalTempUnit)
            {
                finalTemp = initialTemp;
            }
            // initialTempUnit is Fahrenheit
            else if (initialTempUnit == 'F')
            {
                if (finalTempUnit == 'C')
                {
                    // F --> C
                    finalTemp = (initialTemp - 32.0) * (5.0 / 9.0);

                }
                else
                {
                    // F --> K
                    finalTemp = (initialTemp + 459.67) * (5.0 / 9.0);
                }
            }
            // initialTempUnit is Celsius
            else if (initialTempUnit == 'C')
            {
                if (finalTempUnit == 'F')
                {
                    // C --> F
                    finalTemp = (initialTemp * (9.0 / 5.0)) + 32.0;
                }
                else
                {
                    // C --> K
                    finalTemp = initialTemp + 273.15;
                }
            }
            // initialTempUnit is Kelvin
            else
            {
                if (finalTempUnit == 'F')
                {
                    // K --> F
                    finalTemp = (initialTemp * (9.0 / 5.0)) - 459.67;
                }
                else
                {
                    // K --> C
                    finalTemp = initialTemp - 273.15;
                }
            }

            // send finalTemp to txtBoxOutput to display to user
            txtBoxOutput.Text = Math.Round(finalTemp, 2).ToString();
        }
    }
}