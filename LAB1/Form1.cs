using System;
using System.Xml;

namespace LAB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = string.Empty;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //userinput = textBoxInput.Text
            //datatype
            //string = ข้อความ
            //in = integer ตัวเลข
            //double = ทศนิยม
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "Number...";
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "1";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "2";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "3";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "4";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "5";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "6";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "7";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "9";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "0";

        }
        //globle variable
        string number1 = string.Empty;
        string number2 = string.Empty;
        String operation = string.Empty;
        private void button12_Click(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
            operation = "-";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
            operation = "+";
        }
        //ปุุ่มเท่ากับ
        private void button15_Click(object sender, EventArgs e)
        {
            string number2 = textBoxInput.Text;
            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);
            float output = 0;
            if (operation == "+")
            {
                output = num1 + num2;
            }
            if (operation == "-")
            {
                output = num1 - num2;
            }
            if (operation == "*")
            {
                output = num1 * num2;
            }
            if (operation == "/")
            {
                output = num1 / num2;
            }
            output.ToString();

            textBoxInput.Text = output.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
            operation = "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
            operation = "/";
        }
    }
}

