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
            //Sets the title and options and has to be done here so app doesn't crash since this method is activated after ViewSurveryPage constructor
            mLabelTitle.Text = currMsg.GetmTitle();
            mLabelName.Text = currMsg.GetSenderName();
            mLabelContent.Text = currMsg.GetmContent();
            //surTitle.Text = currSurvey.getTitle();
            //NumOptions(currSurvey.getNumChoices());
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
        int id = currMsg.GetMessageID();
        await Shell.Current.GoToAsync($"..?deleteid={id}");
    }
}