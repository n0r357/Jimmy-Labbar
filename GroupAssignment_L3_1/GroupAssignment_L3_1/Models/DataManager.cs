using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment_L3_1.Models
{
    public class DataManager
    {
        static List<Person> people = new List<Person>()
        {
            new Person { Id = 1, Name = "Jimmy", Email = "jimmy.waern@hotmail.com" },
            new Person { Id = 2, Name = "Damien", Email = "mrdamiengallagher@gmail.com" },
            new Person { Id = 3, Name = "Tommy", Email = "tommy.forsberg@hotmail.com" },
            new Person { Id = 4, Name = "Test", Email = "test@acme.com" }
        };
        /*
        internal static void AddPerson(Person person)
        {
            person.Id = people.Max(o => o.Id) + 1;
            people.Add(person);
        }
        */
        internal static void AddPerson(PeopleCreateVM viewModel)
        {
            Person person = new Person()
            { Id = people.Max(o => o.Id) + 1, Name = viewModel.Name, Email = viewModel.Email };
            people.Add(person);
        }
        internal static PeopleCreateVM GetPerson(int id)
        {
            var person = people.SingleOrDefault(p => p.Id == id);
            PeopleCreateVM viewModel = new PeopleCreateVM()
            {
                Id = person.Id,
                Name = person.Name,
                Email = person.Email,
                AcceptTerms = true
            };
            
            return viewModel;
        }
        /*
        internal static Person[] GetAllPeople()
        {
            return people.ToArray();
        }
        */
        internal static void EditPerson(PeopleCreateVM viewModel)
        {
            var tempId = viewModel.Id;
            people.RemoveAt(tempId - 1);
            Person person = new Person()
            { Id = tempId, Name = viewModel.Name, Email = viewModel.Email };
            people.Insert(tempId - 1, person);
        }
        internal static PeopleIndexVM[] ListPeople()
        {
            return people.Select(o => new PeopleIndexVM
            {
                Id = o.Id,
                Name = o.Name,
                Email = o.Email,
                ShowAsHighlighted = o.Email.EndsWith("acme.com", StringComparison.OrdinalIgnoreCase)
            }).ToArray();
        }
    }
}
