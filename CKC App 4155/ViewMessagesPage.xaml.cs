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
}