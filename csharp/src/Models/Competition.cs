// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace PennyDreadfulMagic.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Competition
    {
        /// <summary>
        /// Initializes a new instance of the Competition class.
        /// </summary>
        public Competition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Competition class.
        /// </summary>
        public Competition(int? id = default(int?), string name = default(string), System.DateTime? startDate = default(System.DateTime?), System.DateTime? endDate = default(System.DateTime?), int? topN = default(int?), int? numDecks = default(int?), int? numReviewed = default(int?), string sponsorName = default(string), string seriesName = default(string), string type = default(string), int? seasonId = default(int?), IList<Deck> decks = default(IList<Deck>))
        {
            Id = id;
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            TopN = topN;
            NumDecks = numDecks;
            NumReviewed = numReviewed;
            SponsorName = sponsorName;
            SeriesName = seriesName;
            Type = type;
            SeasonId = seasonId;
            Decks = decks;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "start_date")]
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "end_date")]
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "top_n")]
        public int? TopN { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "num_decks")]
        public int? NumDecks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "num_reviewed")]
        public int? NumReviewed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sponsor_name")]
        public string SponsorName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "series_name")]
        public string SeriesName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "season_id")]
        public int? SeasonId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "decks")]
        public IList<Deck> Decks { get; set; }

    }
}
