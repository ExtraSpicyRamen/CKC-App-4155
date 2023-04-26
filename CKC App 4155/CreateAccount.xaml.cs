using Firebase.Auth;
using Firebase.Auth.Providers;
using System.Diagnostics;

namespace CKC_App_4155;

public partial class CreateAccount : ContentPage
{
	public CreateAccount()
	{
		InitializeComponent();
	}

    private async void SignUp(object sender, EventArgs e)
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
        String userName = UserName.Text;
        String phoneNumber = UserPhoneNumber.Text;
        String password = UserPassword.Text;
        String confirmPassword = UserConfirmPassword.Text;

        if (password != confirmPassword)
        {
            // Display an error message if the passwords do not match
            await DisplayAlert("Error", "Passwords do not match", "OK");
            return;
        }

        var userCredential = await client.CreateUserWithEmailAndPasswordAsync(email, password);

        var user = userCredential.User;
        var uid = user.Uid;
        Debug.WriteLine(uid + " signed in");
    }
}