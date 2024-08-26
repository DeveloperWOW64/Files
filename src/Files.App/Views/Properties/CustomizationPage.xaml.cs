// Copyright (c) 2018-2024 Files Community
// Licensed under the MIT License. See the LICENSE file in the root directory.

using Files.App.Data.Parameters;
using Files.App.ViewModels.Properties;
using Microsoft.UI.Xaml.Navigation;

namespace Files.App.Views.Properties
{
	public sealed partial class CustomizationPage : BasePropertiesPage
	{
		private CustomizationViewModel CustomizationViewModel { get; set; }

		public CustomizationPage()
		{
			InitializeComponent();
		}

		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			var parameter = (PropertiesPageNavigationParameter)e.Parameter;

			base.OnNavigatedTo(e);

			CustomizationViewModel = new(AppInstance, BaseProperties, parameter.Window.AppWindow);
		}

		public override async Task<bool> SaveChangesAsync()
			=> await CustomizationViewModel.UpdateIcon();

		public override void Dispose()
		{
		}
	}
}
