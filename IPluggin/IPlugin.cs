using System;

namespace IPlugin
{
    public interface IPlugin
    {
        string Creator { get; set; }
        string Name { get; set; }
        DateTime GetDateTime { get; set; }
        void Action();
    }
}
