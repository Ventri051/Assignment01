namespace Assignment01
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnConvertClicked(object sender, EventArgs e)
        {
            double fahrenheit = double.Parse(fahrenheitEntry.Text);

            double celsius = (fahrenheit - 32) * 5.0 / 9.0;

            resultLabel.Text = $"{celsius:N1} °C";
        }
    }
}
