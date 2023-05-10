using Firebase.Auth.Providers;
using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CKC_App_4155.ViewModel
{
    internal class SignInViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public ICommand SignInCommand { get; }
        public ICommand SignOutCommand { get; }
        public ICommand ResetPasswordCommand { get; }

        private FirebaseAuthClient client;

        public SignInViewModel()
        {
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

            client = new FirebaseAuthClient(config);

            SignInCommand = new Command(async () => await SignIn());
            SignOutCommand = new Command(async () => await SignOut());
            ResetPasswordCommand = new Command(async () => await ResetPassword());
        }


        private async Task SignIn()
        {

            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                // Display an error message if the email or password is not entered
                await Application.Current.MainPage.DisplayAlert("Error", "Please enter your email and password", "OK");
                return;
            }

            var userCredential = await client.SignInWithEmailAndPasswordAsync(Email, Password);

            var user = userCredential.User;
            var uid = user.Uid;

            await Application.Current.MainPage.Navigation.PushAsync(new HomePage());
            await Application.Current.MainPage.DisplayAlert("Success", "Account logged in successfully", "OK");
            Debug.WriteLine(uid + " signed in");
        }
        private async Task SignOut()
        {
            // Sign out user
            client.SignOut();
            // Navigate back to login page
            await Application.Current.MainPage.Navigation.PushAsync(new MainPage());
        }

        private async Task ResetPassword()
        {
            // Send password reset email
            await client.ResetEmailPasswordAsync(Email);
        }
    }

}
