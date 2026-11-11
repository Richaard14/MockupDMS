namespace DMSApp.Views;

public partial class DocumentLibraryPage : ContentPage
{
    public DocumentLibraryPage()
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

    private void OnCreateDocumentClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NewDocumentPage();
    }
    private void OnTrackingTapped(object sender, TappedEventArgs e)
    {
        Application.Current.MainPage = new TrackingPage();
    }
}