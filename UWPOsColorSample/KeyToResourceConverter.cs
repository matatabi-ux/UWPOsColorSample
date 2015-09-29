using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace UWPOsColorSample
{
    /// <summary>
    /// Resource key string to resource value converter
    /// </summary>
    public class KeyToResourceConverter : IValueConverter
    {
        /// <summary>
        /// ResourceKey to resource value convert
        /// </summary>
        /// <param name="value">ResourceKey string</param>
        /// <param name="targetType">target type</param>
        /// <param name="parameter">paraneter</param>
        /// <param name="language">culture</param>
        /// <returns>resource value</returns>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null || !App.Current.Resources.ContainsKey(value.ToString()))
            {
                return DependencyProperty.UnsetValue;
            }

            return App.Current.Resources[value.ToString()];
        }

        /// <summary>
        /// Resource value to ResourceKey convert
        /// </summary>
        /// <param name="value">resource value</param>
        /// <param name="targetType">target type</param>
        /// <param name="parameter">paraneter</param>
        /// <param name="language">culture</param>
        /// <returns>ResourceKey string</returns>
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotSupportedException();
        }
    }
}
