using CKC_App_4155.objects;

namespace CKC_App_4155;

public partial class CreateMessagePage : ContentPage
{
	Message newMsg;
	List<string> users;

    public CreateMessagePage()
	{
		newMsg = new Message();
		InitializeComponent();
		Random random = new Random();
        BasicSimulation();
		int generatedID = random.Next(0, 100);
		newMsg.SetMessageID(generatedID);
	}
    private void TitleTextChanged(object sender, TextChangedEventArgs e)
    {
		newMsg.SetmTitle(((Entry)sender).Text);
    }
    private void ContentTextChanged(object sender, TextChangedEventArgs e)
    {
        newMsg.SetmContent(((Editor)sender).Text);
    }
    //Basic methods that populate the picker for users to message will be removed when database is implemented
    public void BasicSimulation()
	{
        users = new List<string>();
		users.Add("Bobby");
		users.Add("James");
		users.Add("Tiffany");
		users.Add("Beth");
		receiverPicker.ItemsSource = users;
    }

    private void receiverPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        newMsg.SetSenderName((string)((Picker)sender).SelectedItem);
    }

    private async void CreateMessageClicked(object sender, EventArgs e)
    {
        if (newMsg.GetmTitle() == null)
        {
            await DisplayAlert("Error", "You seem to have not set a title for your message. Please set a title", "close");
        }
        else if (newMsg.GetSenderName() == null)
        {
            await DisplayAlert("Error", "You seem to have not set a user for your message. Please set a user to send the message to.", "close");
        }
        else if (newMsg.GetmContent() == null)
        {
            await DisplayAlert("Error", "You seem to have not set a message. Please set a message to send.", "close");
        }
        else
        {
            Message sendOver = newMsg;
            //Must use a dictionary to send over objects to new page or previous page
            var navigationParameter = new Dictionary<string, object>
            {
                { "CreatedMessage", sendOver}
            };
            await Shell.Current.GoToAsync($"{nameof(ViewMessagesPage)}", navigationParameter);
        }
    }

    private async void CancelClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"..");
    }
}