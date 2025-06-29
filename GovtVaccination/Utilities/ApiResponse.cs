namespace GovtVaccination.Utilities;

public class ApiResponse
{
    public int status { get; set; }
    public string status_title { get; set; }
    public string message { get; set; } 
    public string[] errors { get; set; }
    public object? data { get; set; }
}