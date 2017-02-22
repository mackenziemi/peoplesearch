import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { Person } from '../people/person';
import { PeopleService } from '../shared/people.service';

@Component({
    selector: 'people-list',
    templateUrl: 'app/people/people-list.component.template.html',
    styleUrls: ['app/people/people-list.component.css']

})
export class PeopleListComponent implements OnInit {

    items: Person[];
    errorMessage: string;

    constructor(private peopleService: PeopleService,
        private router: Router) { }

    getPeople() {

        this.peopleService.get("")
            .subscribe(people => this.items = people,
            error => this.errorMessage = <any>error);
        console.log("Error Message: " + this.errorMessage);
    }

    ngOnInit() {
        this.getPeople();
    }
}
