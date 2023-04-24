namespace CKC_App_4155;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		//Set routing for the page you are sending a object to
		//This is mainly for Shell navigation so if you are using shell navigation keep the navigation consistent especially with objects
		Routing.RegisterRoute(nameof(EventDetailPage), typeof(EventDetailPage));
		Routing.RegisterRoute(nameof(SurveysPage), typeof(SurveysPage));
        Routing.RegisterRoute(nameof(ViewSurveyPage), typeof(ViewSurveyPage));
        Routing.RegisterRoute(nameof(CreateSurveyPage), typeof(CreateSurveyPage));
        Routing.RegisterRoute(nameof(SurveyResultsPage), typeof(SurveyResultsPage));
        Routing.RegisterRoute(nameof(ViewMessagesPage), typeof(ViewMessagesPage));
        Routing.RegisterRoute(nameof(MessageDetailsPage), typeof(MessageDetailsPage));
    }
}
