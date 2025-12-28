using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.Register
{
    /// <summary>
    /// Caso de Uso responsável por encapsular a regra de negócio de cadastro de um pet.
    /// </summary>
    public class RegisterPetUseCase
    {
        /// <summary>
        /// Executa a lógica de cadastro.
        /// Recebe os dados da requisição, processa (futuramente salvará no banco) e retorna a resposta.
        /// </summary>
        /// <param name="request">Objeto contendo os dados enviados pelo usuário (Json).</param>
        /// <returns>Retorna um objeto de resposta contendo o ID gerado e os dados do pet.</returns>
        public ResponseRegisterPetJson Execute(RequestPetJson request)
        {
            return new ResponseRegisterPetJson
            {
                Id = 1,
                Name = request.Name
            };
        }
    }
}
