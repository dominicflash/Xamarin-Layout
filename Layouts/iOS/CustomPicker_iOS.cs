using System;
using Xamarin.Forms;
using UIKit;
using Foundation;
using Layouts;
using Layouts.iOS;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer (typeof(CustomPicker), typeof(CustomPickerRendered_iOS))]

namespace Layouts.iOS
{
	public class CustomPickerRendered_iOS : PickerRenderer
	{

		public CustomPickerRendered_iOS ()
		{

		}

		protected override void OnElementChanged (ElementChangedEventArgs<Picker> e)
		{
			base.OnElementChanged (e);
			if (Control != null) {   



				// perform initial setup
				// do whatever you want to the UITextField here!
				Control.BackgroundColor = UIColor.Clear;
				Control.BorderStyle = UITextBorderStyle.None;
				Control.Font = UIFont.FromName ("Arial", 13);
				Control.TextColor = UIColor.FromRGB (16,43,69);


				//Change Placeholder text color
				//NSAttributedString placeholderString = new NSAttributedString(Control.Placeholder, new UIStringAttributes(){ ForegroundColor = UIColor.White,Font=UIFont.FromName ("Arial", 12) });
				//Control.AttributedPlaceholder = placeholderString;


			}
		}
	}
}

