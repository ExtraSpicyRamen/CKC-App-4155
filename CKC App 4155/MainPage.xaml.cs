using Firebase.Auth;
using Firebase.Auth.Providers;
using System.Diagnostics;

namespace CKC_App_4155;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    async void GotoCreateAccount(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateAccount());
    }
    async void GotoForgotPassword(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ForgotPasswordPage());
    }

    private async void SignIn(object sender, EventArgs e)
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
        String email = UserEmail.Text;
        String password = UserPassword.Text;

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            // Display an error message if the email or password is not entered
            await DisplayAlert("Error", "Please enter your email and password", "OK");
            return;
        }

        var userCredential = await client.SignInWithEmailAndPasswordAsync(email, password);

        var user = userCredential.User;
        var uid = user.Uid;

        await Navigation.PushAsync(new HomePage());
        await DisplayAlert("Success", "Account logged in successfully", "OK");

        Debug.WriteLine(uid + " signed in");
    }

    }


