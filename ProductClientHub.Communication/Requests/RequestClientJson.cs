namespace ProductClientHub.Communication.Requests;

public class RequestClientJson

    // Classe que irá receber os dados do cliente, no caso o nome e o email.
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
