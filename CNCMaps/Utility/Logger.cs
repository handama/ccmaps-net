﻿using System;
using System.Diagnostics;
using System.Drawing;

namespace CNCMaps.Utility {

	public enum LogLevel : int {
		Debug = 3,
		Info = 2,
		Warn = 1,
		Error = 0
	}

	public static class Logger {
		static Stopwatch sw;
		public static LogLevel LogLevel { get; set; }

		static ConsoleColor ErrorColor = ConsoleColor.Red;
		static ConsoleColor WarnColor = ConsoleColor.Magenta;
		static ConsoleColor InfoColor = ConsoleColor.White;
		static ConsoleColor DebugColor = ConsoleColor.DarkBlue;

		static Logger() {
			sw = new Stopwatch();
			sw.Start();
		}

		public static void Error(string format, params object[] args) {
			if (LogLevel >= LogLevel.Error) {
				Console.ForegroundColor = ErrorColor;
				Console.Write("{0000} - [ERROR] ", sw.ElapsedMilliseconds);
				Console.WriteLine(string.Format(format, args));
			}
		}
		public static void Debug(string format, params object[] args) {
			if (LogLevel >= LogLevel.Debug) {
				Console.ForegroundColor = DebugColor;
				Console.Write("{0000} - [DEBUG] ", sw.ElapsedMilliseconds);
				Console.WriteLine(string.Format(format, args));
			}
		}
		public static void Info(string format, params object[] args) {
			if (LogLevel >= LogLevel.Info) {
				Console.ForegroundColor = InfoColor;
				Console.Write("{0000} - [INFO] ", sw.ElapsedMilliseconds);
				Console.WriteLine(string.Format(format, args));
			}
		}
		public static void Warn(string format, params object[] args) {
			if (LogLevel >= LogLevel.Warn) {
				Console.ForegroundColor = WarnColor;
				Console.Write("{0000} - [WARN] ", sw.ElapsedMilliseconds);
				Console.WriteLine(string.Format(format, args));
			}
		}

	}
}
