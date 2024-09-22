using Microsoft.AspNetCore.Mvc;
using Services_lr3.Models;

namespace Services_lr3.Controllers;

public class CalcController : Controller {
  private readonly CalcService _calcService;

  public CalcController(CalcService calcService) { _calcService = calcService; }
  [HttpGet("Calc/Add")]
  public IActionResult Add(int a, int b) {return Ok(_calcService.add(a,b)) ; }
}
