using CKC_App_4155.Objects;
using CKC_App_4155.ViewModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Controls.Internals;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;

namespace CKC_App_4155;
//Grabs Item sent from createSurvey
[QueryProperty(nameof(NewSurvey), "NewSurvey")]

public partial class SurveysPage : ContentPage
{
    //Obeserable Collection updates listview as new items are added in you could probably use a list instead
    public ObservableCollection<Survey> surveysToBeList = new ObservableCollection<Survey>();
    //A getter and setter of oberservablecollection only really need it if you need to data bind the list somewhere in the XAML
    public ObservableCollection<Survey> SurveysToBeList {
        get { return surveysToBeList; }
        set { surveysToBeList = value; }
    }
    //This survey item will be set to the incoming survey from createsurvey page
    public Survey test = new Survey();
    //This survey item will be used to check the current survey saved from before and make sure dupes aren't made
    Survey check = new Survey();
    //This method assigns the incoming survey from createsurvey to "test" survey item
    public Survey NewSurvey
    {
        get => test;
        set
        {
            test = value;
            OnPropertyChanged(nameof(test));
            //Checks to make sure that test and check aren't the same and if they aren't than we can safely add it to the list
            if (!test.Equals(check))
            {
                surveysToBeList.Add(test);
                //Since a new item was added we reassign check so it checks for the latest added item
                check = test;
            }
        }
    }
    public SurveysPage()
	{
        InitializeComponent();
        //Dummy item to test what multiple objects in listview looks like
        Survey testingdummy = new Survey();
        testingdummy.setTitle("testing");
        SurveysToBeList.Add(testingdummy);
        listSurveys.ItemsSource = SurveysToBeList;
    }
    async void CreateSurvey(object sender, EventArgs e)
    {
        //Use this navigation to go to new page but make sure to set a navigation path in AppShell.xaml.cs first
        await Shell.Current.GoToAsync($"{nameof(CreateSurveyPage)}");
    }

    private async void listSurveys_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (listSurveys.SelectedItem != null)
        {
            //assigns sendOver to the selected survey item
            Survey sendOver = (Survey)listSurveys.SelectedItem;
            //Must use a dictionary to send over objects to new page or previous page
            var navigationParameter = new Dictionary<string, object>
            {
                { "PickedSurvey", sendOver}
            };
            //Sends the survey item over to the ViewSurveyPage so they can cast votes or view results
            await Shell.Current.GoToAsync($"{nameof(ViewSurveyPage)}", navigationParameter);
            //Makes it Null so that if the user navigates back they can reselect the same item again
            listSurveys.SelectedItem = null;
        }
    }
}