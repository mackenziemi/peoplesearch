"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
const core_1 = require("@angular/core");
const router_1 = require("@angular/router");
const people_service_1 = require("../shared/people.service");
let PeopleListComponent = class PeopleListComponent {
    constructor(peopleService, router) {
        this.peopleService = peopleService;
        this.router = router;
    }
    getPeople(filter) {
        this.peopleService.get(filter)
            .subscribe(people => this.items = people, error => this.errorMessage = error);
        console.log("Error Message: " + this.errorMessage);
    }
    ngOnInit() {
        this.getPeople("");
    }
    onFilterChanged(newValue) {
        this.filterText = newValue;
        this.getPeople(newValue);
        console.log("Filter is: " + this.filterText);
    }
};
PeopleListComponent = __decorate([
    core_1.Component({
        selector: 'people-list',
        templateUrl: 'app/people/people-list.component.template.html',
        styleUrls: ['app/people/people-list.component.css']
    }),
    __metadata("design:paramtypes", [people_service_1.PeopleService,
        router_1.Router])
], PeopleListComponent);
exports.PeopleListComponent = PeopleListComponent;
//# sourceMappingURL=people-list.component.js.map