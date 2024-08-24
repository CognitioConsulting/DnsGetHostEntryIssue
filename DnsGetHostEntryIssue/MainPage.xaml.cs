using System.Linq;
using System.Net;

namespace DnsGetHostEntryIssue
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private async void ConnectButtonClicked(object sender, EventArgs e)
		{
			Result.Text = "";
			Result.BackgroundColor = Colors.Transparent;

			try
			{
				var hostEntry = await Dns.GetHostEntryAsync(ServerAddress.Text);
				Result.Text += $"Dns.GetHostEntryAsync(): OK \r\n\r\nHostName: '{hostEntry.HostName}', Address.First(): '{hostEntry.AddressList.FirstOrDefault()}' ";
				Result.BackgroundColor = Colors.PaleTurquoise;
			}
			catch (Exception ex)
			{
				Result.Text += $"Dns.GetHostEntryAsync(): Error \t\n\r\n{ex.Message}";
				Result.BackgroundColor = Colors.LightPink;
			}
			


		}
	}

}
