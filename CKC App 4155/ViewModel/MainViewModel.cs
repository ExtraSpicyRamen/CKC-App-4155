using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CKC_App_4155.ViewModel
{
    public partial class MainViewModel : ObservableObject   
    {

        [RelayCommand]
        async Task Navigate() => 
            await AppShell.Current.GoToAsync(nameof(EventDetailPage));
    }
}
