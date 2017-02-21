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
                new PersonEntity() {FirstName = "Tony", LastName = "Stark", Address="10880 Malibu Point", City="Malibu", State="CA", ZipCode = "90265", Age=42, Interests="technology, wit, Pepper Potts", PictureURI=""},
                new PersonEntity() {FirstName = "Natasha", LastName = "Romanova", Address="95 Olive Ave.", City="Westbury", State="NY", ZipCode = "11590", Age=29, Interests="espionage", PictureURI=""},
                new PersonEntity() {FirstName = "Steven", LastName = "Rogers", Address="85 Smoky Hollow Court ", City="Baltimore", State="MD", ZipCode = "21206", Age=42, Interests="us history, the US constitution", PictureURI=""},
                new PersonEntity() {FirstName = "Bruce", LastName = "Banner", Address="85 Smoky Hollow Court ", City="Tonawanda", State="NY", ZipCode = "14150", Age=46, Interests="", PictureURI=""},
                new PersonEntity() {FirstName = "Carol", LastName = "Danvers", Address="8919 Washington Street", City="Salt Lake City", State="UT", ZipCode = "84119", Age=24, Interests="the air force, space", PictureURI=""},
                new PersonEntity() {FirstName = "Sam", LastName = "Wilson", Address="8557 South Hanover St.", City="Seymour", State="IN", ZipCode = "47274", Age=33, Interests="birds and flying", PictureURI=""},
                new PersonEntity() {FirstName = "Hank", LastName = "Pym", Address="92 Parker Ave.", City="Hinesville", State="GA", ZipCode = "31313", Age=51, Interests="chemistry, physics, and ants", PictureURI=""},
                new PersonEntity() {FirstName = "Clinton", LastName = "Barton", Address="9169 Pearl Dr.", City="Charlottesville", State="VA", ZipCode = "22801", Age=34, Interests="archery and secrets", PictureURI=""},
                new PersonEntity() {FirstName = "Luke", LastName = "Cage", Address="565 Westport Ave.", City="Gainesville", State="VA", ZipCode = "20155", Age=26, Interests="music and hip hop", PictureURI=""},
                new PersonEntity() {FirstName = "Thor", LastName = "Odinson", Address="534 Thompson Street", City="Hoffman Estates", State="IL", ZipCode = "60169", Age=132, Interests="norse mythology", PictureURI=""},
            };
            foreach (var entity in people)
            {
                context.Set<PersonEntity>().Add(entity);
            }
            context.SaveChanges();
        }
    }
}