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
var core_1 = require("@angular/core");
var router_1 = require("@angular/router");
var people_service_1 = require("../shared/people.service");
var ng2_slim_loading_bar_1 = require("ng2-slim-loading-bar");
var PeopleListComponent = (function () {
    function PeopleListComponent(peopleService, router, slimLoadingBarService) {
        this.peopleService = peopleService;
        this.router = router;
        this.slimLoadingBarService = slimLoadingBarService;
        this.spinTimeout = 1;
    }
    PeopleListComponent.prototype.getPeople = function (filter) {
        var _this = this;
        this.peopleService.get(filter)
            .subscribe(function (people) { return _this.items = people; }, function (error) { return _this.errorMessage = error; });
        console.log("Error Message: " + this.errorMessage);
    };
    PeopleListComponent.prototype.ngOnInit = function () {
        this.getPeople("");
    };
    PeopleListComponent.prototype.onFilterChanged = function (newValue) {
        this.filterText = newValue;
        this.getPeople(newValue);
        console.log("Filter is: " + this.filterText);
    };
    PeopleListComponent.prototype.onSlowFilterChange = function (newValue) {
        var _this = this;
        this.startLoading();
        setTimeout(function () {
            _this.filterText = newValue;
            _this.getPeople(newValue);
            _this.stopLoading();
            _this.resetLoading();
            console.log("Slow Filter is: " + _this.filterText);
        }, 5000);
    };
    PeopleListComponent.prototype.startLoading = function () {
        this.slimLoadingBarService.start(function () {
            console.log('Loading complete');
        });
    };
    PeopleListComponent.prototype.stopLoading = function () {
        this.slimLoadingBarService.stop();
    };
    PeopleListComponent.prototype.completeLoading = function () {
        this.slimLoadingBarService.complete();
    };
    PeopleListComponent.prototype.resetLoading = function () {
        this.slimLoadingBarService.reset();
    };
    return PeopleListComponent;
}());
PeopleListComponent = __decorate([
    core_1.Component({
        selector: 'people-list',
        templateUrl: 'app/people/people-list.component.template.html',
        styleUrls: ['app/people/people-list.component.css'],
        encapsulation: core_1.ViewEncapsulation.None,
    }),
    __metadata("design:paramtypes", [people_service_1.PeopleService,
        router_1.Router,
        ng2_slim_loading_bar_1.SlimLoadingBarService])
], PeopleListComponent);
exports.PeopleListComponent = PeopleListComponent;
//# sourceMappingURL=people-list.component.js.map