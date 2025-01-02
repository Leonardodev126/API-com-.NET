using ProductClientHub.Communication.Requests;
using ProductClientHub.Communication.Responses;

namespace ProductClientHub.API.UseCases.Clients.Register;

public class RegisterClientUSeCase
    //Aqui é onde estará toda a regra de negócio para registrar um cliente
{
    public ResponseClientJson Execute(RequestClientJson request)
    {

        var validator = new RegisterClientValidator();

        var result = validator.Validate(request);

        if(result.IsValid == false)
        {
            throw new ArgumentException("Erro nos dados recebidos");
        }

        return new ResponseClientJson();
    }
}
