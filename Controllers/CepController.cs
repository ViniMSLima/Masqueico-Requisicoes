using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Nova_pasta.Controllers;

[ApiController]
[Route("cep")]
public class CepController : ControllerBase
{
    [HttpGet("{cep}")]
    async public Task<ActionResult> Toma(string cep)
    {
        HttpClient client = new();

        var response = "";

        string url = "https://viacep.com.br/ws/" + cep + "/json/";
        HttpResponseMessage result = await client.GetAsync(url);

        if (result.IsSuccessStatusCode)
        {
            response = await result.Content.ReadAsStringAsync();
            return Ok(response);
        }  

        return BadRequest("denis");      
    }

}
