using Firebase.Auth;
using Firebase.Auth.Providers;
using System.Diagnostics;
using CKC_App_4155.ViewModel;

namespace CKC_App_4155;

public partial class CreateAccount : ContentPage
{
	public CreateAccount()
	{
		InitializeComponent();
        BindingContext = new SignUpViewModel();
    }
    
}