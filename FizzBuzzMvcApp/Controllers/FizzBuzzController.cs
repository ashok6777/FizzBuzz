using FizzBuzzMvcApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.RegularExpressions;

namespace FizzBuzzMvcApp.Controllers;

public class FizzBuzzController : Controller
{
    private readonly IFizzBuzzService _fizzBuzzService;
    private readonly ILogger<FizzBuzzController> _logger;

    public FizzBuzzController(IFizzBuzzService fizzBuzzService, ILogger<FizzBuzzController> logger)
    {
        _fizzBuzzService = fizzBuzzService;
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(string values)
    {
        ViewBag.Values = values;

        if (string.IsNullOrWhiteSpace(values))
        {
            _logger.LogWarning("Empty input received");
            ViewBag.Error = "Input cannot be empty";
            return View();
        }

        var regex = new Regex("^[a-zA-Z0-9,]*$");
        if (!regex.IsMatch(values))
        {
            _logger.LogWarning("Invalid input received: {Values}", values);
            ViewBag.Error = "Invalid input: Only alphanumeric characters and commas are allowed.";
            return View();
        }

        var valueArray = values.Split(',');
        _logger.LogInformation("Processing values: {Values}", values);
        var result = _fizzBuzzService.ProcessArray(valueArray);
        ViewBag.Results = result;

        _logger.LogInformation("Processed results: {Results}", result);
        return View();
    }
}
