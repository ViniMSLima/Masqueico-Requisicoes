using Microsoft.AspNetCore.Mvc;
using System;

namespace Nova_pasta.Controllers;

[ApiController]
[Route("test")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet("masqueiko")]

    public ActionResult TestObj()
    {
        // Masqueiko masqueiko = new();
        // masqueiko.TaiLi = "MASQUEIKOOOOOOOOOOOO, TAILIIIIIIIIIIII MASQUEIKOOOOOOOOO";
        // masqueiko.Tacaca = DateTime.Now;

        // return masqueiko;

        return Ok(new {
            Nome= "macaco",
            HoraOficial = DateTime.Now
        });
    }

    [HttpGet]
    public ActionResult TestSum2(string a = "0", string b = "0", string c = "0", string d = "0", string e = "0")
    {
        var data = new string[] {a, b, c, d, e};
        int soma = 0;
        foreach (var item in data)
        {
            if(int.TryParse(item, out var i))
                soma += i;
        }
        return Ok(soma);
    }

    [HttpGet("{x}/{y}")]
    public ActionResult TestSum(string x, string y = "0")
    {
        var isNum1 = int.TryParse(x, out var n1);
        var isNum2 = int.TryParse(y, out var n2);

        if(!isNum1 && !isNum2)
            return BadRequest("EU VOU TOMAR UM TACACA!");
        if(!isNum1)
            return BadRequest("O primeiro é tchola!");
        if(!isNum2)
            return BadRequest("O segundo é tchola!");


        return Ok(x + y);
    }

    // [HttpGet]
    // public string Test()
    // {
    //     return "API is running!";
    // }

    [HttpPost]
    public string Test2()
    {
        return "API POST is running!";
    }
}

public class Masqueiko
{
    public string TaiLi { get; set;}
    public DateTime Tacaca { get; set;}
}