namespace DMSApp.Views;

public partial class ArchivePage : ContentPage
{
    public ArchivePage()
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

    private void OnTrackingTapped(object sender, TappedEventArgs e)
    {
        Application.Current.MainPage = new TrackingPage();
    }

    private async void OnViewDocumentClicked(object sender, EventArgs e)
    {
        // Menampilkan pemberitahuan bahwa dokumen arsip hanya bisa dilihat
        await DisplayAlert("Read-Only Document", "Dokumen ini telah diarsip/expired dan hanya tersedia dalam mode tampilan (Read-Only).", "OK");
    }
}