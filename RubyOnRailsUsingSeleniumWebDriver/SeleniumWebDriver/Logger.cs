﻿using System.Diagnostics;

namespace RubyOnRailsUsingSeleniumWebDriver.SeleniumWebDriver
{
    public class Logger
    {
        #region constructors
        public Logger()
        {
        }

        #endregion

        #region public methods

        public static void Comment(LogType logtype, string message)
        {
            switch (logtype)
            {
                case LogType.Error:
                    Trace.TraceError(message);
                    break;
                case LogType.Information:
                    Trace.TraceInformation(message);
                    break;
                case LogType.Warning:
                    Trace.TraceWarning(message);
                    break;
                default:
                    Trace.TraceInformation(message);
                    break;
            }
        }

        #endregion
    }

}
