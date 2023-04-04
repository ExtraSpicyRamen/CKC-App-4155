using CKC_App_4155.objects;

namespace CKC_App_4155;

public partial class CreateSurveyPage : ContentPage
{
    int numChoices = 0;
    Survey survey = new Survey();
    public CreateSurveyPage()
	{
		InitializeComponent();
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
        }
        else if (selectedIndex == 1)
        {
            entry_1.IsVisible = true;
            entry_2.IsVisible = true;
            entry_3.IsVisible = false;
            entry_4.IsVisible = false;
            entry_5.IsVisible = false;
            entry_6.IsVisible = false;
        }
        else if(selectedIndex == 2)
        {
            entry_1.IsVisible = true;
            entry_2.IsVisible = true;
            entry_3.IsVisible = true;
            entry_4.IsVisible = false;
            entry_5.IsVisible = false;
            entry_6.IsVisible = false;
        }
        else if (selectedIndex == 3)
        {
            entry_1.IsVisible = true;
            entry_2.IsVisible = true;
            entry_3.IsVisible = true;
            entry_4.IsVisible = true;
            entry_5.IsVisible = false;
            entry_6.IsVisible = false;
        }
        else if (selectedIndex == 4)
        {
            entry_1.IsVisible = true;
            entry_2.IsVisible = true;
            entry_3.IsVisible = true;
            entry_4.IsVisible = true;
            entry_5.IsVisible = true;
            entry_6.IsVisible = false;
        }
        else if (selectedIndex == 5)
        {
            entry_1.IsVisible = true;
            entry_2.IsVisible = true;
            entry_3.IsVisible = true;
            entry_4.IsVisible = true;
            entry_5.IsVisible = true;
            entry_6.IsVisible = true;
        }
        else
        {
            entry_1.IsVisible = false;
            entry_2.IsVisible = false;
            entry_3.IsVisible = false;
            entry_4.IsVisible = false;
            entry_5.IsVisible = false;
            entry_6.IsVisible = false;
        }
    }
    void submitClicked(object sender, EventArgs e)
    {
        
    }
}