namespace DMSApp.Views;

public partial class MyDocumentsPage : ContentPage
{
    public MyDocumentsPage()
    {
        InitializeComponent();
    }

    private void OnHomeTapped(object sender, TappedEventArgs e)
    {
        Application.Current.MainPage = new DashboardPage();
    }

    private void OnCreateDocumentTapped(object sender, TappedEventArgs e)
    {
        Application.Current.MainPage = new NewDocumentPage();
    }

    private void OnCreateDocumentClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NewDocumentPage();
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