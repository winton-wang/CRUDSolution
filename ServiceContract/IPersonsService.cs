using System;
using ServiceContract.DTO;
using ServiceContract.Enums;

namespace ServiceContract
{
    public interface IPersonsService
    {
        PersonResponse  AddPerson(PersonAddRequest? request);

        List<PersonResponse> GetAllPersons();

       PersonResponse? GetPersonByPersonID(Guid? personID);

       List<PersonResponse> GetFilteredPersons(string searchBy, string? searchString);

        List<PersonResponse> GetSortedPersons(List<PersonResponse> allPersons, string sortBy, SortOrderOptions sortOrder);

    }

}
