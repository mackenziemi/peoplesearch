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
var http_1 = require("@angular/http");
var Observable_1 = require("rxjs/Observable");
require("rxjs/add/operator/map");
require("rxjs/add/operator/toPromise");
var PeopleService = (function () {
    function PeopleService(http) {
        this.http = http;
        this.baseUrl = "http://localhost:35767/api/people/"; //web api URL
    }
    PeopleService.prototype.get = function (filter) {
        if (filter == null) {
            url = this.baseUrl;
            return this.http.get(url)
                .map(function (response) { return response.json(); });
        }
        else {
            var url = this.baseUrl + "?filter=" + filter;
            return this.http.get(url)
                .map(function (response) { return response.json(); });
        }
    };
    PeopleService.prototype.handleError = function (error) {
        // output error to the console
        console.error(error);
        return Observable_1.Observable.throw(error.json().error || "Server error");
    };
    return PeopleService;
}());
PeopleService = __decorate([
    core_1.Injectable(),
    __metadata("design:paramtypes", [http_1.Http])
], PeopleService);
exports.PeopleService = PeopleService;
//# sourceMappingURL=people.service.js.map