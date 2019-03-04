using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Perfect.Components.RNPerfectComponents
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNPerfectComponentsModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNPerfectComponentsModule"/>.
        /// </summary>
        internal RNPerfectComponentsModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNPerfectComponents";
            }
        }
    }
}
