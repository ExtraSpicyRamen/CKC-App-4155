using CKC_App_4155.objects;
using System.Collections.ObjectModel;
using System.Linq;

namespace CKC_App_4155;
[QueryProperty(nameof(CreatedMessage), "CreatedMessage")]
[QueryProperty(nameof(DeleteMsg), "DeleteMsg")]
public partial class ViewMessagesPage : ContentPage
{
	Message message;
    //Needed to use oberservablecollection to make sure the listview updates as we delete items from the lists
    public ObservableCollection<Message> sentMessages = new ObservableCollection<Message>();
    public ObservableCollection<Message> receivedMessages = new ObservableCollection<Message>();
    Message currMsg;
    Message deletemsg;
    public Message DeleteMsg
    {
        get => deletemsg;
        set
        {
            deletemsg = value;
            //I don't think this is needed but needs to be tested later
            OnPropertyChanged(nameof(deletemsg));
            Message currdelete = deletemsg;
            if (sentMessages.Contains(currdelete))
            {
                sentMessages.Remove(currdelete);
                currdelete = null;
            }
            else
            {
                receivedMessages.Remove(currdelete);
                currdelete = null;
            }
        }
    }
    public Message CreatedMessage
    {
        get => currMsg;
        set
        {
            Message recent = new Message();
            currMsg = value;
            //I don't think this is needed but needs to be tested later
            OnPropertyChanged(nameof(currMsg));
            if (!sentMessages.Contains(currMsg) && !currMsg.Equals(recent))
            {
                recent = currMsg;
                sentMessages.Add(currMsg);
            }
        }
    }
    public ViewMessagesPage()
	{
        InitializeComponent();
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
    //Sends over a recievedmessages items
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
            listofReceivedMessages.SelectedItem = null;
        }
    }
    //Method is just to populate the lists before database implementation
    public void SimpleSimulation()
    {
        Message message1 = new Message(1, 1, 2, "Testing sent message 1", "this iss the passage that I wrote for the test.", "Beth", "John");
        Message message2 = new Message(1, 2, 2, "Testing Sent message 2", "this iss the passage that I wrote for the test.", "Beth", "John");
        Message message3 = new Message(2, 1, 1, "Testing recieved message 1", "this iss the passage that I wrote for the test.", "John", "Beth");
        Message message4 = new Message(2, 2, 1, "Testing recieved message 2", "this iss the passage that I wrote for the test.", "John", "Beth");
        sentMessages.Add(message1);
        sentMessages.Add(message2);
        receivedMessages.Add(message3);
        receivedMessages.Add(message4);
        listofSentMessages.ItemsSource = sentMessages;
        listofReceivedMessages.ItemsSource = receivedMessages;
    }

    private async void GoToCreateMsg(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(CreateMessagePage)}");
    }
    private async void GoBack(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"..");
    }
}