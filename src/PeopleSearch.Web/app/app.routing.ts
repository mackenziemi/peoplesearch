import { ModuleWithProviders }  from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { Dashboard } from './dashboard/dashboard.component';
import { PersonalCabinet } from './personalCabinet/personalCabinet.component';
import { PeopleListComponent} from './people/people-list.component';

const appRoutes: Routes = [
    {
        path: '',
        component: PeopleListComponent
    },
    {
        path: 'personal',
        component: PersonalCabinet
    },
    {
        path: 'dashboard',  // otherwise route.
        component: Dashboard
    }
];


export const routing: ModuleWithProviders = RouterModule.forRoot(appRoutes);