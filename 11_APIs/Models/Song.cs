using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_APIs.Models
{
    public class Song
    {
        [JsonProperty("wrapperType")]
        public string WrapperType { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("artistId")]
        public int ArtistId { get; set; }

        [JsonProperty("collectionId")]
        public int CollectionId { get; set; }

        [JsonProperty("trackId")]
        public int TrackId { get; set; }

        [JsonProperty("artistName")]
        public string ArtistName { get; set; }

        [JsonProperty("collectionName")]
        public string CollectionName { get; set; }

        [JsonProperty("trackName")]
        public string TrackName { get; set; }

        [JsonProperty("collectionCensoredName")]
        public string CollectionCensoredName { get; set; }

        [JsonProperty("trackCensoredName")]
        public string TrackCensoredName { get; set; }

        [JsonProperty("artistViewUrl")]
        public string ArtistViewUrl { get; set; }

        [JsonProperty("collectionViewUrl")]
        public string CollectionViewUrl { get; set; }

        [JsonProperty("trackViewUrl")]
        public string TrackViewUrl { get; set; }

        [JsonProperty("previewUrl")]
        public string PreviewUrl { get; set; }

        [JsonProperty("artworkUrl30")]
        public string ArtworkUrl30 { get; set; }

        [JsonProperty("artworkUrl60")]
        public string ArtworkUrl60 { get; set; }

        [JsonProperty("artworkUrl100")]
        public string ArtworkUrl100 { get; set; }

        [JsonProperty("collectionPrice")]
        public double CollectionPrice { get; set; }

        [JsonProperty("trackPrice")]
        public double TrackPrice { get; set; }

        [JsonProperty("releaseDate")]
        public DateTime ReleaseDate { get; set; }

        [JsonProperty("collectionExplicitness")]
        public string CollectionExplicitness { get; set; }

        [JsonProperty("trackExplicitness")]
        public string TrackExplicitness { get; set; }

        [JsonProperty("discCount")]
        public int DiscCount { get; set; }

        [JsonProperty("discNumber")]
        public int DiscNumber { get; set; }

        [JsonProperty("trackCount")]
        public int TrackCount { get; set; }

        [JsonProperty("trackNumber")]
        public int TrackNumber { get; set; }

        [JsonProperty("trackTimeMillis")]
        public int TrackTimeMillis { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("primaryGenreName")]
        public string PrimaryGenreName { get; set; }

        [JsonProperty("contentAdvisoryRating")]
        public string ContentAdvisoryRating { get; set; }

        [JsonProperty("isStreamable")]
        public bool IsStreamable { get; set; }
    }
}
