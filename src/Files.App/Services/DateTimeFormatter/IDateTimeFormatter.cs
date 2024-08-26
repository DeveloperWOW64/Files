﻿// Copyright (c) 2018-2024 Files Community
// Licensed under the MIT License. See the LICENSE.

namespace Files.App.Services.DateTimeFormatter
{
	public interface IDateTimeFormatter
	{
		string Name { get; }

		string ToShortLabel(DateTimeOffset offset);
		string ToLongLabel(DateTimeOffset offset);

		ITimeSpanLabel ToTimeSpanLabel(DateTimeOffset offset, GroupByDateUnit unit);
	}
}
