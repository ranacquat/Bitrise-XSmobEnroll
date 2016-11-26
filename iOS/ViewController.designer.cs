// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace IsItU.iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton Button { get; set; }

		[Outlet]
		UIKit.UITextField nameField { get; set; }

		[Outlet]
		UIKit.UITextField surnameField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (surnameField != null) {
				surnameField.Dispose ();
				surnameField = null;
			}

			if (nameField != null) {
				nameField.Dispose ();
				nameField = null;
			}

			if (Button != null) {
				Button.Dispose ();
				Button = null;
			}
		}
	}
}
