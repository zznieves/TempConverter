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
    }
}