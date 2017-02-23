"use strict";
var Person = (function () {
    function Person(FirstName, LastName, Address, City, State, ZipCode, Age, Interests, PictureURI) {
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Address = Address;
        this.City = City;
        this.State = State;
        this.ZipCode = ZipCode;
        this.Age = Age;
        this.Interests = Interests;
        this.PictureURI = PictureURI;
    }
    return Person;
}());
exports.Person = Person;
//# sourceMappingURL=person.js.map