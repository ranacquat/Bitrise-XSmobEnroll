// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
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
            if (nameField != null) {
                nameField.Dispose ();
                nameField = null;
            }

            if (surnameField != null) {
                surnameField.Dispose ();
                surnameField = null;
            }
        }
    }
}