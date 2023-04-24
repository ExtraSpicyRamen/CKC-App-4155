using CKC_App_4155.objects;

namespace CKC_App_4155;
[QueryProperty(nameof(CreatedMessage), "CreatedMessage")]
public partial class ViewMessagesPage : ContentPage
{
	Message message;
    List<Message> sentMessages;
    List<Message> receivedMessages;
    Message currMsg;
    public Message CreatedMessage
    {
        get => currMsg;
        set
        {
            currMsg = value;
            //I don't think this is needed but needs to be tested later
            OnPropertyChanged(nameof(currMsg));
            //Sets the title and options and has to be done here so app doesn't crash since this method is activated after ViewSurveryPage constructor
            sentMessages.Add(currMsg);
        }
    }
    public ViewMessagesPage()
	{
        InitializeComponent();
		sentMessages = new List<Message>();
        receivedMessages = new List<Message>();
        SimpleSimulation();
    }
    private async void listofSentMessages_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (listofSentMessages.SelectedItem != null)
        {
            //assigns sendOver to the selected message item
            Message sendOver = (Message)listofSentMessages.SelectedItem;
            //Must use a dictionary to send over objects to new page or previous page
            var navigationParameter = new Dictionary<string, object>
            {
                { "PickedMessage", sendOver}
            };
            //Sends the message item over to the MessageDetailsPage so they can view message to either reply or delete.
            await Shell.Current.GoToAsync($"{nameof(MessageDetailsPage)}", navigationParameter);
            //Makes it Null so that if the user navigates back they can reselect the same message again
            listofSentMessages.SelectedItem = null;
        }
    }

    private async void listofReceivedMessages_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (listofReceivedMessages.SelectedItem != null)
        {
            //assigns sendOver to the selected message item
            Message sendOver = (Message)listofReceivedMessages.SelectedItem;
            //Must use a dictionary to send over objects to new page or previous page
            var navigationParameter = new Dictionary<string, object>
            {
                { "PickedMessage", sendOver}
            };
            //Sends the message item over to the MessageDetailsPage so they can view message to either reply or delete.
            await Shell.Current.GoToAsync($"{nameof(MessageDetailsPage)}", navigationParameter);
            //Makes it Null so that if the user navigates back they can reselect the same message again
            listofSentMessages.SelectedItem = null;
        }
    }
    public void SimpleSimulation()
    {
        Message message1 = new Message(1, 1, 2, "Testing sent message 1", "this iss the passage that I wrote for the test.", "John", "Betty");
        Message message2 = new Message(2, 1, 1, "Testing Sent message 2", "this iss the passage that I wrote for the test.", "Betty", "John");
        Message message3 = new Message(3, 1, 2, "Testing recieved message 1", "this iss the passage that I wrote for the test.", "John", "Betty");
        Message message4 = new Message(4, 1, 1, "Testing recieved message 2", "this iss the passage that I wrote for the test.", "Betty", "John");
        sentMessages.Add(message1);
        sentMessages.Add(message2);
        receivedMessages.Add(message3);
        receivedMessages.Add(message4);
        listofSentMessages.ItemsSource = sentMessages;
        listofReceivedMessages.ItemsSource = receivedMessages;
    }
}