namespace DMSApp.Views;

public partial class DashboardPage : ContentPage
{
    public DashboardPage()
    {
        InitializeComponent();
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
    private void OnTrackingTapped(object sender, TappedEventArgs e)
    {
        Application.Current.MainPage = new TrackingPage();
    }
    private void OnArchiveTapped(object sender, TappedEventArgs e)
    {
        Application.Current.MainPage = new ArchivePage();
    }
}