import { Routes } from '@angular/router';
import { UsersComponent } from './users/users.component';
import { RestaurantsComponent } from './restaurants/restaurants.component';
import { DiningReviewsComponent } from './dining-reviews/dining-reviews.component';
import { HomeComponent } from './home/home.component';

export const routes: Routes = [
  { path: 'home', component: HomeComponent },
  { path: 'users', component: UsersComponent },
  { path: 'restaurants', component: RestaurantsComponent },
  { path: 'dining-reviews', component: DiningReviewsComponent },
  { path: '', redirectTo: '/home', pathMatch: 'full' },
];