using System.Net.Http.Headers;
using System.Text.Json;
using WebhookLib.Types;

namespace WebhookLib
{
    public class Webhook
    {
        public Webhook(string webhookUrl)
        {
            WebhookUrl = webhookUrl;

            HttpClient = new HttpClient();
        }

        public HttpClient HttpClient { get; internal set; }

        public string WebhookUrl { get; internal set; }

        public async Task<HttpResponseMessage> PostAsync(WebhookContent webhookContent)
        {
            StringContent stringContent = new StringContent(JsonSerializer.Serialize(webhookContent));
            stringContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return await HttpClient.PostAsync(WebhookUrl, stringContent);
        }
    }
}
