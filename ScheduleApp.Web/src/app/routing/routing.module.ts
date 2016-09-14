import { Routes, RouterModule } from '@angular/router';

import {
    LandingPageComponent,
    SchedulePageComponent,
    ChannelListingPageComponent
} from "../pages";

export const routes: Routes = [
    {
        path: '',
        component: LandingPageComponent
    },
    {
        path: 'schedule',
        component: SchedulePageComponent
    },
    {
        path: 'channellisting',
        component: ChannelListingPageComponent
    }
];

export const RoutingModule = RouterModule.forRoot([
    ...routes
]);

export const routedComponents = [
    LandingPageComponent,
    SchedulePageComponent,
    ChannelListingPageComponent
];

