using Serilog.Core;
using Serilog.Events;
using Serilog.Formatting;
using System;
using System.Collections.Generic;
using System.Text;

namespace $safeprojectname$.Infrastructure.Logger
{
    public class CustomLogSink : ILogEventSink
    {
        readonly ITextFormatter _textFormatter;

        public CustomLogSink(ITextFormatter textFormatter)
        {
            _textFormatter = textFormatter ?? throw new ArgumentNullException(nameof(textFormatter));
        }

        public void Emit(LogEvent logEvent)
        {
            // Emit your log to your desired destination. Eg HockeyApp, AppCenter
            throw new NotImplementedException();
        }
    }
}
