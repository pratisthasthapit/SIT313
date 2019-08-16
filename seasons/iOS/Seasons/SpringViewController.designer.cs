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
    [Register ("SpringViewController")]
    partial class SpringViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView SpringImageView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIScrollView SpringScrollView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView SpringView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (SpringImageView != null) {
                SpringImageView.Dispose ();
                SpringImageView = null;
            }

            if (SpringScrollView != null) {
                SpringScrollView.Dispose ();
                SpringScrollView = null;
            }

            if (SpringView != null) {
                SpringView.Dispose ();
                SpringView = null;
            }
        }
    }
}