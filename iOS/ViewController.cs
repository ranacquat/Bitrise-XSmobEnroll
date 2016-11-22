using System;

using UIKit;

namespace IsItU.iOS
{
	public partial class ViewController : UIViewController
	{
		int count = 1;

		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Perform any additional setup after loading the view, typically from a nib.
			Button.AccessibilityIdentifier = "myButton";
			Button.TouchUpInside += delegate
			{
				var title = string.Format("{0} clicks!", count++);
				Button.SetTitle(title, UIControlState.Normal);
			};

			Button.TouchUpInside += (object sender, EventArgs e) =>
			{
				// ...otherwise show an alert dialog

					var alert = UIAlertController.Create("TEST...", "ALRIGHT !", UIAlertControllerStyle.Alert);
					alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
					PresentViewController(alert, true, null);

			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}
	}
}
