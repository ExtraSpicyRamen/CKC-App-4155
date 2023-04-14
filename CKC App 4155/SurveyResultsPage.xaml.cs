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
}