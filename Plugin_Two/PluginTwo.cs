using IPlugin;
using System;

namespace Plugin_Two
{
    public class PluginTwo:IPlugin.IPlugin
    {
        public string Name { get; set; } = "SecondPlogen";
        public string Creator { get; set; } = "Kenan";
        public string Version { get; set; } = "2.2.0";
        public DateTime GetDateTime { get; set; } = DateTime.Now.AddHours(1);

        public void Action()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Creator : {Creator}");
            Console.WriteLine($"Version : {Version}");
            Console.WriteLine($"Date Time : {GetDateTime}");
        }
    }
}
