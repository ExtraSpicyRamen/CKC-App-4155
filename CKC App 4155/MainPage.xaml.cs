namespace CKC_App_4155;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
	async void GotoCreateAccount(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new CreateAccount());
    }
    async void GotoForgotPassword(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ForgotPasswordPage());
    }

    async void GotoHomePage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }
}

