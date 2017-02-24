import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import { FormsModule } from '@angular/forms';

import { AppComponent }   from './app.component';
import { PeopleListComponent} from './people/people-list.component';
import { PeopleService } from "./shared/people.service";

import { routing } from './app.routing';

import { SlimLoadingBarModule, SlimLoadingBarService } from 'ng2-slim-loading-bar';


@NgModule({
    imports: [BrowserModule, FormsModule, HttpModule, routing, SlimLoadingBarModule.forRoot()],
    providers: [PeopleService, SlimLoadingBarService],
    declarations: [AppComponent, PeopleListComponent],
    bootstrap: [AppComponent]
})

export class AppModule {}