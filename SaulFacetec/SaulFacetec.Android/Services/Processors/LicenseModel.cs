namespace SaulFacetec.Droid.Services.Processors
{

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Globalization;

    public partial class LicenseModel
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Data Data { get; set; }

        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public Meta Meta { get; set; }

        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Success { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("licenseText", NullValueHandling = NullValueHandling.Ignore)]
        public string LicenseText { get; set; }

        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Success { get; set; }
    }

    public partial class Meta
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public long? Code { get; set; }

        [JsonProperty("ok", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ok { get; set; }
    }

    public partial class LicenseModel
    {
        public static LicenseModel FromJson(string json) => JsonConvert.DeserializeObject<LicenseModel>(json, ConverterLicenseModel.Settings);
    }

    public static class SerializeLicenseModel
    {
        public static string ToJson(this LicenseModel self) => JsonConvert.SerializeObject(self, ConverterLicenseModel.Settings);
    }

    internal static class ConverterLicenseModel
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}