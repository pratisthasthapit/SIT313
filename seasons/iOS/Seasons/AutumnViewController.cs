using Foundation;
using System;
using UIKit;
using CoreGraphics;

namespace Seasons
{
    public partial class AutumnViewController : UIViewController
    {
        //private const string V = @"autumnbg.png";

        public AutumnViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            AutumnScrollView.ContentSize = new CoreGraphics.CGSize(AutumnView.Frame.Width + 1000, AutumnView.Frame.Height - 10);
            // Perform any additional setup after loading the view, typically from a nib.
            //UIImage background = [UIImage background: @"autumnbg.png"];
            //AutumnScrollView = new UIScrollView(new CGRect(0, 65, View.Frame.Width, View.Frame.Height));
            //View.AddSubview(AutumnScrollView);            
            AutumnScrollView.ContentSize = AutumnImageView.Image.Size;            
            //AutumnScrollView.AddSubview(AutumnImageView);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        
    }
}