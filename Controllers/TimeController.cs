
using Microsoft.AspNetCore.Mvc;

namespace Services_lr3.Controllers;

public class TimeController : Controller {
  private readonly TimeService _timeService;

  public TimeController(TimeService timeService) { _timeService = timeService; }
  [HttpGet]
  public IActionResult Index(){
    return Ok(_timeService.GetTimeOfDay());
  }

  [HttpPost]

  public IActionResult Index(CalcModel calc, string command) {
    switch (command) {
    case "add":
      calc.Result = calc.NumberA + calc.NumberB;
      break;
    case "sub":
      calc.Result = calc.NumberA - calc.NumberB;
      break;
    case "mul":
      calc.Result = calc.NumberA * calc.NumberB;
      break;
    case "div":
      calc.Result = calc.NumberA / calc.NumberB;
      break;
    }
    return View(calc);
  }
}
