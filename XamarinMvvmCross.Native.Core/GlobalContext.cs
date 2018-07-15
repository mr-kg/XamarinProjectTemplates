using MvvmCross.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace $safeprojectname$
{
    /// <summary>
    /// A globally accessible singleton for essentials like logger and settings (persisted
    /// </summary>
    public class GlobalContext
    {
        private static GlobalContext _instance;
        public static GlobalContext Instance => _instance ?? (_instance = new GlobalContext());

        public IMvxLog Logger { get; set; }

        public bool IsFirstLogin
        {
            get
            {
                return bool.Parse(Plugin.Settings.CrossSettings.Current.GetValueOrDefault("IsFirstLogin", "true"));
            }
            set
            {
                Plugin.Settings.CrossSettings.Current.AddOrUpdateValue("IsFirstLogin", value.ToString());
            }
        }
    }
}
