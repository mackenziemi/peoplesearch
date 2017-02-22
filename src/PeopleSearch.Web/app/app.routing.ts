import { ModuleWithProviders }  from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PeopleListComponent} from './people/people-list.component';

const appRoutes: Routes = [
    {
        path: '',
        component: PeopleListComponent
    }
];


export const routing: ModuleWithProviders = RouterModule.forRoot(appRoutes);