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
        Double tip15 = 0.15, tip18 = 0.18, tip20 = 0.20;
        Double totalTip15 = 1.15, totalTip18 = 1.18, totalTip20 = 1.20;
        Double resultsValue2 = 0;
        String OperatorType = "";
        String Tip = "";
        String OperatorType2 = "";
        String Tip2 = "";
        bool isOperatorType2 = false;
        bool isEqualPerformed2 = false;
        bool isOperatorType = false;
        bool isEqualPerformed = false;
        int jobQty, everyPC, pcCalculate;


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

        private void TipCal(object sender, EventArgs e)
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
        /// <summary>
        /// Tab 2-Second Calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonDown2(object sender, EventArgs e)
        {

            if ((resultBox2.Text == "0") || (isOperatorType2))
                resultBox2.Clear();
            isOperatorType2 = false;
            Button button = (Button)sender;

            if (isEqualPerformed2 == true) // Attempt to clear out Display and Results after Equal Button is pressed
            {
                resultBox2.Clear();
                DisplayOperation2.Text = "";
                resultsValue2 = 0;
                isEqualPerformed2 = false;
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
            if (resultsValue2 != 0)
            {
                //button10.PerformClick(); // Performs the Equal Method   
                MathEquation2();
                OperatorType2 = button.Text;
                DisplayOperation2.Text = resultsValue2 + " " + OperatorType2;
                isOperatorType2 = true;
            }
            else
            {
                OperatorType2 = button.Text;
                resultsValue2 = Double.Parse(resultBox2.Text);
                DisplayOperation2.Text = resultsValue2 + " " + OperatorType2;
                isOperatorType2 = true;
            }
        }

        private void Equal2(object sender, EventArgs e)
        {
            MathEquation2();
            DisplayOperation2.Text = "";
            isEqualPerformed2 = true;
        }

        private void MathEquation2()
        {
            switch (OperatorType2)
            {
                case "+":
                    resultBox2.Text = (resultsValue2 + Double.Parse(resultBox2.Text)).ToString();
                    break;
                case "-":
                    resultBox2.Text = (resultsValue2 - Double.Parse(resultBox2.Text)).ToString();
                    break;
                case "x":
                    resultBox2.Text = (resultsValue2 * Double.Parse(resultBox2.Text)).ToString();
                    break;
                case "/":
                    resultBox2.Text = (resultsValue2 / Double.Parse(resultBox2.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultsValue2 = Double.Parse(resultBox2.Text);
        }
        private void TipCal2(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Tip2 = button.Text;
            resultsValue2 = Double.Parse(resultBox2.Text);


            switch (Tip2)
            {
                case "15%":
                    resultBox2.Text = (resultsValue2 * tip15).ToString();
                    TotalTip2.Text = (resultsValue2 * totalTip15).ToString(format: "0.##");
                    break;
                case "18%":
                    resultBox2.Text = (resultsValue2 * tip18).ToString();
                    TotalTip2.Text = (resultsValue2 * totalTip18).ToString(format: "0.##");
                    break;
                case "20%":
                    resultBox2.Text = (resultsValue2 * tip20).ToString();
                    TotalTip2.Text = (resultsValue2 * totalTip20).ToString(format: "0.##");
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Tab 3 - Manufacturing Calculations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void SamplingCalculation()
        {
            everyPC = Int32.Parse(inspectAmount.Text);
            pcCalculate = (jobQty / everyPC);

            everyxpcs.Text = pcCalculate + "";
            
        }
        private void finishButton(object sender, EventArgs e)
        {


            jobQty = Int32.Parse(JOQTY.Text);

            if (jobQty < 26)
            {
                inspectAmount.Text = "Inspect All";
            }
            else if (jobQty >= 26 && jobQty <= 280)
            {
                inspectAmount.Text = "32";
                SamplingCalculation();

            }
            else if (jobQty >= 281 && jobQty <= 500)
            {
                inspectAmount.Text = "48";
                SamplingCalculation();

            }
            else if (jobQty >= 501 && jobQty <= 3200)
            {
                inspectAmount.Text = "73";
                SamplingCalculation();

            }
            else
            {
                inspectAmount.Text = "86";
                SamplingCalculation();
            }
        }

        private void semiButton(object sender, EventArgs e)
        {
            jobQty = Int32.Parse(JOQTY.Text);
            if (jobQty < 9)
            {
                inspectAmount.Text = "Inspect All";
            }
            else if (jobQty >= 9 && jobQty <= 90)
            {
                inspectAmount.Text = "8";
                SamplingCalculation();
            }
            else if (jobQty >= 91 && jobQty <= 150)
            {
                inspectAmount.Text = "12";
                SamplingCalculation();
            }
            else if (jobQty >= 151 && jobQty <= 280)
            {
                inspectAmount.Text = "19";
                SamplingCalculation();
            }
            else if (jobQty >= 281 && jobQty <= 500)
            {
                inspectAmount.Text = "21";
                SamplingCalculation();
            }
            else if (jobQty >= 501 && jobQty <= 1200)
            {
                inspectAmount.Text = "27";
                SamplingCalculation();
            }
            else if (jobQty >= 1201 && jobQty <= 3200)
            {
                inspectAmount.Text = "35";
                SamplingCalculation();
            }
            else
            {
                inspectAmount.Text = "46";
                SamplingCalculation();
            }
        }

        private void rawButton(object sender, EventArgs e)
        {
            jobQty = Int32.Parse(JOQTY.Text);
            if (jobQty < 26)
            {
                inspectAmount.Text = "3";
                SamplingCalculation();
            }
            else if (jobQty >= 26 && jobQty <= 50)
            {
                inspectAmount.Text = "5";
                SamplingCalculation();
            }
            else if (jobQty >= 51 && jobQty <= 90)
            {
                inspectAmount.Text = "6";
                SamplingCalculation();
            }
            else if (jobQty >= 91 && jobQty <= 150)
            {
                inspectAmount.Text = "7";
                SamplingCalculation();
            }
            else if (jobQty >= 151 && jobQty <= 280)
            {
                inspectAmount.Text = "10";
                SamplingCalculation();
            }
            else if (jobQty >= 281 && jobQty <= 500)
            {
                inspectAmount.Text = "11";
                SamplingCalculation();
            }
            else if (jobQty >= 501 && jobQty <= 1200)
            {
                inspectAmount.Text = "15";
                SamplingCalculation();
            }
            else if (jobQty >= 1201 && jobQty <= 3200)
            {
                inspectAmount.Text = "18";
                SamplingCalculation();
            }
            else
            {
                inspectAmount.Text = "22";
                SamplingCalculation();
            }
        }

    
        private void degCalculation(object sender, EventArgs e)
        {
            double angle = Double.Parse(degrees.Text);
            double angleMinutes = Double.Parse(minutes.Text);
            double angleSeconds = Double.Parse(seconds.Text);
            Double degCalx = angle + (angleMinutes / 60) + (angleSeconds / 3600);
            degAnswer.Text = XanderToolzDLL.MathEquations.RemoveLastFour(formatted: degCalx.ToString());

            //degAnswer.Text = degCalx.ToString();
        }

    }
}
