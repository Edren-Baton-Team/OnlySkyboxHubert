using Exiled.API.Interfaces;
using System.ComponentModel;

namespace OnlySkyboxHubert
{
    public class Config : IConfig
    {
        [Description("Plugin Enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Enable developer mode? (AudioPlayer debug)")]
        public bool Debug { get; set; } = false;
    }
}
