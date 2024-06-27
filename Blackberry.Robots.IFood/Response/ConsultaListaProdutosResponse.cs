using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackberry.Robots.IFood.Response
{
    public class ListaProdutos
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("menu")]
        public List<Menu> Menu { get; set; }
    }

    public partial class Iten
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("code")]
        [JsonConverter(typeof(ParseStringConverter))]
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
        public List<object> Choices { get; set; }

        [JsonProperty("unitPrice")]
        public double UnitPrice { get; set; }

        [JsonProperty("unitMinPrice")]
        public double UnitMinPrice { get; set; }

        [JsonProperty("order")]
        public long Order { get; set; }

        [JsonProperty("availability")]
        public Availability Availability { get; set; }

        [JsonProperty("openingHours")]
        public List<object> OpeningHours { get; set; }

        [JsonProperty("discoveryTags")]
        public List<object> DiscoveryTags { get; set; }

        [JsonProperty("tags")]
        public List<object> Tags { get; set; }

        [JsonProperty("operationModes")]
        public List<OperationMode> OperationModes { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("unitOriginalPrice", NullValueHandling = NullValueHandling.Ignore)]
        public double? UnitOriginalPrice { get; set; }
    }
}
