import { Component, OnInit, ViewEncapsulation } from "@angular/core";
import { Router } from "@angular/router";
import { Person } from '../people/person';
import { PeopleService } from '../shared/people.service';

import { SlimLoadingBarService } from 'ng2-slim-loading-bar';

@Component({
    selector: 'people-list',
    templateUrl: 'app/people/people-list.component.template.html',
    styleUrls: ['app/people/people-list.component.css'],
    encapsulation: ViewEncapsulation.None,
})
export class PeopleListComponent implements OnInit {

    items: Person[];
    errorMessage: string;
    public filterText: string;
    private spinTimeout: number = 1;

    constructor(private peopleService: PeopleService,
        private router: Router,
        private slimLoadingBarService: SlimLoadingBarService) { }

    getPeople(filter: string) {

        this.peopleService.get(filter)
            .subscribe(people => this.items = people,
            error => this.errorMessage = <any>error);
        console.log("Error Message: " + this.errorMessage);
    }

    ngOnInit() {
        this.getPeople("");
    }

    public onFilterChanged(newValue) :void {
        this.filterText = newValue;
        this.getPeople(newValue);
        console.log("Filter is: " + this.filterText);
    }

    public onSlowFilterChange(newValue): void {
        this.startLoading();
        setTimeout(() => {
                this.filterText = newValue;
                this.getPeople(newValue);
                this.stopLoading();
                this.resetLoading();
                console.log("Slow Filter is: " + this.filterText);
            },
            5000);
    }

    startLoading() {
        this.slimLoadingBarService.start(() => {
            console.log('Loading complete');
        });
    }

    stopLoading() {
        this.slimLoadingBarService.stop();
    }

    completeLoading() {
        this.slimLoadingBarService.complete();
    }

    resetLoading() {
        this.slimLoadingBarService.reset();
    }
}
