using System.Collections.Generic;
using PeopleSearch.Data.Entities;

namespace PeopleSearch.Data
{
    public class PeopleSearchDbInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<PeopleSearchContext>
    {
        protected override void Seed(PeopleSearchContext context)
        {
            var people = new List<PersonEntity>()
            {
                new PersonEntity() {FirstName = "Tony", LastName = "Stark"},
                new PersonEntity() {FirstName = "Natasha", LastName = "Romanova"},
                new PersonEntity() {FirstName = "Steven", LastName = "Rogers"},
                new PersonEntity() {FirstName = "Bruce", LastName = "Banner"},
                new PersonEntity() {FirstName = "Carol", LastName = "Danvers"},
                new PersonEntity() {FirstName = "Sam", LastName = "Wilson"},
                new PersonEntity() {FirstName = "Hank", LastName = "Pym"},
                new PersonEntity() {FirstName = "Clinton", LastName = "Barton"},
                new PersonEntity() {FirstName = "Luke", LastName = "Cage"},
                new PersonEntity() {FirstName = "Pietro", LastName = "Maximoff"},
                new PersonEntity() {FirstName = "Wanda", LastName = "Maximoff"},
                new PersonEntity() {FirstName = "Thor", LastName = "Odinson"},
            };
            foreach (var entity in people)
            {
                context.Set<PersonEntity>().Add(entity);
            }
            context.SaveChanges();
        }
    }
}