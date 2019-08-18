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

            WinterScrollView = new UIScrollView(new CGRect(0, 65, View.Frame.Width, View.Frame.Height));
            View.AddSubview(WinterScrollView);
            WinterScrollView.ContentSize = WinterImageView.Image.Size;
            WinterScrollView.AddSubview(WinterImageView);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}