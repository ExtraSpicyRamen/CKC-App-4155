using CKC_App_4155.ViewModel;
using CKC_App_4155.objects;


namespace CKC_App_4155;
[QueryProperty(nameof(ViewResults), "ViewResults")]


public partial class EventDetailPage : ContentPage
{
	Event currEvent;
	public Event ViewResults
	{
        get => currEvent;
        set
        {
            currEvent = value;
            //I don't think this is needed but needs to be tested later
            OnPropertyChanged(nameof(currEvent));
            //Sets the title and options and has to be done here so app doesn't crash since this method is activated after ViewSurveryPage constructor
            eventTitle.Text = currEvent.getTitle();
            eventDetails.Text = currEvent.getEventDetails();
            eventHost.Text = currEvent.getHostName();
            eventLocation.Text = currEvent.getLocation();
            
        }
    }
	public EventDetailPage()
	{
        currEvent = new Event();
        InitializeComponent();
		
	}
    private async void GoBack(object sender, EventArgs e)
    {
        //If you are using shell navigation than use this line to go back pages so that the system doesn't add a new iteration of the page.
        await Shell.Current.GoToAsync("..");
    }
}