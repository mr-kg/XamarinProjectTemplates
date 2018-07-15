using Serilog;
using Serilog.Configuration;
using Serilog.Events;
using Serilog.Formatting.Display;
using System;
using System.Collections.Generic;
using System.Text;

namespace $safeprojectname$.Infrastructure.Logger
{
    public static class LoggerConfig
    {
        const string DefaultLogOutputTemplate = "{Timestamp:G} [{Level}] {Message}{NewLine:l}{Exception:l}";

        /// <summary>
        /// Adds a sink that writes log events to HockeyApp events
        /// </summary>
        /// <param name="sinkConfiguration">The configuration being modified.</param>
        /// <param name="restrictedToMinimumLevel">The minimum log event level required in order to write an event to the sink.</param>
        /// <param name="outputTemplate">Template for the output events</param>
        /// <param name="formatProvider">Supplies culture-specific formatting information, or null.</param>
        /// <exception cref="ArgumentNullException">A required parameter is null.</exception>
        public static LoggerConfiguration HockeyApp(this LoggerSinkConfiguration sinkConfiguration,
            LogEventLevel restrictedToMinimumLevel = LevelAlias.Minimum,
            string outputTemplate = DefaultLogOutputTemplate,
            IFormatProvider formatProvider = null)
        {

            if (sinkConfiguration == null)
                throw new ArgumentNullException(nameof(sinkConfiguration));

            if (outputTemplate == null)
                throw new ArgumentNullException(nameof(outputTemplate));

            var formatter = new MessageTemplateTextFormatter(outputTemplate, formatProvider);
            return sinkConfiguration.Sink(new CustomLogSink(formatter), restrictedToMinimumLevel);
        }
    }
}
