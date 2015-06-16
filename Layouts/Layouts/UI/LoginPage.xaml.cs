using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Layouts
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();

			NavigationPage.SetBackButtonTitle (this, "Back");

			TapGestureRecognizer forgotPasswordLabelGesture = new TapGestureRecognizer ();
			forgotPasswordLabelGesture.NumberOfTapsRequired = 1;
			forgotPasswordLabelGesture.Tapped += forgotPasswordLabelGestureAction;
			forgotPasswordLabel.GestureRecognizers.Add (forgotPasswordLabelGesture);

			TapGestureRecognizer loginLabelGesture = new TapGestureRecognizer ();
			loginLabelGesture.NumberOfTapsRequired = 1;
			loginLabelGesture.Tapped += loginLabelGestureGestureAction;
			loginLabel.GestureRecognizers.Add (loginLabelGesture);
		}

		public void forgotPasswordLabelGestureAction (object sender, EventArgs e)
		{
			DisplayAlert ("App","Nothing Implemented","OK");
		}
		public void loginLabelGestureGestureAction (object sender, EventArgs e)
		{
			this.Navigation.PushAsync (new ExpandCollapse ());
		}
	}
}

