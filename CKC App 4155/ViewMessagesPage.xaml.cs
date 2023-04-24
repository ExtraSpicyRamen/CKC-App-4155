using CKC_App_4155.objects;

namespace CKC_App_4155;

public partial class ViewMessagesPage : ContentPage
{
	Message message;
	public ViewMessagesPage()
	{
		Message message1 = new Message(1, 1, 2, "Testing sent message", "this iss the passage that I wrote for the test.", "John", "Betty");
        Message message2 = new Message(2, 1, 1, "Testing recieved message", "this iss the passage that I wrote for the test.", "Betty", "John");
        InitializeComponent();
		List<Message> sentMesages = new List<Message>();
        sentMesages.Add(message1);
		sentMesages.Add(message2);
		listofSentMessages.ItemsSource = sentMesages;
        listofReceivedMessages.ItemsSource = sentMesages;
    }
    private async void listofSentMessages_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (listofSentMessages.SelectedItem != null)
        {
            //assigns sendOver to the selected survey item
            Message sendOver = (Message)listofSentMessages.SelectedItem;
            //Must use a dictionary to send over objects to new page or previous page
            var navigationParameter = new Dictionary<string, object>
            {
                { "PickedMessage", sendOver}
            };
            //Sends the survey item over to the ViewSurveyPage so they can cast votes or view results
            await Shell.Current.GoToAsync($"{nameof(MessageDetailsPage)}", navigationParameter);
            //Makes it Null so that if the user navigates back they can reselect the same item again
            listofSentMessages.SelectedItem = null;
        }
    }

    private async void listofReceivedMessages_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (listofReceivedMessages.SelectedItem != null)
        {
            //assigns sendOver to the selected survey item
            Message sendOver = (Message)listofReceivedMessages.SelectedItem;
            //Must use a dictionary to send over objects to new page or previous page
            var navigationParameter = new Dictionary<string, object>
            {
                { "PickedMessage", sendOver}
            };
            //Sends the survey item over to the ViewSurveyPage so they can cast votes or view results
            await Shell.Current.GoToAsync($"{nameof(MessageDetailsPage)}", navigationParameter);
            //Makes it Null so that if the user navigates back they can reselect the same item again
            listofSentMessages.SelectedItem = null;
        }
    }
}