"use strict";
const router_1 = require("@angular/router");
const people_list_component_1 = require("./people/people-list.component");
const appRoutes = [
    {
        path: '',
        component: people_list_component_1.PeopleListComponent
    }
];
exports.routing = router_1.RouterModule.forRoot(appRoutes);
//# sourceMappingURL=app.routing.js.map