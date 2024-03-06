namespace EXEMPLO
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string name;

        // método construtor
        public MainPage() 
        {
            InitializeComponent();
        }

        private void OnMessageClicked(object sender, EventArgs e)
        {
            name = NameEntry.Text;
            MessageLabel.Text = $"Hello, {name}!";
        }
    }
}