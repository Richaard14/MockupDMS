namespace DMSApp.Views;

public partial class TrackingPage : ContentPage
{
    public TrackingPage()
    {
        InitializeComponent();
    }

    private void OnHomeTapped(object sender, TappedEventArgs e)
    {
        Application.Current.MainPage = new DashboardPage();
    }

    private void OnMyDocumentsTapped(object sender, TappedEventArgs e)
    {
        Application.Current.MainPage = new MyDocumentsPage();
    }

    private void OnCreateDocumentTapped(object sender, TappedEventArgs e)
    {
        Application.Current.MainPage = new NewDocumentPage();
    }

    private void OnDocumentLibraryTapped(object sender, TappedEventArgs e)
    {
        Application.Current.MainPage = new DocumentLibraryPage();
    }
}