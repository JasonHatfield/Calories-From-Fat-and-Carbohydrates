using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  
 *  Jason Hatfield
 *  this is my original work
 */  

namespace Calories
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int FAT_CALORIES = 9;     // constant for fat calories
        const int CARB_CALORIES = 4;    // constant for carb calories

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // try/catch statement to ensure corrent information is entered
            try
            {
                if (double.TryParse(dailyFatTextBox.Text, out double dailyFat)) {
                    if (double.TryParse(dailyCarbsTextBox.Text, out double dailyCarbs))
                    {
                        // outputs converted fat and carb calories to the correct labels
                        outputFatCaloriesLabel.Text = FatCalories(dailyFat).ToString();
                        outputCarbCaloriesTextBox.Text = CarbCalories(dailyCarbs).ToString();
                    }
                    else
                    {
                        // message box shows if fat grams were not entered
                        MessageBox.Show("Enter Daily Carbohydrates.");
                    }
                }
                else
                {
                    // message box shows if fat grams were not entered
                    MessageBox.Show("Enter Daily Fat");
                }
            }
            catch (Exception ex)
            {
                // message box shows excpetion if thrown
                MessageBox.Show(ex.Message);
            }
        }
        private double FatCalories(double dailyFat)
        // method to multiply and return dailyfAT by the constant FAT_CALORIES
        {
            return dailyFat * FAT_CALORIES;
        }

        private double CarbCalories(double dailyCarbs)
        // method to multiply and return dailyCarbs by the constant CARB_CALORIES
        {
            return dailyCarbs * CARB_CALORIES;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // statement to close program when button is pressed
            this.Close();
        }
    }
}