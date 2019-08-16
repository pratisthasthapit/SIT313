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
    [Register ("SummerViewController")]
    partial class SummerViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView SummerImageView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIScrollView SummerScrollView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView SummerView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (SummerImageView != null) {
                SummerImageView.Dispose ();
                SummerImageView = null;
            }

            if (SummerScrollView != null) {
                SummerScrollView.Dispose ();
                SummerScrollView = null;
            }

            if (SummerView != null) {
                SummerView.Dispose ();
                SummerView = null;
            }
        }
    }
}