namespace AiDemo.Pages;

using System.Text;
using System.Text.Json;
using AiDemo.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.AspNetCore.Mvc;

public class IndexModel : PageModel
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IConfiguration _configuration;

    [BindProperty]  // prevent submitting empty form value when handler runs
    public string Prompt { get; set; } = string.Empty;

    public string GeneratedImageUrl { get; set; } = "https://placehold.co/800x500?text=Image+Preview";

    public IndexModel(IHttpClientFactory httpClientFactory, IConfiguration configuration)
    {
        _httpClientFactory = httpClientFactory;
        _configuration = configuration;
    }

    public async Task OnPostGenerateImage()
    {
        var endpoint = _configuration["Foundry:Endpoint"];
        var apiKey = _configuration["Foundry:ApiKey"];
        var model = _configuration["Foundry:ImageModel"];

        if (string.IsNullOrWhiteSpace(endpoint) || string.IsNullOrWhiteSpace(apiKey) || string.IsNullOrWhiteSpace(model))
        {
            GeneratedImageUrl = "https://placehold.co/800x500?text=Missing+secrets";
            return;
        }

        var client = _httpClientFactory.CreateClient();
        client.DefaultRequestHeaders.Add("api-key", apiKey);

        var request = new ImageGenerationRequest
        {
            Prompt = Prompt,
            Width = 1024,
            Height = 768,
            Model = model
        };

        var json = JsonSerializer.Serialize(request);
        using var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await client.PostAsync(
            $"{endpoint.TrimEnd('/')}/mai/v1/images/generations",
            content);

        if (response.IsSuccessStatusCode)
        {
            var body = await response.Content.ReadAsStringAsync();

            using JsonDocument jsond = JsonDocument.Parse(body);
            string? base64Image = jsond.RootElement
                .GetProperty("data")[0]
                .GetProperty("b64_json")
                .GetString();

            if (!string.IsNullOrWhiteSpace(base64Image))
            {
                byte[] imageBytes = Convert.FromBase64String(base64Image);
                GeneratedImageUrl = $"data:image/png;base64,{Convert.ToBase64String(imageBytes)}";
            }
            else
            {
                GeneratedImageUrl = "https://placehold.co/800x500?text=Image+Result+Missing";
            }
        }
        else
        {
            GeneratedImageUrl = "https://placehold.co/800x500?text=Image+Request+Failed";
        }
    }
    
    [BindProperty]
    public string TextPrompt { get; set; } = string.Empty;

    public string TextAnswer { get; set; } = string.Empty;

    public async Task OnPostGenerateText()
    {
        var endpoint = _configuration["Foundry:Endpoint"];
        var apiKey = _configuration["Foundry:ApiKey"];
        var model = _configuration["Foundry:TextModel"];

        if (string.IsNullOrWhiteSpace(endpoint) || string.IsNullOrWhiteSpace(apiKey) || string.IsNullOrWhiteSpace(model))
        {
            TextAnswer = "Missing GPT-5 secret configuration.";
            return;
        }

        var client = _httpClientFactory.CreateClient();
        client.DefaultRequestHeaders.Add("api-key", apiKey);

        var request = new TextGenerationRequest
        {
            Prompt = TextPrompt,
            MaxTokens = 250,
            Temperature = 0.4
        };

        var json = JsonSerializer.Serialize(request);
        using var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await client.PostAsync(
            $"{endpoint.TrimEnd('/')}/models/{model}/chat/completions?api-version=2024-05-01-preview",
            content);

        if (response.IsSuccessStatusCode)
        {
            var result = await response.Content.ReadFromJsonAsync<TextGenerationResponse>();
            TextAnswer = result?.Answer ?? "No answer was returned.";
        }
        else
        {
            TextAnswer = "The GPT-5 request failed.";
        }
    }
}
