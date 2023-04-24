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

    }
	public void BasicSimulation()
	{
        users = new List<string>();
		users.Add("Bobby");
		users.Add("James");
		users.Add("Tiffany");
		users.Add("Beth");
		receiverPicker.ItemsSource = users;
    }
}