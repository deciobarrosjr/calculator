/********************************************************************************
A controller is responsible for controlling the way that a user interacts with an
MVC application. A controller contains the flow control logic for an ASP.NET MVC 
application. A controller determines what response to send back to a user when a 
user makes a browser request.

Note the controller bellow has two methods:


********************************************************************************/
using Microsoft.AspNetCore.Mvc;

namespace sum.Controllers;

[ApiController]
[Route("[controller]")]
public class sumController : ControllerBase
{
  [HttpGet(Name = "sum")]
  public double sum(double x, double y)
  {
    return x + y;
  }    
}