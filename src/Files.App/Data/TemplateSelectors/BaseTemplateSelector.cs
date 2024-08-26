// Copyright (c) 2018-2024 Files Community
// Licensed under the MIT License. See the LICENSE file in the root directory.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Files.App.Data.TemplateSelectors
{
	internal abstract class BaseTemplateSelector<TItem> : DataTemplateSelector
	{
		protected sealed override DataTemplate SelectTemplateCore(object item)
		{
			return SelectTemplateCore((TItem?)item);
		}

		protected sealed override DataTemplate SelectTemplateCore(object item, DependencyObject container)
		{
			return SelectTemplateCore((TItem?)item, container);
		}

		protected virtual DataTemplate SelectTemplateCore(TItem? item)
		{
			return base.SelectTemplateCore(item);
		}

		protected virtual DataTemplate SelectTemplateCore(TItem? item, DependencyObject container)
		{
			return base.SelectTemplateCore(item, container);
		}
	}
}
