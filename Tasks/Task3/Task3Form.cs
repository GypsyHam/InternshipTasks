using Task3.Controller;

namespace Task3
{
    public partial class Task3Form : Form
    {
        public Task3Form()
        {
            InitializeComponent();
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            //ExpressionModel expressionModel = Parsers.GetResults(txtRawExpression.Text);

            List<string> expressions = Parsers.GetAllExpressionsForCompare(txtRawExpression.Text);

            lblEvaluatedValue.Text = string.Join(" = ", expressions);

            if (Parsers.IsExpressionValid(expressions))
            {
                lblResultValue.Text = "Expression is valid.";
            }
            else
            {
                lblResultValue.Text = "Expression is not valid.";
            }

        }

        private void txtRawExpression_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedCharacters = "0123456789*/+-()";

            if (!allowedCharacters.Contains(char.ToUpper(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Invalid key pressed. Only use numbers or arithmatic symbols [*, +, /, -, (, )]");
            }
        }
    }
}