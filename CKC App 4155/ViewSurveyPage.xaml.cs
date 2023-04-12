using CKC_App_4155.Objects;
using static System.Net.Mime.MediaTypeNames;

namespace CKC_App_4155;
[QueryProperty(nameof(PickedSurvey), "PickedSurvey")]
public partial class ViewSurveyPage : ContentPage
{
    Survey currSurvey;
    public Survey PickedSurvey
    {
        get => currSurvey;
        set
        {
            currSurvey = value;
            OnPropertyChanged(nameof(currSurvey));
            surTitle.Text = currSurvey.getTitle();
        }
    }
    public ViewSurveyPage()
	{
        currSurvey = new Survey();
        InitializeComponent();
	}
}