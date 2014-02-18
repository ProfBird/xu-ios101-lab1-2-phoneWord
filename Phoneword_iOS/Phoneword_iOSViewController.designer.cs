// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace Phoneword_iOS
{
	[Register ("Phoneword_iOSViewController")]
	partial class Phoneword_iOSViewController
	{
		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton CallButton { get; set; }

		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UITextField PhoneNumberText { get; set; }

		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton TranslateButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (CallButton != null) {
				CallButton.Dispose ();
				CallButton = null;
			}
			if (PhoneNumberText != null) {
				PhoneNumberText.Dispose ();
				PhoneNumberText = null;
			}
			if (TranslateButton != null) {
				TranslateButton.Dispose ();
				TranslateButton = null;
			}
		}
	}
}
