using CKC_App_4155.Objects;
using CKC_App_4155.ViewModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Controls.Internals;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;

namespace CKC_App_4155;
[QueryProperty(nameof(NewSurvey), "NewSurvey")]

public partial class SurveysPage : ContentPage
{
    public ObservableCollection<Survey> surveysToBeList = new ObservableCollection<Survey>();
    public ObservableCollection<Survey> SurveysToBeList {
        get { return surveysToBeList; }
        set { surveysToBeList = value; }
    }
    //List<Survey> surveys = new List<Survey>();
    public Survey test = new();
    public Survey NewSurvey
    {
        get => test;
        set
        {
            test = value;
            OnPropertyChanged(nameof(test));
            SurveysToBeList.Add(test);
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

    void GotoSurvey(object sender, EventArgs e)
    {
        //Survey temp2 = surveys[0];
        //string test = "pop " + temp2.getTitle();
        //Debug.WriteLine(test);
    }
    async void CreateSurvey(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateSurveyPage());
    }

    private async void listSurveys_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (listSurveys.SelectedItem != null)
        {
            Survey sendOver = (Survey)listSurveys.SelectedItem;
            var navigationParameter = new Dictionary<string, object>
            {
                { "PickedSurvey", sendOver}
            };
            await Shell.Current.GoToAsync($"{nameof(ViewSurveyPage)}", navigationParameter);
        }
    }
}