using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace AutoCompleteDemo {
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate {
		UIWindow window;
		AutoCompleteDemoViewController viewController;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options) {
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			
			viewController = new AutoCompleteDemoViewController ();
			window.RootViewController = viewController;
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}

