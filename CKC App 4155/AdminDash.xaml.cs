namespace CKC_App_4155;

public partial class AdminDash : ContentPage
{
	public AdminDash()
	{
		InitializeComponent();
	}
    async void GotoCreateAccount(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateAccount());
    }
    async void GotoAddEvent(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddEvent());
    }
    async void GotoCreateSurvey(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateSurveyPage());
    }
}