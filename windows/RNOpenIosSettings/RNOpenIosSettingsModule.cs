using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Open.Ios.Settings.RNOpenIosSettings
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNOpenIosSettingsModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNOpenIosSettingsModule"/>.
        /// </summary>
        internal RNOpenIosSettingsModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNOpenIosSettings";
            }
        }
    }
}
