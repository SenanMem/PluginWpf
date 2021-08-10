using IPlugin;
using System;

namespace Plugin_One
{
    public class PluginOne : IPlugin.IPlugin
    {
        public string Name { get; set; } = "FirstPlogen";
        public string Creator { get; set; } = "Senan";
        public string Version { get; set; } = "1.1.0";
        public DateTime GetDateTime { get; set; } = DateTime.Now;

        public void Action()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Creator : {Creator}");
            Console.WriteLine($"Version : {Version}");
            Console.WriteLine($"Date Time : {GetDateTime}");

        }
    }
}
