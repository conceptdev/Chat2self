//
// Sample shows how to use MonoTouch.Dialog to create an iPhone SMS-like 
// display of conversations
//
// Author:
//   Miguel de Icaza 
//
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using MonoTouch.Dialog;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace BubbleCell
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		DialogViewController chat;
		UIWindow window;
		
		static void Main (string[] args)
		{
			UIApplication.Main (args, null, "AppDelegate");
		}

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);

			chat = new BubbleViewController();

			window.AddSubview (chat.View);
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}