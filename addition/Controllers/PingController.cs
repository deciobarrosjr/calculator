/********************************************************************************
A controller is responsible for controlling the way that a user interacts with an
MVC application. A controller contains the flow control logic for an ASP.NET MVC 
application. A controller determines what response to send back to a user when a 
user makes a browser request.

Note the controller bellow has one method accessed by: http://..../ping


********************************************************************************/
using Microsoft.AspNetCore.Mvc;

namespace ping.Controllers;

[ApiController]
[Route("[controller]")]
public class pingController : ControllerBase
{
  [HttpGet(Name = "ping")]
    public string ping()
    {
      return "Ok";
    }     
}