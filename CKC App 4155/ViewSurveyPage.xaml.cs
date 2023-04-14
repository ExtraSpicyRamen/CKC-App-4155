using CKC_App_4155.Objects;
using System.Linq.Expressions;
using static System.Net.Mime.MediaTypeNames;

namespace CKC_App_4155;
//Grabs object sent from SurveysPage
[QueryProperty(nameof(PickedSurvey), "PickedSurvey")]
public partial class ViewSurveyPage : ContentPage
{
    Survey currSurvey;
    RadioButton button;
    //This sets currSurvey to the survey sent through
    public Survey PickedSurvey
    {
        get => currSurvey;
        set
        {
            currSurvey = value;
            //I don't think this is needed but needs to be tested later
            OnPropertyChanged(nameof(currSurvey));
            //Sets the title and options and has to be done here so app doesn't crash since this method is activated after ViewSurveryPage constructor
            surTitle.Text = currSurvey.getTitle();
            NumOptions(currSurvey.getNumChoices());
        }
    }
    public ViewSurveyPage()
	{
        //Initializing survey item and sel string
        currSurvey = new Survey();
        InitializeComponent();
	}
    //Checks how many options there and properly sets the view to display right amount and correct choices
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
    //Method will set button to current button being pressed
    private void CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        button = (RadioButton)sender;
        //Figure out how to detect which option was picked and increment its count
    }
    //Detects Which item got the vote and adds it to the the list
    private void SubmitVote(object sender, EventArgs e)
    {
        if (button != null)
        {
            if (button.Equals(rad1))
            {
                currSurvey.setCountA(currSurvey.getCountA() + 1);
            }
            else if (button.Equals(rad2))
            {
                currSurvey.setCountB(currSurvey.getCountB() + 1);
            }
            else if (button.Equals(rad3))
            {
                currSurvey.setCountC(currSurvey.getCountC() + 1);
            }
            else if (button.Equals(rad4))
            {
                currSurvey.setCountD(currSurvey.getCountD() + 1);
            }
            else if (button.Equals(rad5))
            {
                currSurvey.setCountE(currSurvey.getCountE() + 1);
            }
            else if (button.Equals(rad6))
            {
                currSurvey.setCountF(currSurvey.getCountF() + 1);
            }
            else
            {
                DisplayAlert("Error", "Seems like the choice you made has caused an error. Please choose again.", "Close");
            }
        }
        else if (button == null)
        {
            DisplayAlert("Error", "Please Pick a Choice before submitting", "Close");
        }
    }
    //Sends survey over to SurveyResultsPage to view results of the current survey
    private async void ViewSurvey(object sender, EventArgs e)
    {
        if (currSurvey != null)
        {
            Survey sendOver = currSurvey;
            var navigationParameter = new Dictionary<string, object>
            {
                { "ViewResults", sendOver}
            };
            await Shell.Current.GoToAsync($"{nameof(SurveyResultsPage)}", navigationParameter);
        }
    }
    //Goes back to previous page 
    private async void GoBack(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"..");
    }
}