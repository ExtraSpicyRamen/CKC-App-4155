namespace CKC_App_4155;

public partial class HomePage : ContentPage
{
	private const uint AnimationDuration = 800u;
	public HomePage()
	{
		InitializeComponent();
	}
	async void Menu_Clicked(System.Object sender, System.EventArgs e)
	{
		//Reveal menu and pulls content out of view
		_ = MainContentGrid.TranslateTo(this.Width * 0.50, 0,AnimationDuration, Easing.Linear);
		await MainContentGrid.ScaleTo(1, AnimationDuration);
		_ = MainContentGrid.FadeTo(1, AnimationDuration);
	}

    async void GridArea_Tapped(object sender, System.EventArgs e)
    {
		//Close menu and brings back main content
		_ = MainContentGrid.FadeTo(1, AnimationDuration);
		_ = MainContentGrid.ScaleTo(1, AnimationDuration);
		await MainContentGrid.TranslateTo(0, 0, AnimationDuration, Easing.Linear);
    }

    async void GotoSurveys(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SurveysPage());
    }
    async void GotoSettings(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new UserSettings());
    }
    async void GotoCalendar(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Calendar());
    }
}