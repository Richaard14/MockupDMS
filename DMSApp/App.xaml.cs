namespace DMSApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Arahkan Window utama langsung ke loginpage
            return new Window(new Views.loginpage());
        }
    }
}