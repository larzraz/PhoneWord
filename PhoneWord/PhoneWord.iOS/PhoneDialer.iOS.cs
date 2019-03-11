using System.Threading.Tasks;
using Foundation;
using PhoneWord;
using PhoneWord.iOS;
using UIKit;
using Xamarin.Forms;
[assembly: Dependency(typeof(PhoneDialer))]

namespace PhoneWord.iOS
{
	public class PhoneDialer : IDialer
	{
		public Task<bool> DialAsync(string number)
		{
			return Task.FromResult(
				UIApplication.SharedApplication.OpenUrl(
				new NSUrl("tel:" + number))
			);
		}
	}
}
