using System.Net;

namespace AppCore.Infrastructure;

public class BaseResult
{
	public bool Success { get; set; }
	public string? Message { get; set; }
	public HttpStatusCode? StatusCode { get; set; }
}
