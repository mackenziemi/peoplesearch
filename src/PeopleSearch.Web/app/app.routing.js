"use strict";
const router_1 = require("@angular/router");
const dashboard_component_1 = require("./dashboard/dashboard.component");
const personalCabinet_component_1 = require("./personalCabinet/personalCabinet.component");
const people_list_component_1 = require("./people/people-list.component");
const appRoutes = [
    {
        path: '',
        component: people_list_component_1.PeopleListComponent
    },
    {
        path: 'personal',
        component: personalCabinet_component_1.PersonalCabinet
    },
    {
        path: 'dashboard',
        component: dashboard_component_1.Dashboard
    }
];
exports.routing = router_1.RouterModule.forRoot(appRoutes);
//# sourceMappingURL=app.routing.js.map