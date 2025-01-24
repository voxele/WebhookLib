Example of use:
```csharp
Webhook myWebhook = new Webhook("Webhook URL here");

public void SendWebhook(string message)
{
    var webhookContent = new WebhookContent
    {
        Content = message,
    };

    Task.Run(() => myWebhook.PostAsync(webhookContent));
}
```
