namespace DMSApp.Views;

public partial class NewDocumentPage : ContentPage
{
    public NewDocumentPage()
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

    private void OnCloseTapped(object sender, TappedEventArgs e)
    {
        Application.Current.MainPage = new DashboardPage();
    }

    private void OnDocumentLibraryTapped(object sender, TappedEventArgs e)
    {
        Application.Current.MainPage = new DocumentLibraryPage();
    }
    private void OnTrackingTapped(object sender, TappedEventArgs e)
    {
        Application.Current.MainPage = new TrackingPage();
    }
}