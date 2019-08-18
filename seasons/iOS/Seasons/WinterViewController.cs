using Foundation;
using System;
using UIKit;
using CoreGraphics;
using AudioToolbox;

namespace Seasons
{
    public partial class WinterViewController : UIViewController
    {
        
        public WinterViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            WinterScrollView.ContentSize = new CoreGraphics.CGSize(WinterView.Frame.Width + 1000, WinterView.Frame.Height - 10);
            WinterScrollView.ContentSize = WinterImageView.Image.Size;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}