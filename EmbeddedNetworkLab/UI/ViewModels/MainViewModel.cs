using CommunityToolkit.Mvvm.ComponentModel;

namespace EmbeddedNetworkLab.UI.ViewModel
{
	public partial class MainViewModel : ObservableObject
	{
		[ObservableProperty]
		private string selectedModuleTitle = "Select a module";

		[ObservableProperty]
		private string consoleText = "Console initialized...";
	}
}

