namespace DMSApp.Views;

public partial class loginpage : ContentPage
{
	public loginpage()
	{
		InitializeComponent();
	}
    private void OnSignInClicked(object sender, EventArgs e)
    {
        // Mengubah halaman utama aplikasi langsung ke DashboardPage
        Application.Current.MainPage = new DashboardPage();
    }
}