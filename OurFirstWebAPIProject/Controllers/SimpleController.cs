//**1) using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc;

namespace OurFirstWebAPIProject.Controllers
    //**4) [Route("api/hello-world)]
        //[ApiController]
{
    public class SimpleController //**2) : ControllerBase {
    

    
    //**10)private static List<string> names = new List<string>();


    //*p51 mauallly add a controller
    //6) [HttpGet("a")]
    //**3) public string HelloWorld() { return "Hello World!";  }

    //7) [HttpGet("b")]
    //5) public string HelloWorld2() { return "abc";  }


    //9 [HttpGet("say-hello/{message}")]
    //8 public string SayHello(string message) { return $"Hello {message}";  }


    //11) [HttpGet("add-name/{name}")]
    //    public string AddName(string name)
    //{ names.Add(name);
    //    return $"{name} added";
    //}

    //12) [HttpGet("names")]
    //public string GetNames()
    //{
    //    string namesStr = string.Join("|", names);
    //    return namesStr;
    //}

    //} (END OF CONTROLLER BASE)
}
