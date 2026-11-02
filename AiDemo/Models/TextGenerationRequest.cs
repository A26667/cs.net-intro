namespace AiDemo.Models;

public class TextGenerationRequest
{
    public string Prompt { get; set; } = string.Empty;
    public int MaxTokens { get; set; } = 300;
    public double Temperature { get; set; } = 0.7;
}
