using System;
using System.Collections.Generic;
using System.Text;

namespace MobileBlazorAdvanced
{
    public interface IAdvancedMessage
    {
        void ShowMessageAndCatchAction(string Message, Action<string> ToClick);
    }
}
