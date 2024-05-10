namespace calculater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string calTotal;
        int num1;
        int num2;
        string option;
        int result;
        bool isOperationPerformed = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            texDisplay.Text = texDisplay.Text + btn1.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(texDisplay.Text);

            texDisplay.Clear();
            lbl1.Text = num1 + " " + option;
            isOperationPerformed = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            texDisplay.Text = texDisplay.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            texDisplay.Text = texDisplay.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            texDisplay.Text = texDisplay.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            texDisplay.Text = texDisplay.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            texDisplay.Text = texDisplay.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            texDisplay.Text = texDisplay.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            texDisplay.Text = texDisplay.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            texDisplay.Text = texDisplay.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            texDisplay.Text = texDisplay.Text + btn0.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(texDisplay.Text);

            texDisplay.Clear();
            lbl1.Text = num1 + " " + option;
             isOperationPerformed = true;
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(texDisplay.Text);

            texDisplay.Clear();
            lbl1.Text = num1 + " " + option;
            isOperationPerformed = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(texDisplay.Text);

            texDisplay.Clear();
            lbl1.Text = num1 + " " + option;
            isOperationPerformed = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(texDisplay.Text);

            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("*"))
                result = (num1 * num2);

            if (option.Equals("/"))
                result = (num1 / num2);

            texDisplay.Text = result + " ";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            texDisplay.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void texDisplay_TextChanged(object sender, EventArgs e)
        {
            if (texDisplay.Text == "0")
                texDisplay.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            texDisplay.Text = "0";
        }
    }
}
