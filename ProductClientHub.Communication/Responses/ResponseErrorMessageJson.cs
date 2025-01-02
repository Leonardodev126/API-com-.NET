namespace ProductClientHub.Communication.Responses;

public class ResponseErrorMessageJson
{
    // Classe responsável por devolver uma lista de erros
    public List<string> Errors { get; private set; } // Somente essa classe pode alterar o valor da lista com o set privado.

    // Construtor - Ele obriga a passar dados todas as vezes que fizer uma instância da classe ResponseErrorMessageJson
    public ResponseErrorMessageJson(string message)
    {
        Errors = [message]; // Inicializando a minha lista Errors, passando como parâmetro a minha mensagem.
    }
}
