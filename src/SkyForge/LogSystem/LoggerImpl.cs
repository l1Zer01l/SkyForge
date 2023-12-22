using System;
using System.IO;

namespace SkyForge.Logs.Core
{

    public static class LoggerImpl
    {
        private static string pathFileLog;

        private static bool writeToFile = true;
        private static bool tested = false;

        public static bool Tested { get => tested; set => tested = value; }
        public static bool WriteToFile { get => writeToFile; set => writeToFile = value; }
       
        public static void Init()
        {
            if (tested)
            {
                Write("Massage test", LogLevel.Massage);
                Write("Info test", LogLevel.Info);
                Write("Warn test", LogLevel.Warn);
                Write("Error test", LogLevel.Error);
                Write("Critical test", LogLevel.Critical);
                Write("Off test", LogLevel.Off);
            }
        }
        public static void SetLogFile(string filename)
        {
            pathFileLog = filename;
        }

        public static void Write(string massage, LogLevel level)
        {
            WriteToLogFile(massage, level);
        }

        private static void WriteToLogFile(string massage, LogLevel logLevel)
        {
            if (string.IsNullOrEmpty(pathFileLog) || !writeToFile)
                return;
            if(!Directory.Exists(pathFileLog))
                Directory.CreateDirectory(pathFileLog);
            var time = DateTime.Now;
            string path = $@"log-date({time.Day}_{time.Month}_{time.Year}).txt";

#if DEBUG
            if (logLevel >= LogLevel.MinLevel)
            {
                using (var textWriter = File.AppendText(pathFileLog + path))
                {
                    textWriter.WriteLine(Patern(massage, logLevel));
                }
            }
#else
            if (logLevel >= LogLevel.Warn)
            {
                using (var textWriter = File.AppendText(pathFileLog + path))
                {
                    textWriter.WriteLine(Patern(massage, logLevel));
                }
            }
#endif
        }

        private static string Patern(in string msg, LogLevel level)
        {
            var time = DateTime.Now;
            return $"[{time.Hour}:{time.Minute}:{time.Second}] -> ({level.ToString()}){msg}";
        }
    }

}