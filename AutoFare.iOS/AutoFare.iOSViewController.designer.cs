// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace AutoFare.iOS
{
	[Register ("AutoFare_iOSViewController")]
	partial class AutoFare_iOSViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnCalculateFare { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblFare { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField txtDistance { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (txtDistance != null) {
				txtDistance.Dispose ();
				txtDistance = null;
			}

			if (btnCalculateFare != null) {
				btnCalculateFare.Dispose ();
				btnCalculateFare = null;
			}

			if (lblFare != null) {
				lblFare.Dispose ();
				lblFare = null;
			}
		}
	}
}
