using CKC_App_4155.objects;

namespace CKC_App_4155;
[QueryProperty(nameof(PickMessage), "PickedMessage")]
public partial class MessageDetailsPage : ContentPage
{
    Message currMsg;
    public Message PickMessage
    {
        get => currMsg;
        set
        {
            currMsg = value;
            //I don't think this is needed but needs to be tested later
            OnPropertyChanged(nameof(currMsg));
            mLabelTitle.Text = currMsg.GetmTitle();
            mLabelName.Text = currMsg.GetSenderName();
            mLabelContent.Text = currMsg.GetmContent();
        }
    }
    public MessageDetailsPage()
	{
        currMsg = new Message();
		InitializeComponent();
	}

    private async void GoBack(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"..");
    }
    private async void DeleteMessage(object sender, EventArgs e)
    {
        //assigns sendOver to the selected message item
        Message sendOver = currMsg;
        //Must use a dictionary to send over objects to new page or previous page
        var navigationParameter = new Dictionary<string, object>
            {
                { "DeleteMsg", sendOver}
            };
        //Sends the message item over to the MessageDetailsPage so they can view message to either reply or delete.
        await Shell.Current.GoToAsync($"..", navigationParameter);
        sendOver = null;
    }
}