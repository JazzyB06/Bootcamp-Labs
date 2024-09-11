import { Routes } from '@angular/router';
import { DonutsComponent } from './donuts/donuts.component';
import { FamousPeopleComponent } from './famous-people/famous-people.component';


export const routes: Routes = [

    { path: 'donuts', component: DonutsComponent },
    { path: 'famous-people', component: FamousPeopleComponent }
    
];
