using Foundation;
using System;
using UIKit;
using CoreGraphics;
using AudioToolbox;

namespace Seasons
{
    public partial class AutumnViewController : UIViewController
    {
        NSUrl url;
        SystemSound Music;

        public AutumnViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            AutumnScrollView.ContentSize = new CoreGraphics.CGSize(AutumnView.Frame.Width + 1000, AutumnView.Frame.Height - 10);
            AutumnScrollView.ContentSize = AutumnImageView.Image.Size;

        }

        partial void ScareCrow_TouchUpInside(UIButton sender)
        {
            Music.Dispose();
            url = NSUrl.FromFilename("Sound/springmusic.mp3");
            Music = new SystemSound(url);
            Music.PlaySystemSound();
        }
    }
}