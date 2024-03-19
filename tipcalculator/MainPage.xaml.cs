using System;

namespace tipcalculator
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButton15PercentClicked(object sender, EventArgs e)
        {
            SliderTipPercent.Value = 15;
        }

        private void OnButton20PercentClicked(object sender, EventArgs e)
        {
            SliderTipPercent.Value = 20;
        }

        private void OnButtonRoundDownClicked(object sender, EventArgs e)
        {
            // Calcular a gorjeta, arredondando para baixo
            double result = CalculateTip();
            double roundedResult = Math.Floor(result);
            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double totalValue = roundedResult + amount;

            //Exibir a gorjeta
            LabelTipValue.Text = roundedResult.ToString();
            LabelTotalValue.Text = totalValue.ToString();
        }

        private void OnButtonRoundUpClicked(object sender, EventArgs e)
        {
            // Calcular a gorjeta, arredondando para baixo
            double result = CalculateTip();
            double roundedResult = Math.Ceiling(result);
            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double totalValue = roundedResult + amount;

            //Exibir a gorjeta
            LabelTipValue.Text = result.ToString();
            LabelTotalValue.Text = totalValue.ToString();
        }

        private double CalculateTip()
        {
            //Programar uma função que calcule
            //Preciso receber o valor do pedido digitado pelo usuário
            //Receber o valor da porcentagem para calcular o gorjeta
            //Realizar o calculo da gorjeta considerando o tipo
            // Exibir o valor da Label TotalTip

            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double percent = SliderTipPercent.Value;

            double result = amount * (percent / 100);

            //Exibir a gorjeta
            LabelTipValue.Text = result.ToString();
            return result;
                
        }

        private void SliderTipPercent_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            LabelTipPercentage.Text = Math.Round(SliderTipPercent.Value).ToString();

        }
    }
}

