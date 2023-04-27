namespace CKC_App_4155;

using CKC_App_4155.objects;
using CKC_App_4155.Objects;
using CKC_App_4155.ViewModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Controls.Internals;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;


[QueryProperty(nameof(NewEvent), "NewEvent")]
public partial class EventPage : ContentPage
{
    public ObservableCollection<Event> eventsToBeList = new ObservableCollection<Event>();

    public ObservableCollection<Event> EventsToBeList
    {
        get { return eventsToBeList; }
        set { eventsToBeList = value; }
    }

    public Event tester = new Event();

    Event check = new Event();

    public Event NewEvent
    {
        get => tester;
        set
        {
            tester = value;
            OnPropertyChanged(nameof(tester));

            if (!tester.Equals(check))
            {
                eventsToBeList.Add(tester);
                
                check = tester;
            }
        }
    }
    public EventPage()
	{
		InitializeComponent();
        Event t = new Event();
        t.setTitle("testing");
        EventsToBeList.Add(t);
        listEvents.ItemsSource = EventsToBeList;
    }

    async void CreateEvent(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(AddEvent)}");
    }

    private async void listEvents_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (listEvents.SelectedItem != null)
        {
            
            Event sendOver = (Event)listEvents.SelectedItem;
            
            var navigationParameter = new Dictionary<string, object>
            {
                { "PickedEvent", sendOver}
            };
         
            await Shell.Current.GoToAsync($"{nameof(EventDetailPage)}", navigationParameter);
            
            listEvents.SelectedItem = null;
        }
    }
}