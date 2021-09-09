using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XanderToolz
{
    public partial class Form1 : Form
    {
        Double resultsValue = 0;
        String OperatorType = "";
        String Tip = "";
        bool isOperatorType = false;
        bool isEqualPerformed = false;
        Double tip15 = 0.15;
        Double tip18 = 0.18;
        Double tip20 = 0.20;
        Double totalTip15 = 1.15;
        Double totalTip18 = 1.18;
        Double totalTip20 = 1.20;
        
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonDown(object sender, EventArgs e)
        {


            if ((resultBox.Text == "0") || (isOperatorType))
                resultBox.Clear();
            isOperatorType = false;
            Button button = (Button)sender;

            if (isEqualPerformed == true) // Attempt to clear out Display and Results after Equal Button is pressed
            {
                resultBox.Clear();
                DisplayOperation.Text = "";
                resultsValue = 0;
                isEqualPerformed = false;
            }
            if (button.Text == ".")
            {
                if (!resultBox.Text.Contains("."))
                    resultBox.Text = resultBox.Text + button.Text;
            }
            else
                resultBox.Text = resultBox.Text + button.Text;

        }

        private void Operator(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultsValue != 0)
            {
                //button10.PerformClick(); // Performs the Equal Method   
                MathEquation();
                OperatorType = button.Text;
                DisplayOperation.Text = resultsValue + " " + OperatorType;
                isOperatorType = true;
            }
            else
            {
                OperatorType = button.Text;
                resultsValue = Double.Parse(resultBox.Text);
                DisplayOperation.Text = resultsValue + " " + OperatorType;
                isOperatorType = true;
            }
        }

        private void Equal(object sender, EventArgs e)
        {
            MathEquation();
            DisplayOperation.Text = "";
            isEqualPerformed = true; 

            //if (button10.Text == "=")
            //{
            //    isEqualPerformed = true; // Need to turn on when Equal Button is pressed down     
            //}

        }

        private void MathEquation()
        {
            switch (OperatorType)
            {
                case "+":
                    resultBox.Text = (resultsValue + Double.Parse(resultBox.Text)).ToString();
                    break;
                case "-":
                    resultBox.Text = (resultsValue - Double.Parse(resultBox.Text)).ToString();
                    break;
                case "x":
                    resultBox.Text = (resultsValue * Double.Parse(resultBox.Text)).ToString();
                    break;
                case "/":
                    resultBox.Text = (resultsValue / Double.Parse(resultBox.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultsValue = Double.Parse(resultBox.Text);
            
        }
        private void ClearDisplay(object sender, EventArgs e)
        {
            resultBox.Text = "0";
            TotalTip.Text = "";
        }

        private void ResetClear(object sender, EventArgs e)
        {
            resultBox.Text = "0";
            DisplayOperation.Text = "";
            resultsValue = 0;
            TotalTip.Text = "";
        }

        private void TipCal (object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Tip = button.Text;
            resultsValue = Double.Parse(resultBox.Text);

            switch (Tip)
                {
                    case "15%":                                      
                        resultBox.Text = (resultsValue * tip15).ToString();
                        TotalTip.Text = (resultsValue * totalTip15).ToString(format: "0.##");
                    break;
                    case "18%":
                        resultBox.Text = (resultsValue * tip18).ToString();
                        TotalTip.Text = (resultsValue * totalTip18).ToString(format: "0.##");
                    break;
                    case "20%":
                        resultBox.Text = (resultsValue * tip20).ToString();
                        TotalTip.Text = (resultsValue * totalTip20).ToString(format: "0.##");
                    break;
                    default:
                        break;
                }
        }
        //////////////////
        ///Calculator 2///
        //////////////////

        private void buttonDown2(object sender, EventArgs e)
        {

            if ((resultBox2.Text == "0") || (isOperatorType))
                resultBox2.Clear();
            isOperatorType = false;
            Button button = (Button)sender;

            if (isEqualPerformed == true) // Attempt to clear out Display and Results after Equal Button is pressed
            {
                resultBox2.Clear();
                DisplayOperation2.Text = "";
                resultsValue = 0;
                isEqualPerformed = false;
            }
            if (button.Text == ".")
            {
                if (!resultBox2.Text.Contains("."))
                    resultBox2.Text = resultBox2.Text + button.Text;
            }
            else
                resultBox2.Text = resultBox2.Text + button.Text;

        }

        private void Operator2(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultsValue != 0)
            {
                //button10.PerformClick(); // Performs the Equal Method   
                MathEquation();
                OperatorType = button.Text;
                DisplayOperation2.Text = resultsValue + " " + OperatorType;
                isOperatorType = true;
            }
            else
            {
                OperatorType = button.Text;
                resultsValue = Double.Parse(resultBox.Text);
                DisplayOperation2.Text = resultsValue + " " + OperatorType;
                isOperatorType = true;
            }
        }

        private void Equal2(object sender, EventArgs e)
        {
            MathEquation();
            DisplayOperation2.Text = "";
            isEqualPerformed = true;

            //if (button10.Text == "=")
            //{
            //    isEqualPerformed = true; // Need to turn on when Equal Button is pressed down     
            //}

        }

       private void TipCal2(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Tip = button.Text;
            resultsValue = Double.Parse(resultBox.Text);

            switch (Tip)
            {
                case "15%":
                    resultBox2.Text = (resultsValue * tip15).ToString();
                    TotalTip.Text = (resultsValue * totalTip15).ToString(format: "0.##");
                    break;
                case "18%":
                    resultBox2.Text = (resultsValue * tip18).ToString();
                    TotalTip.Text = (resultsValue * totalTip18).ToString(format: "0.##");
                    break;
                case "20%":
                    resultBox2.Text = (resultsValue * tip20).ToString();
                    TotalTip.Text = (resultsValue * totalTip20).ToString(format: "0.##");
                    break;
                default:
                    break;
            }
        }
    }
}
