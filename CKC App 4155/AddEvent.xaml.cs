namespace CKC_App_4155;

using CKC_App_4155.objects;
using CKC_App_4155.Objects;


public partial class AddEvent : ContentPage
{
	
	Event eventt = new Event();

	public AddEvent()
	{
		InitializeComponent();
		eventt.setID(1);
	}

    void eventTitleChanged(object sender, TextChangedEventArgs e)
    {
        eventt.setTitle(((Entry)sender).Text);
    }
    void eventDetailsChanged(object sender, TextChangedEventArgs e)
    {
        eventt.setEventDetails(((Entry)sender).Text);
    }
    void eventHostNameChanged(object sender, TextChangedEventArgs e)
    {
        eventt.setHostName(((Entry)sender).Text);
    }
    void eventLocationChanged(object sender, TextChangedEventArgs e)
    {
        eventt.setLocation(((Entry)sender).Text);
    }
    async void submitEvent(object sender, EventArgs e)
    {
       
        var navigationParameter = new Dictionary<string, object>
        {
            { "NewEvent", eventt }
        };

        await Shell.Current.GoToAsync($"..", navigationParameter);
    }
    private async void cancel(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}
