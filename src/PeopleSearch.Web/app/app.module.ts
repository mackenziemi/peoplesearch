import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import { FormsModule } from '@angular/forms';

import { AppComponent }   from './app.component';
import { Dashboard } from './dashboard/dashboard.component';
import { PersonalCabinet } from './personalCabinet/personalCabinet.component';
import { PeopleListComponent} from './people/people-list.component';
import { PeopleService } from "./shared/people.service";

import { routing } from './app.routing';


@NgModule({
    imports: [BrowserModule, FormsModule, HttpModule, routing],
    providers: [PeopleService],
    declarations: [AppComponent, Dashboard, PersonalCabinet, PeopleListComponent],
    bootstrap: [AppComponent]
})

export class AppModule {}