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
    [Register ("WinterViewController")]
    partial class WinterViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView WinterImageView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIScrollView WinterScrollView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView WinterView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (WinterImageView != null) {
                WinterImageView.Dispose ();
                WinterImageView = null;
            }

            if (WinterScrollView != null) {
                WinterScrollView.Dispose ();
                WinterScrollView = null;
            }

            if (WinterView != null) {
                WinterView.Dispose ();
                WinterView = null;
            }
        }
    }
}