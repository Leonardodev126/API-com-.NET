using Microsoft.AspNetCore.Mvc;
using ProductClientHub.Communication.Requests;
using ProductClientHub.Communication.Responses;

namespace ProductClientHub.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ClientsController : ControllerBase

    // Endpoints Post, Update, Get, Delete
{
     [HttpPost] // Registrar um cliente
     [ProducesResponseType(typeof(ResponseClientJson), StatusCodes.Status201Created)] // Resposta do swagger, que  no caso é a classe ResponseCLientJson e o tipo dela 201 Created.
     public IActionResult Register([FromBody] RequestClientJson request)
     {
        return Created();
     }

     [HttpPut] // Atualizar um cliente
     public IActionResult Update()
     {
        return Ok();
     }

     [HttpGet]
     public IActionResult GetAll()
     {
        return Ok();
     }

     [HttpGet] // Endpoint para receber apenas um cliente pelo ID
     [Route("{id}")] // A rota já vem com a obrigação de passar o ID nela
     public IActionResult GetById([FromRoute] Guid id)
      {
         return Ok();
      }

     [HttpDelete]
     public IActionResult Delete()
     {
       return Ok();
     }
}
