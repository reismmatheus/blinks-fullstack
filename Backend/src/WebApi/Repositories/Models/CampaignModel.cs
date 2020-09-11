
using CsvHelper.Configuration.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Repositories.Models
{
    public class CampaignModel
    {
        [JsonProperty(PropertyName = "date")]
        [Name("date")]
        public string Date { get; set; }

        [JsonProperty(PropertyName = "media")]
        [Name("media")]
        public string Media { get; set; }

        [JsonProperty(PropertyName = "client_id")]
        [Name("client_id")]
        public string Client_Id { get; set; }

        [JsonProperty(PropertyName = "client_name")]
        [Name("client_name")]
        public string Client_Name { get; set; }

        [JsonProperty(PropertyName = "campaign_id")]
        [Name("campaign_id")]
        public string Campaign_Id { get; set; }

        [JsonProperty(PropertyName = "campaign_name")]
        [Name("campaign_name")]
        public string Campaign_Name { get; set; }

        [JsonProperty(PropertyName = "clicks")]
        [Name("clicks")]
        public string Clicks { get; set; }

        [JsonProperty(PropertyName = "impressions")]
        [Name("impressions")]
        public string Impressions { get; set; }

        [JsonProperty(PropertyName = "investment")]
        [Name("investment")]
        public string Investment { get; set; }
    }
}
