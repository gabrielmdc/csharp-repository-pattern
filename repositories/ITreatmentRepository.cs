using System.Collections.Generic;
using RepositoryPattern.models;

namespace RepositoryPattern.repositories
{
    interface ITreatmentRepository : IRepository<Treatment>
    {
        // Example
        //IEnumerable<Treatment> GetPersonsBetweenAge(int lowestAge, int highestAge);
    }
}