﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace XBMCRemoteRT.Models.Common
{
    public class Sort
    {
        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }

        [JsonProperty(PropertyName = "order")]
        public string Order { get; set; }

        [JsonProperty(PropertyName = "ignorearticle")]
        public bool IgnoreArticle { get; set; }
    }
}
