namespace DarkMode_2.Models;

public class VersionControl
{
    public static string Channel()
    {
        string channel = "Release";
        return channel;
    }
    public static string Version()
    {
        string version = "2.1.4";
        return version;
    }
    public static string InternalVersion()
    {
        string internalVersion = "20240918";
        return internalVersion;
    }
}
