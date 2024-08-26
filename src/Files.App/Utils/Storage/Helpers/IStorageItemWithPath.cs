// Copyright (c) 2018-2024 Files Community
// Licensed under the MIT License. See the LICENSE file in the root directory.

using Windows.Storage;

namespace Files.App.Utils.Storage
{
	public interface IStorageItemWithPath
	{
		public string Name { get; }

		public string Path { get; }

		public IStorageItem Item { get; }

		public FilesystemItemType ItemType { get; }
	}
}
