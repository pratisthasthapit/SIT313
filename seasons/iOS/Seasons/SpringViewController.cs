using Foundation;
using System;
using UIKit;
using CoreGraphics;

namespace Seasons
{
    public partial class SpringViewController : UIViewController
    {
        public SpringViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            SpringScrollView = new UIScrollView(new CGRect(0, 65, View.Frame.Width, View.Frame.Height));
            View.AddSubview(SpringScrollView);
            SpringScrollView.ContentSize = SpringImageView.Image.Size;
            SpringScrollView.AddSubview(SpringImageView);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

    }
}