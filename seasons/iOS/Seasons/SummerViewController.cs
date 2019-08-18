using Foundation;
using System;
using UIKit;
using CoreGraphics;

namespace Seasons
{
    public partial class SummerViewController : UIViewController
    {
        public SummerViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            SummerScrollView = new UIScrollView(new CGRect(0, 65, View.Frame.Width, View.Frame.Height));
            View.AddSubview(SummerScrollView);
            SummerScrollView.ContentSize = SummerImageView.Image.Size;
            SummerScrollView.AddSubview(SummerImageView);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}