using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetById;

public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = id,
            Name = "Mocked Pet",
            Type = Communication.Enums.PetType.Dog,
            Birthday = new DateTime(year: 2020, month: 01, day: 01)
        };
    }
}
