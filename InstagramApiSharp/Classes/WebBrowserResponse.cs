﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace InstagramApiSharp.Classes
{
    internal class WebBrowserResponse
    {
        [JsonProperty("config")]
        public WebBrowserResponseConfig Config { get; set; }
    }

    internal class WebBrowserResponseConfig
    {
        [JsonProperty("csrf_token")]
        public string CsrfToken { get; set; }
        [JsonProperty("viewer")]
        public WebBrowserResponseViewer Viewer { get; set; }
    }

    internal class WebBrowserResponseViewer
    {
        [JsonProperty("biography")]
        public string Biography { get; set; }
        [JsonProperty("external_url")]
        public object ExternalUrl { get; set; }
        [JsonProperty("full_name")]
        public string FullName { get; set; }
        [JsonProperty("has_profile_pic")]
        public bool HasProfilePic { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("profile_pic_url")]
        public string ProfilePicUrl { get; set; }
        [JsonProperty("profile_pic_url_hd")]
        public string ProfilePicUrlHd { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }
    }


}
