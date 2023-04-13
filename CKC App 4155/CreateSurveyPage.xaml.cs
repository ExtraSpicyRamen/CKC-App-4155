using CKC_App_4155.Objects;
using System.Diagnostics;

namespace CKC_App_4155;

public partial class CreateSurveyPage : ContentPage
{
    int numChoices = 0;
    Survey survey = new Survey();
    public CreateSurveyPage()
	{
		InitializeComponent();
        survey.setId(1); //Temporary until database
    }
   
    void OnPickerSelectedIndexChanged (object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;
        numChoices = selectedIndex;
        CreateSurvey_Text.IsVisible = true;
        if (selectedIndex == 0)
        {
            entry_1.IsVisible = true;
            entry_2.IsVisible = false;
            entry_3.IsVisible = false;
            entry_4.IsVisible = false;
            entry_5.IsVisible = false;
            entry_6.IsVisible = false;
            survey.setNumChoices(1);
        }
        else if (selectedIndex == 1)
        {
            entry_1.IsVisible = true;
            entry_2.IsVisible = true;
            entry_3.IsVisible = false;
            entry_4.IsVisible = false;
            entry_5.IsVisible = false;
            entry_6.IsVisible = false;
            survey.setNumChoices(2);
        }
        else if(selectedIndex == 2)
        {
            entry_1.IsVisible = true;
            entry_2.IsVisible = true;
            entry_3.IsVisible = true;
            entry_4.IsVisible = false;
            entry_5.IsVisible = false;
            entry_6.IsVisible = false;
            survey.setNumChoices(3);
        }
        else if (selectedIndex == 3)
        {
            entry_1.IsVisible = true;
            entry_2.IsVisible = true;
            entry_3.IsVisible = true;
            entry_4.IsVisible = true;
            entry_5.IsVisible = false;
            entry_6.IsVisible = false;
            survey.setNumChoices(4);
        }
        else if (selectedIndex == 4)
        {
            entry_1.IsVisible = true;
            entry_2.IsVisible = true;
            entry_3.IsVisible = true;
            entry_4.IsVisible = true;
            entry_5.IsVisible = true;
            entry_6.IsVisible = false;
            survey.setNumChoices(5);
        }
        else if (selectedIndex == 5)
        {
            entry_1.IsVisible = true;
            entry_2.IsVisible = true;
            entry_3.IsVisible = true;
            entry_4.IsVisible = true;
            entry_5.IsVisible = true;
            entry_6.IsVisible = true;
            survey.setNumChoices(6);
        }
        else
        {
            entry_1.IsVisible = false;
            entry_2.IsVisible = false;
            entry_3.IsVisible = false;
            entry_4.IsVisible = false;
            entry_5.IsVisible = false;
            entry_6.IsVisible = false;
            survey.setNumChoices(0);
        }
    }
    //Temporary/Permanent until we figure out a way to find which entry to being accessed
    void OnEntryCompletedTitle(object sender, EventArgs e)
    {
        survey.setTitle(((Entry)sender).Text);
    }
    void OnEntryCompletedA(object sender, EventArgs e)
    {
        survey.setA(((Entry)sender).Text);
    }
    void OnEntryCompletedB(object sender, EventArgs e)
    {
        survey.setB(((Entry)sender).Text);
    }
    void OnEntryCompletedC(object sender, EventArgs e)
    {
        survey.setC(((Entry)sender).Text);
    }
    void OnEntryCompletedD(object sender, EventArgs e)
    {
        survey.setD(((Entry)sender).Text);
    }
    void OnEntryCompletedE(object sender, EventArgs e)
    {
        survey.setE(((Entry)sender).Text);
    }
    void OnEntryCompletedF(object sender, EventArgs e)
    {
        survey.setF(((Entry)sender).Text);
    }
    //end of temporary/permanent
    async void submitClicked(object sender, EventArgs e)
    {
        //Checks to make sure object has right values and prints to the output window
        var navigationParameter = new Dictionary<string, object>
        {
            { "NewSurvey", survey }
        };
        await Shell.Current.GoToAsync($"{nameof(SurveysPage)}", navigationParameter);
    }
}