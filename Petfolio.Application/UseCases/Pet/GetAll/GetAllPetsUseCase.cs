using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetAll
{
    public class GetAllPetsUseCase
    {
        public ResponseAllPetJson Execute()
        {
            return new ResponseAllPetJson
            {
                Pets = new List<ResponseShortPetJson>
                {
                    new ResponseShortPetJson
                    {
                        Id = 1,
                        Name = "Rex",
                        Type = Communication.Enums.PetType.Dog
                    },
                    new ResponseShortPetJson
                    {
                        Id = 2,
                        Name = "Mimi",
                        Type = Communication.Enums.PetType.Cat
                    },
                    new ResponseShortPetJson
                    {
                        Id = 3,
                        Name = "Tweety",
                        Type = Communication.Enums.PetType.Dog
                    }
                },
            };
        }
    }
}