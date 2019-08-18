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

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton EasterBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton GhostBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton HauntedHouseBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ScareCrowBtn { get; set; }

        [Action ("ScareCrow_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ScareCrow_TouchUpInside (UIKit.UIButton sender);

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

            if (EasterBtn != null) {
                EasterBtn.Dispose ();
                EasterBtn = null;
            }

            if (GhostBtn != null) {
                GhostBtn.Dispose ();
                GhostBtn = null;
            }

            if (HauntedHouseBtn != null) {
                HauntedHouseBtn.Dispose ();
                HauntedHouseBtn = null;
            }

            if (ScareCrowBtn != null) {
                ScareCrowBtn.Dispose ();
                ScareCrowBtn = null;
            }
        }
    }
}