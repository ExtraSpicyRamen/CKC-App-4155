using CKC_App_4155.Objects;
using CKC_App_4155.objects;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKC_App_4155.ViewModel
{
    [QueryProperty(nameof(Thing), nameof(Thing))]
    public partial class EventPageViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Event> events;

        [ObservableProperty]
        Event thing;
    }
}
