import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import { FormsModule } from '@angular/forms';

import { AppComponent }   from './app.component';
import { PeopleListComponent} from './people/people-list.component';
import { PeopleService } from "./shared/people.service";

import { routing } from './app.routing';

import { SpinnerComponent } from './spinner/spinner.component';
import { SpinnerService } from './shared/spinner.service';

@NgModule({
    imports: [BrowserModule, FormsModule, HttpModule, routing],
    providers: [PeopleService, SpinnerService],
    declarations: [AppComponent, PeopleListComponent, SpinnerComponent],
    bootstrap: [AppComponent]
})

export class AppModule {}