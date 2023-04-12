using CKC_App_4155.Objects;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Controls.Internals;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;

namespace CKC_App_4155;
[QueryProperty(nameof(Thing), "Thing")]

public partial class SurveysPage : ContentPage
{
    public ObservableCollection<Survey> SurveysToBeList { get; } = new ObservableCollection<Survey>();
    //List<Survey> surveys = new List<Survey>();
    public Survey test = new();
    public Survey Thing
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
        //Items are counted for in the object and the list view lists the items but issue is that the list view can't seem to find it through binding
        listSurveys.ItemsSource = SurveysToBeList;
    }

    void GotoSurvey(object sender, EventArgs e)
    {
        //Survey temp2 = surveys[0];
        //string test = "pop " + temp2.getTitle();
        //Debug.WriteLine(test);
    }
}