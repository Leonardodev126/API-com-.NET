using FluentValidation;
using ProductClientHub.Communication.Requests;

namespace ProductClientHub.API.UseCases.Clients.Register;

public class RegisterClientValidator : AbstractValidator<RequestClientJson>
{
    // Aqui é a validação da classe RequestClientJson com a livraria FluentValidation
    public RegisterClientValidator() // Construtor
    {
        RuleFor(client => client.Name).NotEmpty().WithMessage("O nome não pode ser vazio.");
        RuleFor(client => client.Email).EmailAddress().WithMessage("O e-mail não é válido.");
    }
}
