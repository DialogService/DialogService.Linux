using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService.Linux
{
    /// <summary>
    /// Functionality to get Linux platform implementation of dialog service
    /// </summary>
    public class PlatformImplementation : AbstractPlatform
    {
        public override RuntimePlatform Platform => RuntimePlatform.Linux;

        /// <summary>
        /// Gets Linux dialog service implementation
        /// </summary>
        /// <returns></returns>
        public override IDialogService Get() => new Linux.LinuxDialogService();
    }
}
