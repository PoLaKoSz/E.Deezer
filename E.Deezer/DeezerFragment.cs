﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RestSharp.Deserializers;

namespace E.Deezer
{
    //Grabs an error, if there was one, from the reply
    internal class Error
    {
        public string Message { get; set; }
        public uint Code { get; set; }
        public string Type { get; set; }
    }

    
    //Retrun value of all Deezer API calls
    internal class DeezerFragmentV2<T>
    {
        [DeserializeAs(Name="data")]
        public List<T> Items { get; set; }

        public uint Total { get; set; }
        public Error Error { get; set; }
    }

    internal class DeezerObject<T>
    {
        public T Data { get; set; }
        public Error Error { get; set; }
    }

    internal class DeezerPermissionRequest
    {
        public E.Deezer.Api.OAuthPermissions Permissions { get; set; }
        public Error Error { get; set; }
    }
}
