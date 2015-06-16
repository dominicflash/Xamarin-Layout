using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Diagnostics;
using System.Collections.ObjectModel;


namespace Layouts
{
	public partial class ExpandCollapse : ContentPage
	{


		public ExpandCollapse ()
		{
			InitializeComponent ();


			//Set navigation title as "back"
			NavigationPage.SetBackButtonTitle (this, "Back");


			TapGestureRecognizer collapsAndExpandLayoutGesture = new TapGestureRecognizer ();
			collapsAndExpandLayoutGesture.NumberOfTapsRequired = 1;
			collapsAndExpandLayoutGesture.Tapped += collapsAndExpandLayoutAction;
			collapsAndExpandLayout.GestureRecognizers.Add (collapsAndExpandLayoutGesture);


			TapGestureRecognizer resellerProfileLayoutGesture = new TapGestureRecognizer ();
			resellerProfileLayoutGesture.NumberOfTapsRequired = 1;
			resellerProfileLayoutGesture.Tapped += resellerProfileLayoutAction;
			resellerProfileLayout.GestureRecognizers.Add (resellerProfileLayoutGesture);

			TapGestureRecognizer shippingProfileLayoutGesture = new TapGestureRecognizer ();
			shippingProfileLayoutGesture.NumberOfTapsRequired = 1;
			shippingProfileLayoutGesture.Tapped += shippingProfileLayoutAction;
			shippingProfileLayout.GestureRecognizers.Add (shippingProfileLayoutGesture);


		}


		public void collapsAndExpandLayoutAction (object sender, EventArgs e)
		{

			// Just to explaining, how we are displaying activity indicator
			this.showActivityIndicator ();
			Device.StartTimer (TimeSpan.FromSeconds (2), () => {

				this.hideActivityIndicator();


				//stop timer 
				return false; 
			});


			//Here we are checking that any layout is visible or not
			//Based on that we are hiding/displaying the layouts

			if (shippingDetailsLayout.IsVisible ||
				resellerProfileDetailsLayout.IsVisible) {

				shippingDetailsLayout.IsVisible = false;
				resellerProfileDetailsLayout.IsVisible = false;

			} else {

				shippingDetailsLayout.IsVisible = true;
				resellerProfileDetailsLayout.IsVisible = true;
			}

		}

		public void resellerProfileLayoutAction (object sender, EventArgs e)
		{
			if (resellerProfileDetailsLayout.IsVisible) {
				resellerProfileDetailsLayout.IsVisible = false;
			} else {
				resellerProfileDetailsLayout.IsVisible = true;

			}
		}
		public void shippingProfileLayoutAction (object sender, EventArgs e)
		{
			if (shippingDetailsLayout.IsVisible) {
				shippingDetailsLayout.IsVisible = false;
			} else {
				shippingDetailsLayout.IsVisible = true;

			}
		}
		public void showActivityIndicator ()
		{
			activityIndicatorLayout.IsVisible = true;
		}

		public void hideActivityIndicator ()
		{
			activityIndicatorLayout.IsVisible = false;
		}
	}
}


