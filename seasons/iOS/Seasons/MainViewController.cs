using Foundation;
using System;
using UIKit;
using CoreGraphics;
using AudioToolbox;

namespace Seasons
{
    public partial class MainViewController : UIViewController
    {
        NSUrl url;
        SystemSound Music;

        public MainViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            //line 23-26, 32-35 inspired by Daniel Wood: https://www.codemahal.com/video/play-audio-in-an-ios-app-with-xamarin/


            base.ViewDidLoad();
            url = NSUrl.FromFilename("Sound/springmusic.mp3");
            Music = new SystemSound(url);
            Music.PlaySystemSound();

            // Perform any additional setup after loading the view, typically from a nib.
            SummerBtn.TouchUpInside += (o, s) =>
            {
                Music.Dispose();
                url = NSUrl.FromFilename("Sound/autumnmusic.mp3");
                Music = new SystemSound(url);
                Music.PlaySystemSound();
            };

            WinterBtn.TouchUpInside += (o, s) =>
            {
                Music.Dispose();
                url = NSUrl.FromFilename("Sound/wintermusic.mp3");
                Music = new SystemSound(url);
                Music.PlaySystemSound();
            };

            AutumnBtn.TouchUpInside += (o, s) =>
            {
                Music.Dispose();
                url = NSUrl.FromFilename("Sound/autumnmusic.mp3");
                Music = new SystemSound(url);
                Music.PlaySystemSound();
            };

            SpringBtn.TouchUpInside += (o, s) =>
            {
                Music.Dispose();
                url = NSUrl.FromFilename("Sound/springmusic.mp3");
                Music = new SystemSound(url);
                Music.PlaySystemSound();
            };

            Music.PlaySystemSound();

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        
    }
}