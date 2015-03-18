// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace testiOSSingleView
{
	[Register ("RootViewController")]
	partial class RootViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel dataHumidity { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel dataStatus { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel dataSunrise { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel dataSunset { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel dataTemp { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel dataVisibility { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel dataWind { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtZipCode { get; set; }

		[Action ("UIButton30_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UIButton30_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (dataHumidity != null) {
				dataHumidity.Dispose ();
				dataHumidity = null;
			}
			if (dataStatus != null) {
				dataStatus.Dispose ();
				dataStatus = null;
			}
			if (dataSunrise != null) {
				dataSunrise.Dispose ();
				dataSunrise = null;
			}
			if (dataSunset != null) {
				dataSunset.Dispose ();
				dataSunset = null;
			}
			if (dataTemp != null) {
				dataTemp.Dispose ();
				dataTemp = null;
			}
			if (dataVisibility != null) {
				dataVisibility.Dispose ();
				dataVisibility = null;
			}
			if (dataWind != null) {
				dataWind.Dispose ();
				dataWind = null;
			}
			if (txtZipCode != null) {
				txtZipCode.Dispose ();
				txtZipCode = null;
			}
		}
	}
}
