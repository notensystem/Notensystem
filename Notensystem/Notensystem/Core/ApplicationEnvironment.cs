using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Notensystem.Core
{
    public static class ApplicationEnvironment
    {
        public static event EventHandler<EventArgs> LanguageChanged;

        public static string UserName { get { return System.Environment.UserName.ToLower(); } }
        public static string CurrentCulture { get { return cultureInfo.Name; } }

        private const string ResourceFileName = "Notensystem.Resources.Strings";
        private static ResourceManager resourceManager;
        private static CultureInfo cultureInfo;

        static ApplicationEnvironment() 
        {
            resourceManager = new ResourceManager(ResourceFileName, Assembly.GetExecutingAssembly());
            cultureInfo = Thread.CurrentThread.CurrentUICulture;
        }

        public static string GetString(string stringName)
        {
            return resourceManager.GetString(stringName, cultureInfo);
        }

        public static void SetCulture(string culture)
        {
            cultureInfo = new CultureInfo(culture);
            OnLanguageChanged();
        }

        public static List<CultureInfo> GetSupportedCultures()
        {
            List<CultureInfo> cultures = new List<CultureInfo>();
            cultures.Add(new CultureInfo("de-DE"));
            cultures.Add(new CultureInfo("en-US"));
            return cultures;
        }

        private static void OnLanguageChanged()
        {
            if (LanguageChanged != null)
            {
                LanguageChanged(null, null);
            }
        }
    }
}
