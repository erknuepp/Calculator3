using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator3
{
 
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Button button = new Button
            {

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center

            };

            button.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new MainPage());

            };

        }
        private void Button_Click(object sender, EventArgs e)
        {
            var key = operation.Text;

            int num1 = Convert.ToInt32(number1.Text);

            int num2 = int.Parse(number2.Text);
           
            label3.Text = calculator.DoSomeMath(num1, num2, key).ToString();

         
        }
        public void Calculate_Volume(object sender, EventArgs e)
        {

            double r = Convert.ToDouble(radius.Text);
            double h = Convert.ToDouble(height.Text);
            //volume.Text = ((4 / 3) * Math.PI * Math.Pow(r, 3)).ToString();/
            volume.Text = (Math.PI * Math.Pow(r, 2) * h).ToString();
        }
        public void Calculate_SquareRoot(object sender, EventArgs e)
        {

            double n = Convert.ToDouble(Number.Text);
            SquareRoot.Text = (Math.Sqrt(n)).ToString();
           
        }
        public class calculator
        {

            public static int DoSomeMath(int num1, int num2, string key)
            {

                string operation = key;
                if (operation == "Add")
                {
                    int sum = num1 + num2;

                    return sum;
                }
                else if (operation == "Minus")
                {
                    int substract =num1 - num2;
                    return substract;
                }
                else if (operation == "Multiply")
                {
                    int Multiply = num1 * num2;

                    return Multiply;
                }
                else if (operation == "Divide")
                {
                    int Divide = num1 / num2;

                    return Divide;
                }
               
                return num1 / num2;


            }
            public static float DoSomeMath(float num1, float num2, string key)
            {

                string operation = key;
                if (operation == "Add")
                {

                    float sum = num1 + num2;

                    return sum;
                }
                else if (operation == "Minus")
                {
                    float Substract = (float)(num1 - num2);
                    return Substract;
                }
                else if (operation == "Multiply")
                {
                    float Multiply = (float)(num1 * num2);

                    return Multiply;
                }
                else if (operation == "Divide")
                {
                    float Divide = (float)(num1 / num2);

                    return Divide;
                }
                return (float)(num1 / num2);

            }

            public static void DoSomeMath(float num1, double num2,out float percentage, string key)
            {


                string operation = key;
                do
                {
                    percentage = (float)(num1 * num2) / 100;
                    
                } while (operation == "Percentage");



            }
            

        }


    }
}

