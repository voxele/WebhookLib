using System.Text.Json.Serialization;

namespace WebhookLib.Types
{
    public class Embed
    {
        [JsonPropertyName("author")]
        public EmbedAuthor? Author { get; set; }

        [JsonPropertyName("title")]
        public string? Title {  get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("color")]
        public decimal Color { get; set; }

        [JsonPropertyName("fields")]
        public EmbedField[]? Fields { get; set; }

        [JsonPropertyName("footer")]
        public EmbedFooter? Footer { get; set; }
    }
}
