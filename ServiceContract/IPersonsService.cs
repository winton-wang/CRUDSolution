using System;
using ServiceContract.DTO;

namespace ServiceContract
{
    public interface IPersonsService
    {
        PersonResponse  AddPerson(PersonAddRequest? request);

        List<PersonResponse> GetAllPersons();
    }

}
