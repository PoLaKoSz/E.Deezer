﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E.Deezer.Endpoint
{
    public interface IAlbumEndpoint
    {

    }

    internal class AlbumEndpoint : IAlbumEndpoint
    {
        private DeezerClient iClient;


        public AlbumEndpoint(DeezerClient aClient) {  iClient = aClient;  }
    }
}
