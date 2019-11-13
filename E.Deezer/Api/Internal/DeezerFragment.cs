﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace E.Deezer.Api
{
    //Retrun value of all Deezer API calls
    internal class DeezerFragment<T> : IHasError
    {
        [JsonProperty(PropertyName="data")]
        internal List<T> Items { get; set; }

        internal uint Total { get; set; }

        //IHasError
        internal Error Error { get; set; }

        public IError TheError => Error;
    }

    //ChartFragment is used to get all 4 charts at once
    internal class DeezerChartFragment : IHasError
    {
        internal DeezerFragment<Track> Tracks { get; set; }

        internal DeezerFragment<Album> Albums { get; set; }

        internal DeezerFragment<Artist> Artists { get; set; }

        internal DeezerFragment<Playlist> Playlists { get; set; }

        //IHasError
        internal Error Error { get; set; }

        public IError TheError => Error;
    }
}
