namespace CKC_App_4155;

public partial class SurveysPage : ContentPage
{
	public SurveysPage()
	{
		InitializeComponent();
	}
    async void GotoSurvey(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ViewSurveyPage());
    }
}