using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EmbeddedNetworkLab.Core.Services;
using EmbeddedNetworkLab.Infrastructure.Services;
using EmbeddedNetworkLab.UI.Modules;
using EmbeddedNetworkLab.UI.Modules.Throughput;
using System.Windows;



namespace EmbeddedNetworkLab.UI.Shell
{
	public partial class MainViewModel : ObservableObject
	{
		private readonly IThroughputService _throughputService;
		private readonly ThroughputViewModel _throughputModule;

		public MainViewModel()
		{
			_throughputService = new ThroughputService();
			_throughputModule = new ThroughputViewModel(_throughputService);

		}

		[ObservableProperty]
		private string selectedModuleTitle = "Select a module";

		[ObservableProperty]
		private string consoleText = "Console initialized...";

		[ObservableProperty]
		private ModuleViewModel currentModule;

		[RelayCommand]
		private void OpenThroughput()
		{
			CurrentModule = _throughputModule;
			AppendLog(CurrentModule.Name + " selected");
		}

		// Method to append log messages to the console
		private void AppendLog(string message)
		{
			ConsoleText += $"\n[{DateTime.Now:HH:mm:ss}] {message}";
		}

	}

}

