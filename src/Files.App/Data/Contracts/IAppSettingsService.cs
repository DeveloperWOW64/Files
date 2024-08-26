﻿// Copyright (c) 2018-2024 Files Community
// Licensed under the MIT License. See the LICENSE file in the root directory.

namespace Files.App.Data.Contracts
{
	public interface IAppSettingsService : IBaseSettingsService, INotifyPropertyChanged
	{
		/// <summary>
		/// Gets or sets a value indicating whether or not to show the StatusCenter teaching tip.
		/// </summary>
		bool ShowStatusCenterTeachingTip { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not to show the notification to inform background running.
		/// </summary>
		bool ShowBackgroundRunningNotification { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not to restore tabs on startup.
		/// This is used when prompting users to restart after changing the app language.
		/// </summary>
		bool RestoreTabsOnStartup { get; set; }
	}
}
