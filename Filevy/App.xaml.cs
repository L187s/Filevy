using System;
using System.Windows;

namespace Filevy
{
    public partial class App : Application
    {
        public static void SwitchTheme(bool isDark)
        {
            var dicts = Current.Resources.MergedDictionaries;
            if (dicts.Count > 0) dicts.RemoveAt(0);
            dicts.Insert(0, new ResourceDictionary
            {
                Source = new Uri($"Themes/{(isDark ? "Dark" : "Light")}Theme.xaml", UriKind.Relative)
            });
        }
    }
}