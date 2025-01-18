using System.Text.Json.Serialization;

namespace WebhookLib.Types
{
    public class WebhookContent
    {
        [JsonPropertyName("username")]
        public string? Username { get; set; }

        [JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }

        [JsonPropertyName("content")]
        public string? Content { get; set; }

        [JsonPropertyName("embeds")]
        public Embed[]? Embeds { get; set; }
    }
}
