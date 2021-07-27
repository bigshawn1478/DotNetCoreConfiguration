using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreConfiguration.SettingModels
{
    public class MySettings
    {
        public int Volume { get; set; }

        public bool IsMute { get; set; }

        public string Display { get; set; }

        public InputMappingOption InputMapping { get; set; }

        public class InputMappingOption
        {
            public string Up { get; set; }

            public string Down { get; set; }

            public string Left { get; set; }

            public string Right { get; set; }
        }
    }
}
