using System;
using System.Runtime.InteropServices;

using Windows.ApplicationModel.Resources;

namespace NEWPROJECT_Windows_Template_Library.Helpers
{
    internal static class ResourceExtensions
    {
        private static ResourceLoader _resLoader = new ResourceLoader();

        public static string GetLocalized(this string resourceKey)
        {
            return _resLoader.GetString(resourceKey);
        }
    }
}
