using Microsoft.Extensions.Logging;
using System;
using System.IO;
namespace GeneracionReporteDietas
{
	public class FileLogger : ILogger
	{
		private readonly string filePath;

		public FileLogger(string path)
		{
			filePath = path;
		}

		public IDisposable BeginScope<TState>(TState state) => null;

		public bool IsEnabled(LogLevel logLevel) => true;

		public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
		{
			if (!IsEnabled(logLevel))
			{
				return;
			}

			var message = formatter(state, exception);
			if (string.IsNullOrEmpty(message))
			{
				return;
			}

			message = $"{DateTime.Now:o} [{logLevel}] {message} {exception}";

			try
			{
				File.AppendAllText(filePath, message + Environment.NewLine);
			}
			catch (Exception ex)
			{
			}
		}
	}


}