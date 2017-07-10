using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Com.Reactlibrary.RNReactNativePolyChat
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativePolyChatModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativePolyChatModule"/>.
        /// </summary>
        internal RNReactNativePolyChatModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativePolyChat";
            }
        }
    }
}
