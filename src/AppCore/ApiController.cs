using Microsoft.AspNetCore.Mvc;
using AppCore.Filters;
using AppCore.Infrastructure;

namespace AppCore;

[ApiController]
[Route("api/[controller]")]
[TypeFilter(typeof(ApiExceptionFilter))]
[TypeFilter(typeof(ApiResponseFilter))]
public class ApiController : BaseController;

public class ApiController<TService>(TService service) : ApiController where TService : class
{
	public TService Service { get; } = service;
}