using Firebase.Auth;
using Firebase.Auth.Providers;
using System.Diagnostics;
using CKC_App_4155.ViewModel;

namespace CKC_App_4155;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new SignInViewModel();
    }
    
    }

    


