namespace CKC_App_4155;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(EventDetailPage), typeof(EventDetailPage));
		Routing.RegisterRoute(nameof(SurveysPage), typeof(SurveysPage));
        Routing.RegisterRoute(nameof(ViewSurveyPage), typeof(ViewSurveyPage));
    }
}
