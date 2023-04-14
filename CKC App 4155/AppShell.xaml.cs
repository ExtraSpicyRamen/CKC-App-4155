namespace CKC_App_4155;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		//Set routing for the page you are sending a object to
		Routing.RegisterRoute(nameof(EventDetailPage), typeof(EventDetailPage));
		Routing.RegisterRoute(nameof(SurveysPage), typeof(SurveysPage));
        Routing.RegisterRoute(nameof(ViewSurveyPage), typeof(ViewSurveyPage));
        Routing.RegisterRoute(nameof(SurveyResultsPage), typeof(SurveyResultsPage));
    }
}
