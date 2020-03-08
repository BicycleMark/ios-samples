using System;
using Foundation;
using MonoTouch.Dialog;
using UIKit;

namespace PasswordValidator
{
	
	public partial class AppDelegate : UIApplicationDelegate
	{
		DialogViewController dynamic;
		BindingContext bc;
		AccountInfo account;

		public void AddUser()
		{
			account = new AccountInfo();

			context = new BindingContext(this, account, "Settings");

			if (dynamic != null)
				dynamic.Dispose();

			dynamic = new DialogViewController(context.Root, true);
			_nav.PushViewController(dynamic, true);
		}
		class AccountInfo
		{
			[Section("New Credentials")]

			[Entry("Enter your login name")]
			public string Username;

			[Password("Enter your password")]
			public string Password;

			[Section("Tap to Validate")]
			[OnTap("Validate")]
			[Preserve]
			public string Login;
		}

		public void Validate()
		{
				

			// Fetch the edited values.
			context.Fetch();

				
		}

		public void ValidateUser()
		{
			account = new AccountInfo();

			context = new BindingContext(this, account, "Account");

			if (dynamic != null)
				dynamic.Dispose();

			dynamic = new DialogViewController(context.Root, true);
			_nav.PushViewController(dynamic, true);
		}
	}
}

