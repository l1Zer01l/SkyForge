using System;

namespace SkyForge.Logs
{
    public class LogLevel
    {
        private string name;
        private sbyte level;

        public static LogLevel None = new LogLevel("None", 0);
        public static LogLevel Massage = new LogLevel("Massage", 1);
        public static LogLevel Info = new LogLevel("Info", 2);
        public static LogLevel Warn = new LogLevel("Warn", 3);
        public static LogLevel Error = new LogLevel("Error", 4);
        public static LogLevel Critical = new LogLevel("Critical", 5);
        public static LogLevel Off = new LogLevel("Off", 6);

        public static LogLevel MaxLevel => Critical;
        public static LogLevel MinLevel => Massage;

        private LogLevel(string name, sbyte level)
        {
            this.name = name;
            this.level = level;
        }

        public int CompareTo(LogLevel other)
        {
            return level - (other ?? Off).level;
        }

        public static bool operator ==(LogLevel level1, LogLevel level2)
        {
            if (ReferenceEquals(level1, level2))
                return true;
            else
                return (level1 ?? Off).Equals(level2);
        }

        public static bool operator !=(LogLevel level1, LogLevel level2)
        {
            if (ReferenceEquals(level1, level2))
                return false;
            else
                return !(level1 ?? Off).Equals(level2);
        }

        public static bool operator >(LogLevel level1, LogLevel level2)
        {
            if (ReferenceEquals(level1, level2))
                return false;
            else
                return (level1 ?? Off).CompareTo(level2) < 0;
        }

        public static bool operator <(LogLevel level1, LogLevel level2)
        {
            if (ReferenceEquals(level1, level2))
                return false;
            else
                return (level1 ?? Off).CompareTo(level2) < 0;
        }

        public static bool operator <=(LogLevel level1, LogLevel level2)
        {
            if (ReferenceEquals(level1, level2))
                return true;
            else
                return (level1 ?? Off).CompareTo(level2) <= 0;
        }

        public static bool operator >=(LogLevel level1, LogLevel level2)
        {
            if (ReferenceEquals(level1, level2))
                return true;
            else
                return (level1 ?? Off).CompareTo(level2) >= 0;
        }

        public static LogLevel FromLevel(sbyte level)
        {
            switch (level)
            {
                case 0:
                    return None;
                case 1:
                    return Massage;
                case 2:
                    return Info;
                case 3:
                    return Warn;
                case 4:
                    return Error;
                case 5:
                    return Critical;
                case 6:
                    return Off;
                default:
                    throw new ArgumentException($"Unknown log level: {level}. ", nameof(level));
            }
        }

        public static LogLevel FromName(string name)
        {
            if (name == null)
                return None;

            if (name.Equals(Massage.name, StringComparison.OrdinalIgnoreCase))
                return Massage;
            if (name.Equals(Info.name, StringComparison.OrdinalIgnoreCase))
                return Info;
            if (name.Equals(Warn.name, StringComparison.OrdinalIgnoreCase))
                return Warn;
            if (name.Equals(Error.name, StringComparison.OrdinalIgnoreCase))
                return Error;
            if (name.Equals(Critical.name, StringComparison.OrdinalIgnoreCase))
                return Critical;
            if (name.Equals(Off.name, StringComparison.OrdinalIgnoreCase))
                return Off;
            throw new ArgumentException($"Unknown log level: {name} ", nameof(name));
        }

        public override string ToString()
        {
            return name;
        }

        public override int GetHashCode()
        {
            return level;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as LogLevel);
        }

        public bool Equals(LogLevel other)
        {
            return level == other?.level;
        }

    }

}