// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Seasons
{
    [Register ("AutumnViewController")]
    partial class AutumnViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView AutumnImageView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIScrollView AutumnScrollView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView AutumnView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (AutumnImageView != null) {
                AutumnImageView.Dispose ();
                AutumnImageView = null;
            }

            if (AutumnScrollView != null) {
                AutumnScrollView.Dispose ();
                AutumnScrollView = null;
            }

            if (AutumnView != null) {
                AutumnView.Dispose ();
                AutumnView = null;
            }
        }
    }
}