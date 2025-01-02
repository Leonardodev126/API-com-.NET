using Microsoft.AspNetCore.Mvc;
using ProductClientHub.API.UseCases.Clients.Register;
using ProductClientHub.Communication.Requests;
using ProductClientHub.Communication.Responses;

namespace ProductClientHub.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ClientsController : ControllerBase

    // Endpoints Post, Update, Get, Delete
{
     [HttpPost] // Registrar um cliente
     // Para a documentação do meu swagger
     [ProducesResponseType(typeof(ResponseClientJson), StatusCodes.Status201Created)] // Resposta do swagger, que  no caso é a classe ResponseCLientJson e o tipo dela 201 Created.
     [ProducesResponseType(typeof(ResponseErrorMessageJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestClientJson request)
     {

        try
        {
            var useCase = new RegisterClientUSeCase();

            var response = useCase.Execute(request);

            return Created(string.Empty, response);

        }

        catch (ArgumentException ex)
        {
            return BadRequest(new ResponseErrorMessageJson(ex.Message)); // Chamando meu construtor da classe ResponseErrorMessageJson, que é a responsável por apresentar uma lista de erros
        }

        catch
        {
            return StatusCode(StatusCodes.Status500InternalServerError, new ResponseErrorMessageJson("Erro desconhecido"));
        }


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
