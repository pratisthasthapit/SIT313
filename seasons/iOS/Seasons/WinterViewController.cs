using Foundation;
using System;
using UIKit;
using CoreGraphics;

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
            // Perform any additional setup after loading the view, typically from a nib.

            WinterScrollView = new UIScrollView(new CGRect(0, 0, View.Frame.Width, View.Frame.Height));
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