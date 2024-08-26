// Copyright (c) 2018-2024 Files Community
// Licensed under the MIT License. See the LICENSE file in the root directory.

using Microsoft.UI.Xaml.Data;

namespace Files.App.Converters
{
	internal sealed class DateTimeOffsetToStringConverter : IValueConverter
	{
		private static readonly IDateTimeFormatter formatter = Ioc.Default.GetService<IDateTimeFormatter>();

		public object Convert(object value, Type targetType, object parameter, string language)
		{
			return value is null
				? string.Empty
				: formatter.ToLongLabel((DateTimeOffset)value);
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			try
			{
				return DateTimeOffset.Parse(value as string);
			}
			catch (FormatException)
			{
				return null;
			}
		}
	}
}
