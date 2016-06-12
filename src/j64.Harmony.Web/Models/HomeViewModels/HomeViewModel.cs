using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace j64.Harmony.Web.ViewModels.Home
{
    public class HomeViewModel
    {
        public string SoundDeviceName { get; set; } = "Sound";
        public string ChannelSurfDeviceName { get; set; } = "Surfing";
        public string VcrPauseDeviceName { get; set; } = "D.V.R.";
        public string LastChannelDeviceName { get; set; } = "Previous Channel";
        public string VolumeDevice { get; set; } = "";
        public string ChannelDevice { get; set; } = "";

        public List<FavoriteChannel> FavoriteChannels = new List<FavoriteChannel>();
    }

    public class FavoriteChannel
    {
        public string Name { get; set; }
        public string Channel { get; set; }
    }
}