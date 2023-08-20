namespace NumerosInvertidos_3010746
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(n1.Text);
            int num2 = Convert.ToInt32(n2.Text);
            int num3 = Convert.ToInt32(n3.Text);
            int num4 = Convert.ToInt32(n4.Text);

            n1.Text = Convert.ToString(num4);
            n2.Text = Convert.ToString(num3);
            n3.Text = Convert.ToString(num2);
            n4.Text = Convert.ToString(num1);

        }
    }
}