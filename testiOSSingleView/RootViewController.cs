using System;
using System.Drawing;
using Foundation;
using UIKit;

using SharedProject1;
namespace testiOSSingleView
{
    public partial class RootViewController : UIViewController
    {
        static bool UserInterfaceIdiomIsPhone
        {
            get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
        }

        public RootViewController(IntPtr handle) : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.txtZipCode.ShouldReturn += (textField) =>
            {
                textField.ResignFirstResponder();
                return true;
            };
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion


        partial void UIButton30_TouchUpInside(UIButton sender)
        {
            if (String.IsNullOrEmpty( this.txtZipCode.Text)) {
                return;
            }
            String zipCode = this.txtZipCode.Text;
            Weather weather = Core.GetWeather(zipCode).Result;
            if (weather != null)
            {
                dataStatus.Text = weather.Title;
                dataTemp.Text = weather.Temperature;
               dataWind.Text = weather.Wind;
               dataVisibility.Text = weather.Visibility;
                dataHumidity.Text = weather.Humidity;
               dataSunrise.Text = weather.Sunrise;
               dataSunset.Text = weather.Sunset;

              //  dataStatus.Text = "You Can Search Again";
            }
            else
            {
                dataStatus.Text = "Couldn't find any results";
            }
        }
    }
}