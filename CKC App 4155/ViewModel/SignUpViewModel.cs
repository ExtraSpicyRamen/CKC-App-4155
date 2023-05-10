using Firebase.Auth.Providers;
using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CKC_App_4155.ViewModel
{
    internal class SignUpViewModel
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public ICommand SignUpCommand { get; }

        public SignUpViewModel()
        {
            SignUpCommand = new Command(async () => await SignUp());
        }
        private async Task SignUp()
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

            var client = new FirebaseAuthClient(config);

            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(PhoneNumber) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(ConfirmPassword))
            {
                // Display an error message if any of the input fields are empty
                await Application.Current.MainPage.DisplayAlert("Error", "Please fill in all fields", "OK");
                return;
            }

            if (Password != ConfirmPassword)
            {
                // Display an error message if the passwords do not match
                await Application.Current.MainPage.DisplayAlert("Error", "Passwords do not match", "OK");
                return;
            }

            var userCredential = await client.CreateUserWithEmailAndPasswordAsync(Email, Password);

            var user = userCredential.User;
            var uid = user.Uid;

            await Application.Current.MainPage.Navigation.PushAsync(new MainPage());
            await Application.Current.MainPage.DisplayAlert("Success", "Account created successfully", "OK");
            Debug.WriteLine(uid + " signed in");
        }
    }

    }

