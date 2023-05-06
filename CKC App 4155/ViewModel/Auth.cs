using Firebase.Auth.Providers;
using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CKC_App_4155.ViewModel
{
    public class Auth : ContentPage
    {
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var config = new FirebaseAuthConfig
            {
                ApiKey = "AIzaSyBH_-jT47UI-yQg6G5bKnZA3C0Cg5lxpPM",
                AuthDomain = "ckc-app-4155.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
                {
                new GoogleProvider().AddScopes("email"),
                new EmailProvider()
                },
            };

            var client = new FirebaseAuthClient(config);

            var user = FirebaseAuth.Instance.CurrentUser;

            if (user == null)
            {
                // Display an error message if the user is not signed in
                await DisplayAlert("Error", "You must be signed in to access this page", "OK");
                await Navigation.PopAsync();
                return;
            }
        }
    }
}
