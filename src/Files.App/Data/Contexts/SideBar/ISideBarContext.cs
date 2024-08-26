﻿// Copyright (c) 2018-2024 Files Community
// Licensed under the MIT License. See the LICENSE file in the root directory.

namespace Files.App.Data.Contexts
{
	/// <summary>
	/// Represents context for <see cref="UserControls.Sidebar.SidebarView"/>.
	/// </summary>
	public interface ISidebarContext
	{
		/// <summary>
		/// Gets the last sidebar right clicked item
		/// </summary>
		INavigationControlItem? RightClickedItem { get; }

		/// <summary>
		/// Gets the value that indicates whether any item has been right clicked
		/// </summary>
		bool IsItemRightClicked { get; }

		/// <summary>
		/// Gets the value that indicates whether right clicked item is a pinned folder item
		/// </summary>
		bool IsPinnedFolderItem { get; }

		/// <summary>
		/// Gets the drive item to open if any
		/// </summary>
		DriveItem? OpenDriveItem { get; }
	}
}
