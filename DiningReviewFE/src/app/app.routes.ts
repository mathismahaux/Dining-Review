import { Routes } from '@angular/router';
import { UsersComponent } from './users/users.component';
import { RestaurantsComponent } from './restaurants/restaurants.component';
import { DiningReviewsComponent } from './dining-reviews/dining-reviews.component';

export const routes: Routes = [
  { path: 'users', component: UsersComponent },
  { path: 'restaurants', component: RestaurantsComponent },
  { path: 'dining-reviews', component: DiningReviewsComponent },
  { path: '', redirectTo: '/users', pathMatch: 'full' },
];