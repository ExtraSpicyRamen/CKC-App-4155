using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CKC_App_4155.ViewModel
{
    public partial class AdminDashViewModel : ObservableObject
    {
        [RelayCommand]
        async Task Navigate() =>
            await AppShell.Current.GoToAsync(nameof(EventDetailPage));
    }
}
