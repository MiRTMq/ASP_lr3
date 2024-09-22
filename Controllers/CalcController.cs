using Microsoft.AspNetCore.Mvc;
using Services_lr3.Models;

namespace Services_lr3.Controllers;

public class CalcController : Controller {
  private readonly CalcService _calcService;

  public CalcController(CalcService calcService) { _calcService = calcService; }
  [HttpGet]
  public IActionResult Index(){
return View(new CalcModel());
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
