import { Component, OnInit, ViewEncapsulation } from "@angular/core";
import { Router } from "@angular/router";
import { Person } from '../people/person';
import { PeopleService } from '../shared/people.service';

import { SpinnerComponent } from '../spinner/spinner.component';
import { SpinnerService } from '../shared/spinner.service';

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
        private spinnerService: SpinnerService) { }

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
        this.spinnerService.show();
        setTimeout(() => {
                this.filterText = newValue;
                this.getPeople(newValue);
                this.spinnerService.hide();
                console.log("Slow Filter is: " + this.filterText);
            },
            5000);
    }
}
