using CKC_App_4155.Objects;
using System.Linq.Expressions;
using static System.Net.Mime.MediaTypeNames;

namespace CKC_App_4155;
[QueryProperty(nameof(PickedSurvey), "PickedSurvey")]
public partial class ViewSurveyPage : ContentPage
{
    Survey currSurvey;
    public string sel;
    public Survey PickedSurvey
    {
        get => currSurvey;
        set
        {
            currSurvey = value;
            OnPropertyChanged(nameof(currSurvey));
            surTitle.Text = currSurvey.getTitle();
            NumOptions(currSurvey.getNumChoices());
        }
    }
    public ViewSurveyPage()
	{
        //Initializing survey item and sel string
        currSurvey = new Survey();
        sel = "";
        InitializeComponent();
	}
    public void NumOptions(int num)
    {
        switch (num)
        {
            case 1:
                //Shows radio buttons
                rad1.IsVisible = true;
                //Enables radio buttons
                rad1.IsEnabled = true;
                //Sets radio buttons to be right value
                rad1.Content = currSurvey.getA();
                break;
            case 2:
                //Shows radio buttons
                rad1.IsVisible = true;
                rad2.IsVisible = true;
                //Enables radio buttons
                rad1.IsEnabled = true;
                rad2.IsEnabled = true;
                //Sets radio buttons to be right value
                rad1.Content = currSurvey.getA();
                rad2.Content = currSurvey.getB();
                break;
            case 3:
                //Shows radio buttons
                rad1.IsVisible = true;
                rad2.IsVisible = true;
                rad3.IsVisible = true;
                //Enables radio buttons
                rad1.IsEnabled = true;
                rad2.IsEnabled = true;
                rad3.IsEnabled = true;
                //Sets radio buttons to be right value
                rad1.Content = currSurvey.getA();
                rad2.Content = currSurvey.getB();
                rad3.Content = currSurvey.getC();
                break;
            case 4:
                //Shows radio buttons
                rad1.IsVisible = true;
                rad2.IsVisible = true;
                rad3.IsVisible = true;
                rad4.IsVisible = true;
                //Enables radio buttons
                rad1.IsEnabled = true;
                rad2.IsEnabled = true;
                rad3.IsEnabled = true;
                rad4.IsEnabled = true;
                //Sets radio buttons to be right value
                rad1.Content = currSurvey.getA();
                rad2.Content = currSurvey.getB();
                rad3.Content = currSurvey.getC();
                rad4.Content = currSurvey.getD();
                break;
            case 5:
                //Shows radio buttons
                rad1.IsVisible = true;
                rad2.IsVisible = true;
                rad3.IsVisible = true;
                rad4.IsVisible = true;
                rad5.IsVisible = true;
                //Enables radio buttons
                rad1.IsEnabled = true;
                rad2.IsEnabled = true;
                rad3.IsEnabled = true;
                rad4.IsEnabled = true;
                rad5.IsEnabled = true;
                //Sets radio buttons to be right value
                rad1.Content = currSurvey.getA();
                rad2.Content = currSurvey.getB();
                rad3.Content = currSurvey.getC();
                rad4.Content = currSurvey.getD();
                rad5.Content = currSurvey.getE();
                break;
            case 6:
                //Shows radio buttons
                rad1.IsVisible = true;
                rad2.IsVisible = true;
                rad3.IsVisible = true;
                rad4.IsVisible = true;
                rad5.IsVisible = true;
                rad6.IsVisible = true;
                //Enables radio buttons
                rad1.IsEnabled = true;
                rad2.IsEnabled = true;
                rad3.IsEnabled = true;
                rad4.IsEnabled = true;
                rad5.IsEnabled = true;
                rad6.IsEnabled = true;
                //Sets radio buttons to be right value
                rad1.Content = currSurvey.getA();
                rad2.Content = currSurvey.getB();
                rad3.Content = currSurvey.getC();
                rad4.Content = currSurvey.getD();
                rad5.Content = currSurvey.getE();
                rad6.Content = currSurvey.getF();
                break;
            default:
                //If survey has no choices or more than the system can handle than its a error
                DisplayAlert("Error", "This survey seems to be missing choices", "Close");
                break;
        }
    }
    //View results of current survey being looked at
    public void ViewResults()
    {
        //logic for viewing
    }
    public void SubmitVote()
    {
        //logic for submitting
    }
    //Method will change "sel" to match value currently being selected
    private void CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton button = (RadioButton)sender;
        sel = (string) button.Content;
        //Figure out how to detect which option was picked and increment its count
    }
}