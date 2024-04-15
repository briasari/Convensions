using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convensions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            double answer;

            int conversion = Convert.ToInt16(conversionInput.Text);
            double value = Convert.ToInt16(valueInput.Text);


            switch (conversion)
            {
                case 1:
                    answer = InchesToCm(value);
                    outputLabel.Text = $"The answer is: {answer}";
                    break;
                case 2:
                    answer = FeetToCm(value);
                    outputLabel.Text = $"The answer is: {answer}";
                    break;
                case 3:
                    answer = YardsToMetres(value);
                    outputLabel.Text = $"The answer is: {answer}";
                    break;
                case 4:
                    answer = MilesToKm(value);
                    outputLabel.Text = $"The answer is: {answer}";
                    break;
            }
        }

        public double InchesToCm(double value)
        {
            double inchToCm = 2.54;
            double answer = value * inchToCm;

            return answer;
        }

        public double FeetToCm(double value)
        {
            double ftToCm = 30.48;
            double answer = value * ftToCm;

            return answer;
        }

        public double YardsToMetres(double value)
        {
            double yardToMetre = 0.91;
            double answer = value * yardToMetre;

            return answer;
        }

        public double MilesToKm(double value)
        {
            double mileToKm = 1.6;
            double answer = value * mileToKm;

            return answer;
        }
    }
}
