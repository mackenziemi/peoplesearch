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
                new PersonEntity() {FirstName = "Tony", LastName = "Stark", Address="10880 Malibu Point", City="Malibu", State="CA", ZipCode = "90265", Age=42, Interests="technology, wit, Pepper Potts", PictureURI="http://www.sprinklesandbooze.com/wp/wp-content/uploads/2013/05/Tony-Stark-1.jpg"},
                new PersonEntity() {FirstName = "Natasha", LastName = "Romanova", Address="95 Olive Ave.", City="Westbury", State="NY", ZipCode = "11590", Age=29, Interests="espionage", PictureURI="http://static.comicvine.com/uploads/original/13/132262/3695055-7236217694-Aveng.jpg"},
                new PersonEntity() {FirstName = "Steven", LastName = "Rogers", Address="85 Smoky Hollow Court ", City="Baltimore", State="MD", ZipCode = "21206", Age=42, Interests="us history, the US constitution", PictureURI="http://i.annihil.us/u/prod/marvel/movies/civilwar/images/captainamerica_hero.png"},
                new PersonEntity() {FirstName = "Bruce", LastName = "Banner", Address="85 Smoky Hollow Court ", City="Tonawanda", State="NY", ZipCode = "14150", Age=46, Interests="", PictureURI="http://vignette4.wikia.nocookie.net/marvelmovies/images/d/d0/BruceBanner_AOU.jpg/revision/latest/scale-to-width-down/280?cb=20150427054746"},
                new PersonEntity() {FirstName = "Carol", LastName = "Danvers", Address="8919 Washington Street", City="Salt Lake City", State="UT", ZipCode = "84119", Age=24, Interests="the air force, space", PictureURI="http://static2.comicvine.com/uploads/original/6/66303/3498579-capmarv2014001cov-7ff9e.jpg"},
                new PersonEntity() {FirstName = "Sam", LastName = "Wilson", Address="8557 South Hanover St.", City="Seymour", State="IN", ZipCode = "47274", Age=33, Interests="birds and flying", PictureURI="http://comicattack.net/wp-content/uploads/2017/02/Sam_Wilson_Falcon_-_Ant-Man.png"},
                new PersonEntity() {FirstName = "Hank", LastName = "Pym", Address="92 Parker Ave.", City="Hinesville", State="GA", ZipCode = "31313", Age=51, Interests="chemistry, physics, and ants", PictureURI="http://vignette4.wikia.nocookie.net/marvelcinematicuniverse/images/a/a5/Ant-man-new-posters-and-tv-spot-1200x648-1-.jpg/revision/latest?cb=20150919075954"},
                new PersonEntity() {FirstName = "Clinton", LastName = "Barton", Address="9169 Pearl Dr.", City="Charlottesville", State="VA", ZipCode = "22801", Age=34, Interests="archery and secrets", PictureURI="http://vignette2.wikia.nocookie.net/ironman/images/5/55/Photo(282).jpg/revision/latest?cb=20130705150439"},
                new PersonEntity() {FirstName = "Luke", LastName = "Cage", Address="565 Westport Ave.", City="Gainesville", State="VA", ZipCode = "20155", Age=26, Interests="music and hip hop", PictureURI="https://assets3.thrillist.com/v1/image/1775533/size/tmg-article_default_mobile.jpg"},
                new PersonEntity() {FirstName = "Thor", LastName = "Odinson", Address="534 Thompson Street", City="Hoffman Estates", State="IL", ZipCode = "60169", Age=132, Interests="norse mythology", PictureURI="https://i.ytimg.com/vi/7p7rocHEecE/maxresdefault.jpg"},
            };
            foreach (var entity in people)
            {
                context.Set<PersonEntity>().Add(entity);
            }
            context.SaveChanges();
        }
    }
}