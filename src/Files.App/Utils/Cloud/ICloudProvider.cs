﻿// Copyright (c) 2018-2024 Files Community
// Licensed under the MIT License. See the LICENSE file in the root directory.

namespace Files.App.Utils.Cloud
{
	public interface ICloudProvider : IEquatable<ICloudProvider>
	{
		public CloudProviders ID { get; }

		public string Name { get; }

		public string SyncFolder { get; }

		public byte[]? IconData { get; }
	}
}
