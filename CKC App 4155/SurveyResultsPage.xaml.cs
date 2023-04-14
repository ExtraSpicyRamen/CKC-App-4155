using CKC_App_4155.Objects;

namespace CKC_App_4155;
[QueryProperty(nameof(ViewResults), "ViewResults")]
public partial class SurveyResultsPage : ContentPage
{
    Survey currSurvey;
    public Survey ViewResults
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
    public SurveyResultsPage()
	{
        currSurvey = new Survey();
		InitializeComponent();
	}
    //Takes in number of options and properly sets labels to display the correct amount fo votes and options that the survey had
    public void NumOptions(int numChoices)
    {
        if (currSurvey != null)
        {
            switch (numChoices)
            {
                case 1:
                    choice1.IsVisible = true;
                    choice1.Text = currSurvey.getA() + " - " + currSurvey.getCountA();
                break;
                case 2:
                    choice1.IsVisible = true;
                    choice1.Text = currSurvey.getA() + " - " + currSurvey.getCountA();
                    choice2.IsVisible = true;
                    choice2.Text = currSurvey.getB() + " - " + currSurvey.getCountB();
                    break;
                case 3:
                    choice1.IsVisible = true;
                    choice1.Text = currSurvey.getA() + " - " + currSurvey.getCountA();
                    choice2.IsVisible = true;
                    choice2.Text = currSurvey.getB() + " - " + currSurvey.getCountB();
                    choice3.IsVisible = true;
                    choice3.Text = currSurvey.getC() + " - " + currSurvey.getCountC();
                    break;
                case 4:
                    choice1.IsVisible = true;
                    choice1.Text = currSurvey.getA() + " - " + currSurvey.getCountA();
                    choice2.IsVisible = true;
                    choice2.Text = currSurvey.getB() + " - " + currSurvey.getCountB();
                    choice3.IsVisible = true;
                    choice3.Text = currSurvey.getC() + " - " + currSurvey.getCountC();
                    choice4.IsVisible = true;
                    choice4.Text = currSurvey.getD() + " - " + currSurvey.getCountD();
                    break;
                case 5:
                    choice1.IsVisible = true;
                    choice1.Text = currSurvey.getA() + " - " + currSurvey.getCountA();
                    choice2.IsVisible = true;
                    choice2.Text = currSurvey.getB() + " - " + currSurvey.getCountB();
                    choice3.IsVisible = true;
                    choice3.Text = currSurvey.getC() + " - " + currSurvey.getCountC();
                    choice4.IsVisible = true;
                    choice4.Text = currSurvey.getD() + " - " + currSurvey.getCountD();
                    choice5.IsVisible = true;
                    choice5.Text = currSurvey.getE() + " - " + currSurvey.getCountE();
                    break;
                case 6:
                    choice1.IsVisible = true;
                    choice1.Text = currSurvey.getA() + " - " + currSurvey.getCountA();
                    choice2.IsVisible = true;
                    choice2.Text = currSurvey.getB() + " - " + currSurvey.getCountB();
                    choice3.IsVisible = true;
                    choice3.Text = currSurvey.getC() + " - " + currSurvey.getCountC();
                    choice4.IsVisible = true;
                    choice4.Text = currSurvey.getD() + " - " + currSurvey.getCountD();
                    choice5.IsVisible = true;
                    choice5.Text = currSurvey.getE() + " - " + currSurvey.getCountE();
                    choice6.IsVisible = true;
                    choice6.Text = currSurvey.getF() + " - " + currSurvey.getCountF();
                    break;
                default:
                    DisplayAlert("Error", "There was an error", "Close");
                    break;
            }
        }
    }
    //Sends the user back to previous page
    private async void GoBack(object sender, EventArgs e)
    {
        //If you are using shell navigation than use this line to go back pages so that the system doesn't add a new iteration of the page.
        await Shell.Current.GoToAsync("..");
    }
}