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
    [Register ("MainViewController")]
    partial class MainViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton AutumnBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SpringBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SummerBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton WinterBtn { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (AutumnBtn != null) {
                AutumnBtn.Dispose ();
                AutumnBtn = null;
            }

            if (SpringBtn != null) {
                SpringBtn.Dispose ();
                SpringBtn = null;
            }

            if (SummerBtn != null) {
                SummerBtn.Dispose ();
                SummerBtn = null;
            }

            if (WinterBtn != null) {
                WinterBtn.Dispose ();
                WinterBtn = null;
            }
        }
    }
}