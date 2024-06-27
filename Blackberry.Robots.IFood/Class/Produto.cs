using Newtonsoft.Json;
using System;

namespace Blackberry.Robots.IFood.Class
{
    public class Produto
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("taxonomyName")]
        public string TaxonomyName { get; set; }

        [JsonProperty("needChoices")]
        public bool NeedChoices { get; set; }

        [JsonProperty("choices")]
        public string[] Choices { get; set; }

        [JsonProperty("unitPrice")]
        public double UnitPrice { get; set; }

        [JsonProperty("unitMinPrice")]
        public double UnitMinPrice { get; set; }

        [JsonProperty("order")]
        public long Order { get; set; }

        [JsonProperty("availability")]
        public string Availability { get; set; }

        [JsonProperty("openingHours")]
        public string[] OpeningHours { get; set; }

        [JsonProperty("discoveryTags")]
        public string[] DiscoveryTags { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("operationModes")]
        public string[] OperationModes { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }
}
